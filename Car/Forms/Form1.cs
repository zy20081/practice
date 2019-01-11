using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Car.DAL;
using Car.BLL;
using Car.Model;
namespace Car
{
    public partial class Form1 : Form
    {

        TrafficInfo tNew;//父类
        XRentManager m_RM;//管理类
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TraMessage();//入库信息

        }
        /// <summary>
        /// 入库信息
        /// </summary>
        public void TraMessage()
        {
            string type = rdoTruck.Checked == true ? "Truck" : "Car";
            tNew = TrafficFactoruy.CreatNewTraffic(type); //工厂模式
            #region 为空判断

            Dictionary<string, string> dicTracffic = new Dictionary<string, string>();
            dicTracffic.Add("车牌号", txtNumber.Text);
            dicTracffic.Add("车名", txtName.Text);
            dicTracffic.Add("车颜色", cbColor.Text);
            dicTracffic.Add("使用时间", txtTime.Text);
            dicTracffic.Add("租金", txtMoney.Text);
            dicTracffic.Add("载重量", txtLoad.Text);
            foreach (string str in dicTracffic.Keys)
            {
                if (dicTracffic[str] == "") //str就是K,dicTracffic[str]就是值
                {
                    MessageBox.Show(string.Format("请输入{0}", str));

                    return;
                }
            }
            #endregion
            #region 非工厂模式创立对象
            //if (rdoCar.Checked == true)
            //{
            //    tNew = new Xcar();//创立对象
            //}
            //if (rdoTruck.Checked == true)
            //{
            //    tNew = new XTruck();
            //} 
            #endregion
            tNew.Number = txtNumber.Text;//车牌号码
            tNew.Name = txtName.Text;//车名
            tNew.Color = cbColor.Text;//车颜色
            tNew.Time = Convert.ToInt32(txtTime.Text);//使用时间
            tNew.Money = int.Parse(txtMoney.Text);//租金
            tNew.Load = txtLoad.Text;//载重
            #region 新增数据
            TrafficBLL insertBLL = new TrafficBLL();
            if (tNew is Xcar)
            {
                insertBLL.AddNewTrafficToDbase(tNew, 1);
            }
            else
            {
                insertBLL.AddNewTrafficToDbase(tNew, 2);
            }
            MessageBox.Show("增加成功");
            #endregion
            addMyTrafficShow();//查到数据然后刷新
            this.tabControl1.SelectedTab = tpRent;//跳过去
        }
        #region 选择车的Load判断
        private void rdoCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCar.Checked == true)//选上
            {
                this.txtLoad.Text = "--无--";
                this.txtLoad.ReadOnly = true;
                this.txtLoad.Cursor = Cursors.No;


            }
            if (rdoTruck.Checked == true)
            {
                this.txtLoad.Text = "";
                this.txtLoad.ReadOnly = false;
                this.txtLoad.Cursor = Cursors.IBeam;
            }

        } 
        #endregion

        /// <summary>
        /// 标题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //dateTime.Text = DateTime.Now.ToString("yyyy/MM/dd");
            dateTime.Text = DateTime.Now.ToString("F");//拿到时间所有
            #region 租车头部显示  
            ColumnHeader colNumeber, colName, colColor, colTime, colMoney, colLoad;
            ColumnHeader[] chArr = new ColumnHeader[6]
            {
                 colNumeber = new ColumnHeader(),
                 colName = new ColumnHeader(),
                 colColor = new ColumnHeader(),
                 colTime = new ColumnHeader(),
                 colMoney = new ColumnHeader(),
                 colLoad = new ColumnHeader()    
            };
            colTime.Width = 100; colLoad.Width = 60; colNumeber.Width = 100; colName.Width = 100;
            chArr[0].Text = "车牌号";
            chArr[1].Text = "车名";
            chArr[2].Text = "车颜色";
            chArr[3].Text = "使用时间";
            chArr[4].Text = "租金";
            chArr[5].Text = "载重量";
            foreach (ColumnHeader ch in chArr)
            {
                ch.TextAlign = HorizontalAlignment.Center;//居中
            }
            listHire.Columns.AddRange(chArr); 
            #endregion
            #region 还车头部显示
            ColumnHeader colBNumeber, colBName, colBColor, colBTime, colBMoney, colBLoad, colBtenant, coldateTime;
            ColumnHeader[] chBack = new ColumnHeader[8]
            {
                 colBNumeber = new ColumnHeader(),
                 colBName = new ColumnHeader(),
                 colBColor = new ColumnHeader(),
                 colBTime = new ColumnHeader(),
                 colBMoney = new ColumnHeader(),
                 colBLoad = new ColumnHeader(),
                 colBtenant = new ColumnHeader(),
                 coldateTime =new ColumnHeader()
            };
            colBTime.Width = 100; colBLoad.Width = 60; colBNumeber.Width = 100; colBName.Width = 100; coldateTime.Width = 100;
            chBack[0].Text = "车牌号";
            chBack[1].Text = "车名";
            chBack[2].Text = "车颜色";
            chBack[3].Text = "使用时间";
            chBack[4].Text = "租金";
            chBack[5].Text = "载重量";
            chBack[6].Text = "租户";
            chBack[7].Text = "出租时间";
            foreach (ColumnHeader ch in chBack)
            {
                ch.TextAlign = HorizontalAlignment.Center;//居中
            }
            listback.Columns.AddRange(chBack); 
            #endregion
            addMyTrafficShow(); 
            addMyRentShow();
        }
        /// <summary>
        /// 加到租车listHire集合然后显示出来/刷新租车表
        /// </summary>
        public void addMyTrafficShow()
        {
            listHire.Items.Clear();
             m_RM = new XRentManager();//实例化一个管理类对象
             TrafficBLL showBLL = new TrafficBLL();
             showBLL.showTraffic(tNew, m_RM);
            foreach (TrafficInfo t in m_RM.DicMyTraffics.Values)//显示子项
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = t.Number;
                ListViewItem.ListViewSubItem[] lvs;
                lvs = new ListViewItem.ListViewSubItem[5]
                     { 
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem()
                     };
                lvs[0].Text = t.Name;
                lvs[1].Text = t.Color;
                lvs[2].Text = t.Time.ToString();
                lvs[3].Text = t.Money.ToString();
                lvs[4].Text = t.Load;
                lv.Tag = t;
                listHire.Items.Add(lv);
                lv.SubItems.AddRange(lvs);
                lv.ImageKey = "1.png";
            }
        }
        /// <summary>
        /// 加到还车车(listback)集合然后显示出来
        /// </summary>
        public void addMyRentShow()
        {
            listback.Items.Clear();
            m_RM = new XRentManager();//实例化一个管理类对象
            TrafficBLL showBLL = new TrafficBLL();
            showBLL.showRent(tNew, m_RM);
            foreach (TrafficInfo t in m_RM.DicRenteds.Values)//显示子项
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = t.Number;
                ListViewItem.ListViewSubItem[] lvs;
                lvs = new ListViewItem.ListViewSubItem[7]
                     { 
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem(),
                      new ListViewItem.ListViewSubItem()
                     };
                lvs[0].Text = t.Name;
                lvs[1].Text = t.Color;
                lvs[2].Text = t.Time.ToString();
                lvs[3].Text = t.Money.ToString();
                lvs[4].Text = t.Load;
                lvs[5].Text = t.RentName;
                lvs[6].Text = t.RentDate.ToString();
                lv.Tag = t;
                listback.Items.Add(lv);
                lv.SubItems.AddRange(lvs);
                lv.ImageKey = "1.png";
            }
        }
        //出租
        private void btnHire_Click(object sender, EventArgs e)
        {
            if (listHire.SelectedItems.Count == 0) return;//判断下
            TrafficInfo RentTraffic = listHire.SelectedItems[0].Tag as TrafficInfo;
            RentTraffic.RentName = txtUser.Text;
            RentTraffic.RentDate =Convert.ToDateTime(dateTime.Text);
            RentTraffic.RentNumber = RentTraffic.Number;
            RentTraffic.RentManID = txtRentManID.Text;
            if (txtUser.Text == "")
            { MessageBox.Show("情输入租户姓名"); txtUser.Focus(); return; }
            if (txtRentManID.Text == "")
            { MessageBox.Show("情输入租户证件号码"); txtUser.Focus(); return; }
            TrafficBLL BLL = new TrafficBLL();
            BLL.addRent(RentTraffic);

            MessageBox.Show("出租成功");
            this.tabControl1.SelectedTab = tpReturn;
            addMyRentShow();
            addMyTrafficShow();
        }
        //结算,还车
        private void btnBalance_Click(object sender, EventArgs e)
        {
            TrafficInfo listHire = listback.SelectedItems[0].Tag as TrafficInfo;
            if (listHire !=null)
            {
                listHire.ReturnDate = Convert.ToDateTime(dateTime.Text);
                listHire.RentNumber = listHire.Number;
                TrafficBLL balance = new TrafficBLL();
                balance.addlistHire(listHire);
                MessageBox.Show("已还车");
                this.tabControl1.SelectedTab = tpRent;//转向
                addMyRentShow();
                addMyTrafficShow();
            }   
        }

   
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        #region 视图
        private void MenuLarge_Click(object sender, EventArgs e)
        {
            listHire.View = View.LargeIcon;
            listHire.View = View.LargeIcon;
        }

        private void MenuSmall_Click(object sender, EventArgs e)
        {
            listHire.View = View.SmallIcon;
            listHire.View = View.SmallIcon;
        }

        private void MenuPart_Click(object sender, EventArgs e)
        {
            listHire.View = View.Details;
            listHire.View = View.Details;
        }  
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
          TrafficInfo delete=listHire.SelectedItems[0].Tag as TrafficInfo;
          TrafficBLL dBLL = new TrafficBLL();
          bool res=  dBLL.deleteTraffic(delete);
          if (res)
          {
              MessageBox.Show("删除成功");
              addMyTrafficShow();
          }
          else 
          {
              MessageBox.Show("请选中一项");
          }       
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormAccount Account = new FormAccount();
            Account.ShowDialog();
        }

        private void dateTime_Click(object sender, EventArgs e)
        {

        }
    }
}

