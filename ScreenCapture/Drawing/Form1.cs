using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics grp = this.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            pen.DashStyle = DashStyle.Solid;
            Rectangle rect = new Rectangle(100, 100, 200, 200);
            grp.DrawRectangle(pen, rect);
            grp.FillRectangle(new SolidBrush(Color.Blue), rect);
            //grp.DrawEllipse(pen, 120, 120, 20, 20);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = string.Format("x={0},y={1}",e.X,e.Y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
