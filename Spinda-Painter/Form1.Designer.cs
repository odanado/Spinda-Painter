namespace Spinda_Painter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.spot4 = new System.Windows.Forms.PictureBox();
            this.spot3 = new System.Windows.Forms.PictureBox();
            this.spot2 = new System.Windows.Forms.PictureBox();
            this.spot1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 12);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "88888888";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(421, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "グリッド線を表示";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Produced by odan";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(458, 38);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxResult.TabIndex = 7;
            this.pictureBoxResult.TabStop = false;
            // 
            // spot4
            // 
            this.spot4.BackColor = System.Drawing.Color.Transparent;
            this.spot4.BackgroundImage = global::Spinda_Painter.Properties.Resources._327_4_8;
            this.spot4.Location = new System.Drawing.Point(128, 154);
            this.spot4.Name = "spot4";
            this.spot4.Size = new System.Drawing.Size(64, 72);
            this.spot4.TabIndex = 4;
            this.spot4.TabStop = false;
            this.spot4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spot4_MouseDown);
            this.spot4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spot4_MouseMove);
            // 
            // spot3
            // 
            this.spot3.BackColor = System.Drawing.Color.Transparent;
            this.spot3.BackgroundImage = global::Spinda_Painter.Properties.Resources._327_3_8;
            this.spot3.Location = new System.Drawing.Point(26, 148);
            this.spot3.Name = "spot3";
            this.spot3.Size = new System.Drawing.Size(56, 72);
            this.spot3.TabIndex = 3;
            this.spot3.TabStop = false;
            this.spot3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spot3_MouseDown);
            this.spot3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spot3_MouseMove);
            // 
            // spot2
            // 
            this.spot2.BackColor = System.Drawing.Color.Transparent;
            this.spot2.BackgroundImage = global::Spinda_Painter.Properties.Resources._327_2_8;
            this.spot2.Location = new System.Drawing.Point(128, 46);
            this.spot2.Name = "spot2";
            this.spot2.Size = new System.Drawing.Size(104, 104);
            this.spot2.TabIndex = 2;
            this.spot2.TabStop = false;
            this.spot2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spot2_MouseDown);
            this.spot2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spot2_MouseMove);
            // 
            // spot1
            // 
            this.spot1.BackColor = System.Drawing.Color.Transparent;
            this.spot1.BackgroundImage = global::Spinda_Painter.Properties.Resources._327_1_8;
            this.spot1.Location = new System.Drawing.Point(26, 46);
            this.spot1.Name = "spot1";
            this.spot1.Size = new System.Drawing.Size(96, 96);
            this.spot1.TabIndex = 1;
            this.spot1.TabStop = false;
            this.spot1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spot1_MouseDown);
            this.spot1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spot1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Spinda_Painter.Properties.Resources._327_0_8;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.spot4);
            this.Controls.Add(this.spot3);
            this.Controls.Add(this.spot2);
            this.Controls.Add(this.spot1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "3gen-Spinda-Painter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox spot1;
        private System.Windows.Forms.PictureBox spot2;
        private System.Windows.Forms.PictureBox spot3;
        private System.Windows.Forms.PictureBox spot4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

