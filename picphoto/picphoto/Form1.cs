using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace picphoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int photoNo = 1;//定义一个变量
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnfirst_Click(object sender, EventArgs e)
        {
            photoNo = 1;
            picphoto.ImageLocation = string.Format(@"..\..\images\{0}.jpg", photoNo);
        }
        /// <summary>
        /// 上一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btngo_Click(object sender, EventArgs e)
        {
            photoNo = photoNo - 1;
            if (photoNo < 1)
            {
                photoNo = 1;
            }
            else
            {
                picphoto.ImageLocation = string.Format(@"..\..\images\{0}.jpg", photoNo);
            }

        }
        /// <summary>
        /// 下一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndown_Click(object sender, EventArgs e)
        {
            photoNo = photoNo +1;
            if ( photoNo> 8)
            {
                photoNo = 8;
            }
            else
            {
                picphoto.ImageLocation = string.Format(@"..\..\images\{0}.jpg", photoNo);
            }
        }
        /// <summary>
        /// 最后一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlast_Click(object sender, EventArgs e)
        {
            photoNo = 8;
            picphoto.ImageLocation = string.Format(@"..\..\images\{0}.jpg", photoNo);
        }
        /// <summary>
        /// 放大
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picphoto.ImageLocation=@"..\..\images\2.jpg";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picphoto.ImageLocation = @"..\..\images\3.jpg";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picphoto.ImageLocation = @"..\..\images\4.jpg";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picphoto.ImageLocation = @"..\..\images\5.jpg";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picphoto.ImageLocation = @"..\..\images\6.jpg";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            picphoto.ImageLocation = @"..\..\images\7.jpg";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            picphoto.ImageLocation = @"..\..\images\8.jpg";
        }

        private void picphoto_Click(object sender, EventArgs e)
        {
            
            photoNo = photoNo+1;
            if (photoNo>8)
            {
                photoNo = 0;
            }
            else 
            {
                picphoto.ImageLocation = string.Format(@"..\..\images\{0}.jpg", photoNo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            photoNo = photoNo + 1;
            if (photoNo > 8)
            {
                photoNo = 0;
            }
            else
            {
                picphoto.ImageLocation = string.Format(@"..\..\images\{0}.jpg", photoNo);
            }
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ToolSOpen_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void 停止自动换片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
