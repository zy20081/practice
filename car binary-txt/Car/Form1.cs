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
namespace Car
{
    public partial class Form1 : Form
    {
      
        TrafficInfo tNew;//父类
        XRentManager m_RM = new XRentManager();//实例化一个管理类对象
   
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

            if (rdoCar.Checked == true)
            {
                tNew = new Xcar();//创立对象
            }
            if (rdoTruck.Checked == true)
            {
                tNew = new XTruck();


            }
            tNew.Number = txtNumber.Text;//车牌号码
            tNew.Name = txtName.Text;//车名
            tNew.Color = cbColor.Text;//车颜色
            tNew.Time = txtTime.Text;//使用时间
            tNew.Money = int.Parse(txtMoney.Text);//租金
            tNew.Load = txtLoad.Text;//载重
         
            try
            {
                m_RM.InputLibry(tNew);//可以出租的车集合
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                txtNumber.Text = "";
                txtNumber.Focus();
                return;
            }
            addTraffic();
            this.tabControl1.SelectedTab = tpRent;
            MessageBox.Show("添加成功");

        }
        /// <summary>
        /// 刷新租车集合
        /// </summary>
        public void addTraffic()
        {
            
            listHire.Items.Clear();
            foreach (TrafficInfo t in m_RM.DicMyTraffics.Values)
            {
                ListViewItem lv = new ListViewItem();//显示项
                lv.Text = t.Number;
                ListViewItem.ListViewSubItem[] lvs;
                lvs = new ListViewItem.ListViewSubItem[5]//显示子项
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

                listHire.Items.Add(lv);
                lv.SubItems.AddRange(lvs);
                lv.Tag = t;
                lv.ImageKey = "1.png";
               
            }
        }

        /// <summary>
        /// 刷新还车集合
        /// </summary>
        public void backTraffic()
        {

            listback.Items.Clear();
            foreach (TrafficInfo t in m_RM.DicRenteds.Values)
            {
                ListViewItem lv = new ListViewItem();//显示项
                lv.Text = t.Number;
                ListViewItem.ListViewSubItem[] lvs;
                lvs = new ListViewItem.ListViewSubItem[7]//显示子项
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
                lvs[5].Text = t.tenement;
                lvs[6].Text = dateTime.Text;
                lv.SubItems.AddRange(lvs);
                listback.Items.Add(lv);
                lv.Tag = t;
                lv.ImageKey = "1.png";
            }
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
            dateTime.Text = DateTime.Now.ToString("yyyy/MM/dd");
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

            #region 反序列化
            FileStream fs = new FileStream("Students.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            if (fs.Length > 0)
            {
                m_RM = bf.Deserialize(fs) as XRentManager;//反序列化
            }
            bf = null;
            fs.Close();
            fs.Dispose(); 
            #endregion
            backTraffic();//还车
            addTraffic();//租车

        }
  
        //出租
        private void btnHire_Click(object sender, EventArgs e)
        {
        
            
            if (listHire.SelectedItems.Count == 0) return;//判断下
            TrafficInfo listback = listHire.SelectedItems[0].Tag as TrafficInfo;
            listback.tenement = txtUser.Text;
            listback.datatime = dateTime.Text;
            if (txtUser.Text == "")
            { MessageBox.Show("情输入租户姓名"); txtUser.Focus(); return; }
            m_RM.Rent(listback);
            MessageBox.Show("出租成功");
            this.tabControl1.SelectedTab = tpReturn;
            backTraffic();//还车
            addTraffic();//租车
        }
        //金额简单结算
        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (txtDays.Text == "")
            { MessageBox.Show("情输入租用时间"); txtDays.Focus(); return; }
            TrafficInfo list = listback.SelectedItems[0].Tag as TrafficInfo;
            int days = int.Parse(txtDays.Text);
            double prise = list.Money;
            double total = days * prise;
            MessageBox.Show("总计费用"+total);
            TrafficInfo listHire = listback.SelectedItems[0].Tag as TrafficInfo;
            m_RM.InputLibry(listHire);//
            MessageBox.Show("已还车");
            this.tabControl1.SelectedTab = tpRent;//转向
            backTraffic();//还车
            addTraffic();//租车

        }

        /// <summary>
        /// 序列化存进2进制流
        /// </summary>
        /// <param name="fileName">路径</param>
        private void LoadDate(string fileName)
        {
            #region 序列化
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();//创建序列化
            bf.Serialize(fs, m_RM);//保存
            bf = null;
            fs.Close();
            fs.Dispose(); 
            #endregion
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.LoadDate("Students.bin");
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
            //TrafficInfo delect = listHire.SelectedItems[0].Tag as TrafficInfo;
            //m_RM.DicMyTraffics.Remove(delect.Name);
            int count = listHire.SelectedItems.Count;
            string key = "";
            for (int i = 0; i < count; i++)
            {
                key = listHire.SelectedItems[i].Text;
                if (m_RM.DicMyTraffics.ContainsKey(key))
                {
                    m_RM.DicMyTraffics.Remove(key);
                }

            }
            MessageBox.Show("删除成功");
            addTraffic();//租车
        }

        private void dateTime_Click(object sender, EventArgs e)
        {

        }
    }
}

