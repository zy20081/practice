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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Car
{
    [Serializable]
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int error = 0;//记录错误次数
        private void btnStep_Click(object sender, EventArgs e)
        {
            //记录错误次数
            TrafficBLL BLL = new TrafficBLL();
            if (BLL.Get(txtUser.Text) == null)//用户名判断
            {
                MessageBox.Show("用户名错误");
                return;
            }
            bool users = BLL.username(txtUser.Text, txtPassword.Text);
            if (users == true)
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("登入成功");
                Close();
            }
            else
            {
                error += 1;
                if (BLL.selectstopped(txtUser.Text) == true)
                {
                    DateTime SstopTime = BLL.selectstoptime(txtUser.Text);
                    Users usersTime = new Users();
                    usersTime.stoptime = DateTime.Now;
                    TimeSpan reslut = usersTime.stoptime - SstopTime;//记录的时间和现在得到的时间差
                    if (reslut.Minutes+reslut.Hours*60 > 30)
                    {
                        BLL.stoppedFalse(txtUser.Text);
                        users = BLL.username(txtUser.Text, txtPassword.Text);
                        if (users == true)
                        {
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("登入成功");
                            Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("30分钟后才能登入");
                        Application.Exit();
                    }
                }

                if (error == 1)
                {
                    MessageBox.Show("密码错误");
                    return;
                }
                if (error == 2)
                {
                    MessageBox.Show("第二次密码错误");
                    return;
                }
                if (error == 3)
                {
                    MessageBox.Show("3次都错了，15分钟后在登入");
                    BLL.stopTime(txtUser.Text);
                    BLL.stoppedTrue(txtUser.Text);
                    Application.Exit();
                }


            }
            if (cboSavePsw.Checked)
            {    //序列化保存源码
                using (FileStream fs = new FileStream("pwd.bin", FileMode.Create))
                {
                    Users user = new Users();
                    user.UID = txtUser.Text;
                    user.pwd = txtPassword.Text;
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, user);
                }
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void User_Load(object sender, EventArgs e)//反序列化加载
        {
            TrafficBLL BLL = new TrafficBLL();
            if (File.Exists("pwd.bin"))
            {
                using (FileStream fs = new FileStream("pwd.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Users user = bf.Deserialize(fs) as Users;
                    txtUser.Text = user.UID;
                    txtPassword.Text = user.pwd;
                }
            }
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cboSavePsw.Checked == false)
            {
                File.Delete("pwd.bin");
            }
        }

        private void labTitle_Click(object sender, EventArgs e)
        {

        }

    }
}
