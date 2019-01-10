using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScreen screen = new frmScreen();
            screen.WindowState = FormWindowState.Maximized;
            screen.Show();
            screen.FormClosing += new FormClosingEventHandler(screen_FormClosing);
        }

        void screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
