using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 三层架构.Model;
using 三层架构.DAL;
using 三层架构.BLL;
namespace 三层架构
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExecutescalar_Click(object sender, EventArgs e)//查询一个值
        {
            users model = new users();
            model.userid = "admin";
            model.userpass = 123456;
            PersonBLL person = new PersonBLL();
            int ExecuteScalar= person.selectNew(model);
            MessageBox.Show("查询到的值为"+ExecuteScalar.ToString());
            

        }

        private void btnInsert_Click(object sender, EventArgs e)//添加数据
        {
            users model = new users();
            model.userid = "xiao";
            model.userpass = 1234567;
            PersonBLL person = new PersonBLL();
            person.insert(model);
            MessageBox.Show("添加成功");
        }

        private void btnDel_Click(object sender, EventArgs e)//删除数据
        {
            PersonBLL person = new PersonBLL();
            users model = new users();
            model.userid = "xiaomi";
            person.delete(model);
            MessageBox.Show("删除成功");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)//更新
        {
            PersonBLL person = new PersonBLL();
            users model = new users();
            model.userid = "zhouyong";
            person.update(2,model);
            MessageBox.Show("更新成功成功");
        }

        private void btnSelect_Click(object sender, EventArgs e)//查询数据
        {
            PersonBLL person = new PersonBLL();
            users model = new users();
            model=person.get("456");
            MessageBox.Show("用户名"+model.userid+"密码"+model.userpass);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvselect.DataSource = new PersonBLL().GetAll(); //显示数据
        }

    }
}
