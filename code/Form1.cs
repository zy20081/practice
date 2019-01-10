using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void btnConnect_Click(object sender, EventArgs e)//加入到checklistBox
        {
            model.constr = txtConnstr.Text;
            CreateDaL DAL = new CreateDaL(); 
            DataTable dt =DAL.ExecuteDataTable("SELECT * FROM  INFORMATION_SCHEMA.TABLES");
            foreach (DataRow row in dt.Rows) 
            {
                string tablename = row["TABLE_NAME"].ToString();
                clbTables.Items.Add(tablename);
            }
        }
        
        private void btnLeading_Click(object sender, EventArgs e) //弹出窗口
        {
            folderBrowse = new FolderBrowserDialog();
            if (folderBrowse.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = folderBrowse.SelectedPath;
                model.FilePath=txtFilePath.Text;
            }
           
        }

        private void btnSpaceCreate_Click(object sender, EventArgs e)//生成
        {
            model.RootNamespace = txtNameSpace.Text;//命名空间
            if (checkDAL.Checked || checkModel.Checked || checkBLL.Checked)
            {
                if (checkDAL.Checked)
                {
                    foreach (string tablename in clbTables.CheckedItems)
                    {
                        CreateDaL DAL = new CreateDaL();
                        StringBuilder sb = DAL.creatDAL(tablename);
                        model.BuilderDAL = sb.ToString();
                        Directory.CreateDirectory(model.FilePath + "\\DAL");//创建目录
                        File.WriteAllText(model.FilePath + "\\DAL" + "\\" + tablename + "_DAL.cs", model.BuilderDAL);
                    }

                }
                if (checkModel.Checked)
                {
                    foreach (string tablename in clbTables.CheckedItems)
                    {
                        CreateDaL DAL = new CreateDaL();
                        StringBuilder sb = DAL.createModel(tablename);
                        model.BuilderModel = sb.ToString();
                        Directory.CreateDirectory(model.FilePath + "\\model");//创建目录
                        File.WriteAllText(model.FilePath + "\\model" + "\\" + tablename + "_model.cs", model.BuilderModel);
                    }

                }
                if (checkBLL.Checked)
                {
                    foreach (string tablename in clbTables.CheckedItems)
                    {
                        CreateDaL DAL = new CreateDaL();
                        StringBuilder sb = DAL.creatBLL(tablename);
                        model.BuilderBLL = sb.ToString();
                        Directory.CreateDirectory(model.FilePath + "\\BLL");
                        File.WriteAllText(model.FilePath + "\\BLL" + "\\" + tablename + "_BLL.cs", model.BuilderBLL);
                    }
                }
                textBox1.Text += "\r\n生成成功 " + txtFilePath.Text + " 目录中查看..!";
            }
            else 
            {
                textBox1.Text += "\r\n你没选择任何一项，亲,没东东生成哦！ ";
            }
            
        }
    }
}
