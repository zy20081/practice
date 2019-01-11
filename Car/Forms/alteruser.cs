using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Car.Model;
using Car.BLL;
namespace Car.Forms
{
    public partial class alteruser : Form
    {
        public alteruser()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtUserPwd1.Text!=txtUserPwd2.Text) 
            {
                MessageBox.Show("输入的密码不一样");
            }
            Users alterUser = new Users();
            alterUser.UID = txtUserName.Text;
            alterUser.pwd = txtUserPwd.Text;
            alterUser.sex = cboSex.SelectedItem.ToString();
            TrafficBLL BLL = new TrafficBLL();
            BLL.Update(alterUser);
            MessageBox.Show("修改成功");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
