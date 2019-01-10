using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace MusicTV
{
    public partial class Form1 : Form
    {
        PlayManager m_MP = new PlayManager();
       
        public Form1()
        {
           
            InitializeComponent();
        }
        SongInfo Songs;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Songs = new SongInfo();
            openFile.FileName = "";
            openFile.ShowDialog();
            Songs.FilePath = openFile.FileName;
            Songs.name = Path.GetFileName(Songs.FilePath);//Path方法，，存入名字
          
            if (m_MP.PlaySong.ContainsKey(Songs.FilePath))
            {
                MessageBox.Show("已经添加了");
                return;
            }
            m_MP.PlaySong.Add(Songs.FilePath, Songs);
            TreeNode n = null;
            rootNode.Nodes.Clear();
            foreach (SongInfo s in m_MP.PlaySong.Values)
            {  
                n = new TreeNode();
                n.Text = s.name;
                n.Tag = s;
                rootNode.Nodes.Add(n);
            }
            rootNode.Expand();
        }
        TreeNode rootNode = null;//树的根点
        private void Form1_Load(object sender, EventArgs e)
        {
            rootNode = new TreeNode();
            rootNode.Text = "默认列表";
            tvMenu.Nodes.Add(rootNode);
            //FileStream file = new FileStream("12.dat", FileMode.OpenOrCreate);
            FileStream file = File.OpenRead("12.dat");///反序列化
            if (file.Length > 0)
            {
                BinaryFormatter fs = new BinaryFormatter();
                m_MP = fs.Deserialize(file) as PlayManager; 
            }
            file.Close(); file.Dispose();
            TreeNode n = null;
            foreach (SongInfo s in m_MP.PlaySong.Values) 
            {
                n = new TreeNode();
                n.Text = s.name;
                n.Tag = s;
                rootNode.Nodes.Add(n);
            }
            rootNode.Expand();
        }
        
      
        /// <summary>
        /// 改变宽度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.media.Width = groupBox1.Width-10;
            this.media.Height = groupBox1.Height-30;
        }

        //双击时播放歌曲
        private void tvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (tvMenu.SelectedNode.Tag != null)
            {
                SongInfo sSel = tvMenu.SelectedNode.Tag as SongInfo;
                media.URL = sSel.FilePath;
            }
            try
            {
                Songs = tvMenu.SelectedNode.Tag as SongInfo;
                string lyricpath = @"lyric\" + Songs.name + ".txt";
                Songs.lyrics = File.ReadAllText(lyricpath, Encoding.Default);//选择时显示歌词
            }
            catch{}

            if (e.Node.Tag == null)
            {
                return;
            }
            tblyric.Text = ((e.Node.Tag) as SongInfo).lyrics;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {///序列化
            //FileStream file = new FileStream("12.dat", FileMode.Create);
            //BinaryFormatter fs = new BinaryFormatter();
            //fs.Serialize(file, m_MP);
            //file.Close(); file.Dispose();

            using(Stream filestream=File.OpenWrite("12.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(filestream, m_MP);
            }

        }

    }
}
