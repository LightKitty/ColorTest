namespace ColorTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button16Confim = new System.Windows.Forms.Button();
            this.textBoxColor16 = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRGBConfim = new System.Windows.Forms.Button();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button16Confim
            // 
            this.button16Confim.Location = new System.Drawing.Point(85, 18);
            this.button16Confim.Name = "button16Confim";
            this.button16Confim.Size = new System.Drawing.Size(60, 23);
            this.button16Confim.TabIndex = 0;
            this.button16Confim.Text = "确定";
            this.button16Confim.UseVisualStyleBackColor = true;
            this.button16Confim.Click += new System.EventHandler(this.button16Confim_Click);
            // 
            // textBoxColor16
            // 
            this.textBoxColor16.Location = new System.Drawing.Point(8, 20);
            this.textBoxColor16.Name = "textBoxColor16";
            this.textBoxColor16.Size = new System.Drawing.Size(73, 21);
            this.textBoxColor16.TabIndex = 1;
            this.textBoxColor16.Text = "#000000";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelColor.Location = new System.Drawing.Point(12, 9);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(74, 19);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "颜色预览：";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(16, 31);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(116, 128);
            this.panelColor.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxColor16);
            this.groupBox1.Controls.Add(this.button16Confim);
            this.groupBox1.Location = new System.Drawing.Point(141, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "十六进制";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAlpha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonRGBConfim);
            this.groupBox2.Controls.Add(this.textBoxBlue);
            this.groupBox2.Controls.Add(this.textBoxGreen);
            this.groupBox2.Controls.Add(this.textBoxRed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(141, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARGB";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(23, 14);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(58, 21);
            this.textBoxAlpha.TabIndex = 7;
            this.textBoxAlpha.Text = "255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            // 
            // buttonRGBConfim
            // 
            this.buttonRGBConfim.Location = new System.Drawing.Point(87, 93);
            this.buttonRGBConfim.Name = "buttonRGBConfim";
            this.buttonRGBConfim.Size = new System.Drawing.Size(60, 23);
            this.buttonRGBConfim.TabIndex = 2;
            this.buttonRGBConfim.Text = "确定";
            this.buttonRGBConfim.UseVisualStyleBackColor = true;
            this.buttonRGBConfim.Click += new System.EventHandler(this.buttonARGBConfim_Click);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(23, 95);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(58, 21);
            this.textBoxBlue.TabIndex = 5;
            this.textBoxBlue.Text = "0";
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(23, 68);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(58, 21);
            this.textBoxGreen.TabIndex = 4;
            this.textBoxGreen.Text = "0";
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(23, 41);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(58, 21);
            this.textBoxRed.TabIndex = 3;
            this.textBoxRed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "R";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(16, 165);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(60, 23);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "帮助";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 213);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.labelColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "颜色预览";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button16Confim;
        private System.Windows.Forms.TextBox textBoxColor16;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRGBConfim;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelp;
    }
}

