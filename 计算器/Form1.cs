using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ClearDisplay = true;//清空第一次
        private string Operand;//记录加.减，乘。除
        private double Operand1;//第一个数字
        private double Operand2;//第二个数字
        private double reslult;
        
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblwindows.Text == "0"||ClearDisplay==true)
            {
                lblwindows.Text = ((Button)sender).Text;
                ClearDisplay = false;
            }
            else
            {
                lblwindows.Text = lblwindows.Text + ((Button)sender).Text;
            }
        }
        private void btnfu_Click(object sender, EventArgs e)
        {
            ClearDisplay = true;
            double i = Convert.ToDouble(lblwindows.Text);//取负号
            lblwindows.Text = (0 - i).ToString(); 
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblwindows.Text.Length > 13)
            {
                lblwindows.Text=lblwindows.Text.Substring(0, 14);//Backspace键设置
                lblwindows.Text = lblwindows.Text.Substring(0, lblwindows.Text.Length - 1);
                return;
            }
            if(lblwindows.Text.Length>1)
            {
                lblwindows.Text = lblwindows.Text.Substring(0, lblwindows.Text.Length-1);
                return;
            }
            if (lblwindows.Text.Length==1)
            {
                lblwindows.Text = "0";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            Operand = ((Button)sender).Text;
            ClearDisplay = true;
            Operand1 = Convert.ToDouble(lblwindows.Text);
            
            
        }

        private void lblwindows_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lblwindows.Text = "0";
        }
       
        private void btnEXE_Click(object sender, EventArgs e)
        {
           
                reslult =Convert.ToDouble(lblwindows.Text);
                Operand2 = Convert.ToDouble(lblwindows.Text);
                switch (Operand)
                {
                    case "+": reslult = Operand1 + Operand2; break;
                    case "-": reslult = Operand1 - Operand2; break;
                    case "*": reslult = Operand1 * Operand2; break;
                    case "/":
                        if (Operand2 == 0)
                        {
                            MessageBox.Show("除数不能为0");
                        }
                        else
                        {
                            reslult = Operand1 / Operand2;
                        }
                        break;
                    case "%": reslult = Operand1 % Operand2; break;
                }
                lblwindows.Text = reslult.ToString();
                ClearDisplay = true;
           
        }
        
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!lblwindows.Text.Contains("."))
            {
                lblwindows.Text = lblwindows.Text + ".";
            }
            else { lblwindows.Text = lblwindows.Text; }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            lblwindows.Text = Math.Sqrt(Convert.ToDouble(lblwindows.Text)).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            lblwindows.Text = Math.Sin(Convert.ToDouble(lblwindows.Text)).ToString();
           
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            lblwindows.Text = Math.Tan(Convert.ToDouble(lblwindows.Text)).ToString();
           
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            lblwindows.Text = Math.Cos(Convert.ToDouble(lblwindows.Text)).ToString();
         
        }

        private void btnCountdown_Click(object sender, EventArgs e)
        {
            lblwindows.Text = (1 / Convert.ToDouble(lblwindows.Text)).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblwindows.Text = Math.PI.ToString();
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       }
}
