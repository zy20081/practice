using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Car.BLL;
using Car.Model;
using System.Security.Cryptography;
namespace Car.Forms
{
    public partial class addusers : Form
    {
        public addusers()
        {
            InitializeComponent();
        }
        //计算字符串 MD5值
       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            TrafficBLL BLL = new TrafficBLL();
            user.UID = txtUserName.Text;
            user.pwd = txtUserPwd.Text;
            user.sex = cboSex.SelectedItem.ToString();
            BLL.AddNew(user);
            MessageBox.Show("添加成功");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
