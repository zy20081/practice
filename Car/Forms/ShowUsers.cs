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
namespace Car.Forms
{
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();
        }

        private void ShowUsers_Load(object sender, EventArgs e)
        {
            show(); 
        }
        /// <summary>
        /// 显示
        /// </summary>
        public void show() 
        {
            TrafficBLL BLL = new TrafficBLL();
            dgvView.DataSource = BLL.ListAll();
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            TrafficBLL BLL = new TrafficBLL();
            Users model = new Users();
            dgvView.DataSource = BLL.showkey(txtSearch.Text);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            show(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Users model = new Users();
            int count =dgvView.SelectedCells.Count;
            if (count == 1) 
            {
                MessageBox.Show("请选中一行");
                return;
            }
            model.UID = dgvView.SelectedRows[0].Cells[0].Value.ToString();
            model.pwd = dgvView.SelectedRows[0].Cells[1].Value.ToString();
            model.sex = dgvView.SelectedRows[0].Cells[2].Value.ToString();
            TrafficBLL BLL = new TrafficBLL();
            BLL.Delete(model);
            MessageBox.Show("删除成功");
            show(); 
            
        }
    }
}
