using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
namespace ScreenCapture
{
    public partial class frmScreen : Form
    {
        public frmScreen()
        {
            InitializeComponent();
        }
        private Point startPoint = Point.Empty;
        private Point endPoint = Point.Empty;
        public Rectangle rect = Rectangle.Empty;
        private void frmScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void frmScreen_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frmScreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.startPoint = e.Location;
            }
        }

        private void frmScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.endPoint = e.Location;
                Graphics grp = this.CreateGraphics();
                
                rect = new Rectangle();
                rect.X = (this.startPoint.X <= this.endPoint.X) ? this.startPoint.X : this.endPoint.X;
                rect.Y = (this.startPoint.Y <= this.endPoint.Y) ? this.startPoint.Y : this.endPoint.Y;
                rect.Width = Math.Abs(this.endPoint.X-this.startPoint.X);
                rect.Height = Math.Abs(this.endPoint.Y - this.startPoint.Y);
                grp.Clear(this.BackColor);
                Rectangle border = new Rectangle(); //这个是边框矩形
                border.X = rect.X - 1;
                border.Y = rect.Y - 1;
                border.Width = rect.Width;
                border.Height = rect.Height;
                grp.DrawRectangle(Pens.Blue, border);
                grp.FillRectangle(Brushes.Red, rect);
           
            }
        }

        private void frmScreen_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.rect.Width,this.rect.Height);
            Graphics grp = Graphics.FromImage(bitmap);
            grp.SmoothingMode = SmoothingMode.HighQuality;
            //从指定的区域中复制图形
            grp.CopyFromScreen(this.rect.X, this.rect.Y, 0, 0, this.rect.Size);
           ImageFormat format=ImageFormat.Jpeg;
           saveFile.Filter = "图片|*.jpg";
           saveFile.ShowDialog();
           string strfile = saveFile.FileName;
           bitmap.Save(strfile);
            this.Close();
            MessageBox.Show("截图成功");
        }
    }
}
