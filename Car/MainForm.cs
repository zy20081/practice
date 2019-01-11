using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //添加用户信息
        private void TSMIAddusers_Click(object sender, EventArgs e)
        {
            new Car.Forms.addusers().ShowDialog();
        }
        //修改用户密码
        private void TSMIalterUsers_Click(object sender, EventArgs e)
        {
            new Car.Forms.alteruser().ShowDialog();
        }

        private void TSMIshow_Click(object sender, EventArgs e)
        {
            new Car.Forms.ShowUsers().ShowDialog();
        }
        //结算
        private void TSMIaccounts_Click(object sender, EventArgs e)
        {
            new Car.FormAccount().ShowDialog();
        }
        //租凭管理
        private void TSMIrent_Click(object sender, EventArgs e)
        {
            new Car.Form1().ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        
    }
}
