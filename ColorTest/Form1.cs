using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16Confim_Click(object sender, EventArgs e)
        {
            try
            {
                //16进制声明颜色
                Color color = ColorTranslator.FromHtml(textBoxColor16.Text.Trim());

                //显示颜色
                labelColor.ForeColor = color;
                panelColor.BackColor = color;

                //显示ARGB分量
                textBoxAlpha.Text = color.A.ToString();
                textBoxRed.Text = color.R.ToString();
                textBoxGreen.Text = color.G.ToString();
                textBoxBlue.Text = color.B.ToString();
            }
            catch(Exception Err)
            {
                MessageBox.Show(Err.Message);

                //重置textBox文本
                rset();
            }
        }

        private void buttonARGBConfim_Click(object sender, EventArgs e)
        {
            try
            {
                int A = 255;
                //ARGB声明颜色
                if (textBoxAlpha.Text.Trim() != string.Empty)
                { A = int.Parse(textBoxAlpha.Text.Trim()); }
                
                int R = int.Parse(textBoxRed.Text.Trim());
                int G = int.Parse(textBoxGreen.Text.Trim());
                int B = int.Parse(textBoxBlue.Text.Trim());
                Color color = Color.FromArgb(A, R, G, B);

                //显示颜色
                labelColor.ForeColor = color;
                panelColor.BackColor = color;

                //显示颜色16进制
                if (A == 255)
                {
                    //透明度255，输出6位16进制颜色
                    textBoxColor16.Text = ColorTranslator.ToHtml(color);
                }
                else
                {
                    //透明度非255，输出8位16进制颜色
                    string colorText = ColorTranslator.ToHtml(color);
                    string A10 = A.ToString("x8").Substring(6);//十进制转化为十六进制
                    textBoxColor16.Text = colorText.Insert(1, A10);
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);

                //重置textBox文本
                rset();
            }
        }

        //重置软件显示
        private void rset()
        {
            Color color = ColorTranslator.FromHtml("#000000");

            //显示颜色
            labelColor.ForeColor = color;
            panelColor.BackColor = color;

            textBoxColor16.Text = "#000000";
            textBoxAlpha.Text = "255";
            textBoxRed.Text = "0";
            textBoxGreen.Text = "0";
            textBoxBlue.Text = "0";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //显示帮助
            string helpStr = "文字“颜色预览：”没有透明度，文字下区域有透明度，故透明度非255时文字与区域颜色不同。\n8位的16进制颜色前两位为透明度，后6位与6位的16进制颜色意义相同。\n\n联系开发者：WinterTone@163.com";
            MessageBox.Show(helpStr, "帮助");
        }

    }
}
