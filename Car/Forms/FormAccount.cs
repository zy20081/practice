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
namespace Car
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            show(); 

        }
        /// <summary>
        /// 全部显示
        /// </summary>
        private void show() 
        {
            TrafficBLL showccount = new TrafficBLL();
            DataTable dt = showccount.showAccount();
            dgvInfo.DataSource = dt;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            keySearch();
        }
        /// <summary>
        /// 模糊搜索
        /// </summary>
        private void keySearch() 
        {
            TrafficBLL key = new TrafficBLL();
            ccountModel model=new ccountModel();
            model.month= (string)cbomonth.SelectedItem;
            model.year=(string)cboyear.SelectedItem;
            DataTable dt = key.showkey(txtkey.Text.Trim(), model.month, model.year );
            dgvInfo.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            show(); 
        }

        private void btnCount_Click(object sender, EventArgs e)//利润按年/月结算
        {
            TrafficBLL BLL = new TrafficBLL();
            ccountModel model=new ccountModel();
            if (string.IsNullOrEmpty(cboReslutmonth.SelectedItem.ToString())||string.IsNullOrEmpty(cboReslutyear.SelectedItem.ToString()))
            {
                MessageBox.Show("月份或年份不能为空");
                return;
            }
            else 
            {
                string month = cboReslutmonth.SelectedItem.ToString();
                string year = cboReslutyear.SelectedItem.ToString();
                ccountModel reslut = BLL.result(month,year,model);
                labreslut.Text = reslut.reslut;
            }
          
         
        }
    }
}
