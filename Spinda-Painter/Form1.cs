using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinda_Painter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private UInt32 PID;

        private int magnification = 8;
        private Color spindaColor = Color.FromArgb(0xAF, 0xDE, 0x6B, 0x39);

        private void Form1_Load(object sender, EventArgs e)
        {

            PID = Convert.ToUInt32(textBox1.Text,16);

            for (int index = 0; index < 4; index++)
            {

                lower[2 * index] = coords[2 * index] + origin[0];
                lower[2 * index + 1] = coords[2 * index + 1] + origin[1];

                upper[2 * index] = 0xf + coords[2 * index] + origin[0];
                upper[2 * index + 1] = 0xf + coords[2 * index + 1] + origin[1];

                lower[2 * index] *= magnification;
                lower[2 * index + 1] *= magnification;

                upper[2 * index] *= magnification;
                upper[2 * index + 1] *= magnification;
            }

            pictureBox1.Controls.Add(spot1);
            pictureBox1.Controls.Add(spot2);
            pictureBox1.Controls.Add(spot3);
            pictureBox1.Controls.Add(spot4);

            setSpot(spot1, 0);
            setSpot(spot2, 1);
            setSpot(spot3, 2);
            setSpot(spot4, 3);

            drawResult();
            setLabel();
        }

        void drawResult()
        {
            Bitmap spinda = Properties.Resources._327_0;
            Bitmap spot = new Bitmap(64, 64);

            //spinda.SetPixel(0, 0, spindaColor);
            Color color = spinda.GetPixel(0, 0);

            for (int i = 0; i < 4; i++)
            {
                int left = (int)(PID >> (i * 8)) & 0xF;
                int top = (int)(PID >> (i * 8 + 4)) & 0xF;

                int x = left + coords[2 * i] + origin[0];
                int y = top + coords[2 * i + 1] + origin[1];

                for (int j = 0; j < spots[i].Length; j++)
                {
                    for (int k = 0; k < spots[i][j].Length; k++)
                    {
                        int nx = x + j;
                        int ny = y + k;

                        if (spots[i][j][k] == '*' && spinda.GetPixel(nx, ny) != color)
                        {
                            spot.SetPixel(nx, ny, spindaColor);
                        }

                    }
                }

            }


            pictureBoxResult.BackgroundImage = spinda;
            pictureBoxResult.Image = spot;


        }

        void setLabel()
        {
            String nature = natures[PID % 25];
            String sex = (PID & 0xff) < 127 ? "♀" : "♂";
            String ability = (PID & 1) == 0 ? "マイペース":"ちどりあし";

            label1.Text = String.Format("({0} / {1} / {2})", nature, sex, ability);

        }

        void drawGrid(PictureBox picBox)
        {
            Bitmap canvas = new Bitmap(picBox.Width, picBox.Height);
            Graphics g = Graphics.FromImage(canvas);

            Pen blackPen = new Pen(Color.Black, 1);

            for (int i = 0; i < 64; i++)
            {
                int y = i * magnification;

                Point point1 = new Point(0, y);
                Point point2 = new Point(pictureBox1.Height, y);

                g.DrawLine(blackPen, point1, point2);
            }
            
            for (int i = 0; i < 64; i++)
            {

                int x = i * magnification;
                Point point1 = new Point(x, 0);
                Point point2 = new Point(x, pictureBox1.Width);

                g.DrawLine(blackPen, point1, point2);
            }

            g.Dispose();
            picBox.Image = canvas;
        }

        private int[] coords = { 0, 0, 24, 1, 6, 18, 18, 19 };
        private int[] origin = { 8, 6 };
        private int[] lower = new int[8];
        private int[] upper = new int[8];

        private void setSpot(PictureBox picBox, int index)
        {
            int left  = (int) (PID >> (index * 8)) & 0xF;
            int top   = (int) (PID >> (index * 8 + 4)) & 0xF;

            left = left + coords[2 * index] + origin[0];
            top  = top  + coords[2 * index + 1] + origin[1];

            picBox.Left = left * magnification;
            picBox.Top = top * magnification;


        }

        private void updatePID(int left, int top, int index)
        {
            uint _left = (uint)(left / magnification - coords[2 * index] - origin[0]);
            uint _top = (uint)(top / magnification - coords[2 * index + 1] - origin[1]);

            uint mask = 0xffffffff;
            uint xor = (uint) 0xff << (index * 8);

            mask ^= xor;

            PID &= mask;
            PID |= (_left << (index * 8));
            PID |= (_top << (index * 8 + 4));

            textBox1.Text = String.Format("{0:X08}", PID);
        }

        private bool check(int left, int top, int index)
        {
            return (lower[2*index] <= left && left <= upper[2*index] &&
                     lower[2*index+1] <= top && top <= upper[2*index+1]
                     );
        }

        #region spots
        String[][] spots =  {
            new String[]
            {"    ***     ",
             "  *******   ",
             " *********  ",
             " ********** ",
             "*********** ",
             "************",
             "************",
             "************",
             " ********** ",
             " ********** ",
             "  ********  ",
             "     ****   "},
             new String[]
            {"     ****    ",
             "   *******   ",
             "  *********  ",
             " *********** ",
             " *********** ",
             "*************",
             "*************",
             "*************",
             " *********** ",
             " *********** ",
             "  *********  ",
             "   ********  ",
             "     ***     "},
             new String[]
            {"  ***  ",
             " ***** ",
             "*******",
             "*******",
             "*******",
             "*******",
             "*******",
             " ***** ",
             "  ***  "},
             new String[]
            {"  ****  ",
             " ****** ",
             "********",
             "********",
             "********",
             "********",
             "********",
             " ****** ",
             "  ****  "}};

        #endregion

        String[] natures = {
                               "がんばりや","さみしがり","ゆうかん","いじっぱり",
                               "やんちゃ","ずぶとい","すなお","のんき","わんぱく",
                               "のうてんき","おくびょう","せっかち","まじめ","ようき",
                               "むじゃき","ひかえめ","おっとり","れいせい","てれや",
                               "うっかりや","おだやか","おとなしい",
                               "なまいき","しんちょう","きまぐれ",
                           };

        private Point spot1MousePoint;
        private Point spot2MousePoint;
        private Point spot3MousePoint;
        private Point spot4MousePoint;

        private void spot1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                spot1MousePoint = new Point(e.X, e.Y);
            }

        }

        private void spot1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int left = spot1.Left + e.X - spot1MousePoint.X;
                int top = spot1.Top + e.Y - spot1MousePoint.Y;

                if (check(left, top, 0))
                {
                    spot1.Left = left - left % magnification;
                    spot1.Top = top - top % magnification;

                    updatePID(spot1.Left, spot1.Top, 0);
                    drawResult();
                    setLabel();

                }

            }
        }

        private void spot2_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                spot2MousePoint = new Point(e.X, e.Y);
            }
        }

        private void spot2_MouseMove(object sender, MouseEventArgs e)
        {

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int left = spot2.Left + e.X - spot2MousePoint.X;
                int top = spot2.Top + e.Y - spot2MousePoint.Y;
                if (check(left, top, 1))
                {
                    spot2.Left = left - left % magnification;
                    spot2.Top = top - top % magnification;

                    updatePID(spot2.Left, spot2.Top, 1);
                    drawResult();
                    setLabel();

                }

            }
        }

        private void spot3_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                spot3MousePoint = new Point(e.X, e.Y);
            }

        }

        private void spot3_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int left = spot3.Left + e.X - spot3MousePoint.X;
                int top = spot3.Top + e.Y - spot3MousePoint.Y;

                if (check(left, top, 2))
                {
                    spot3.Left = left - left % magnification;
                    spot3.Top = top - top % magnification;

                    updatePID(spot3.Left, spot3.Top, 2);
                    drawResult();
                    setLabel();

                }
            }
        }

        private void spot4_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                spot4MousePoint = new Point(e.X, e.Y);
            }

        }

        private void spot4_MouseMove(object sender, MouseEventArgs e)
        {

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int left = spot4.Left + e.X - spot4MousePoint.X;
                int top = spot4.Top + e.Y - spot4MousePoint.Y;

                if (check(left, top, 3))
                {
                    spot4.Left = left - left % magnification;
                    spot4.Top = top - top % magnification;

                    updatePID(spot4.Left, spot4.Top, 3);
                    drawResult();
                    setLabel();

                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                drawGrid(pictureBox1);

            }
            else
            {
                pictureBox1.Image = null;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (1 <= textBox1.Text.Length && textBox1.Text.Length <= 8)
            {
                PID = Convert.ToUInt32(textBox1.Text, 16);
                setSpot(spot1, 0);
                setSpot(spot2, 1);
                setSpot(spot3, 2);
                setSpot(spot4, 3);
                drawResult();

                setLabel();

            }
        }
    

    }
}
