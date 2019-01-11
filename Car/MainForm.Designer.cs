namespace Car
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.系统用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAddusers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIalterUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIshow = new System.Windows.Forms.ToolStripMenuItem();
            this.日常业务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆预订ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIrent = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIaccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.合同信息浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.合同信息修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户会员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(686, 465);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(686, 490);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 440);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统用户管理ToolStripMenuItem,
            this.日常业务管理ToolStripMenuItem,
            this.车辆信息管理ToolStripMenuItem,
            this.客户会员管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(686, 25);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // 系统用户管理ToolStripMenuItem
            // 
            this.系统用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAddusers,
            this.TSMIalterUsers,
            this.TSMIshow});
            this.系统用户管理ToolStripMenuItem.Name = "系统用户管理ToolStripMenuItem";
            this.系统用户管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.系统用户管理ToolStripMenuItem.Text = "系统用户管理";
            // 
            // TSMIAddusers
            // 
            this.TSMIAddusers.Name = "TSMIAddusers";
            this.TSMIAddusers.Size = new System.Drawing.Size(148, 22);
            this.TSMIAddusers.Text = "添加用户";
            this.TSMIAddusers.Click += new System.EventHandler(this.TSMIAddusers_Click);
            // 
            // TSMIalterUsers
            // 
            this.TSMIalterUsers.Name = "TSMIalterUsers";
            this.TSMIalterUsers.Size = new System.Drawing.Size(148, 22);
            this.TSMIalterUsers.Text = "修改密码";
            this.TSMIalterUsers.Click += new System.EventHandler(this.TSMIalterUsers_Click);
            // 
            // TSMIshow
            // 
            this.TSMIshow.Name = "TSMIshow";
            this.TSMIshow.Size = new System.Drawing.Size(148, 22);
            this.TSMIshow.Text = "浏览所有用户";
            this.TSMIshow.Click += new System.EventHandler(this.TSMIshow_Click);
            // 
            // 日常业务管理ToolStripMenuItem
            // 
            this.日常业务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆预订ToolStripMenuItem,
            this.TSMIrent,
            this.TSMIaccounts,
            this.toolStripSeparator1,
            this.合同信息浏览ToolStripMenuItem,
            this.合同信息修改ToolStripMenuItem});
            this.日常业务管理ToolStripMenuItem.Name = "日常业务管理ToolStripMenuItem";
            this.日常业务管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.日常业务管理ToolStripMenuItem.Text = "日常业务管理";
            // 
            // 车辆预订ToolStripMenuItem
            // 
            this.车辆预订ToolStripMenuItem.Name = "车辆预订ToolStripMenuItem";
            this.车辆预订ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.车辆预订ToolStripMenuItem.Text = "车辆预订";
            // 
            // TSMIrent
            // 
            this.TSMIrent.Name = "TSMIrent";
            this.TSMIrent.Size = new System.Drawing.Size(148, 22);
            this.TSMIrent.Text = "汽车租赁";
            this.TSMIrent.Click += new System.EventHandler(this.TSMIrent_Click);
            // 
            // TSMIaccounts
            // 
            this.TSMIaccounts.Name = "TSMIaccounts";
            this.TSMIaccounts.Size = new System.Drawing.Size(148, 22);
            this.TSMIaccounts.Text = "归还结账";
            this.TSMIaccounts.Click += new System.EventHandler(this.TSMIaccounts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 合同信息浏览ToolStripMenuItem
            // 
            this.合同信息浏览ToolStripMenuItem.Name = "合同信息浏览ToolStripMenuItem";
            this.合同信息浏览ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.合同信息浏览ToolStripMenuItem.Text = "合同信息浏览";
            // 
            // 合同信息修改ToolStripMenuItem
            // 
            this.合同信息修改ToolStripMenuItem.Name = "合同信息修改ToolStripMenuItem";
            this.合同信息修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.合同信息修改ToolStripMenuItem.Text = "合同信息修改";
            // 
            // 车辆信息管理ToolStripMenuItem
            // 
            this.车辆信息管理ToolStripMenuItem.Name = "车辆信息管理ToolStripMenuItem";
            this.车辆信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.车辆信息管理ToolStripMenuItem.Text = "车辆信息管理";
            // 
            // 客户会员管理ToolStripMenuItem
            // 
            this.客户会员管理ToolStripMenuItem.Name = "客户会员管理ToolStripMenuItem";
            this.客户会员管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.客户会员管理ToolStripMenuItem.Text = "客户会员管理";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助文件ToolStripMenuItem,
            this.toolStripSeparator2,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助文件ToolStripMenuItem
            // 
            this.帮助文件ToolStripMenuItem.Name = "帮助文件ToolStripMenuItem";
            this.帮助文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助文件ToolStripMenuItem.Text = "帮助文件";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 490);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem 系统用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIAddusers;
        private System.Windows.Forms.ToolStripMenuItem TSMIalterUsers;
        private System.Windows.Forms.ToolStripMenuItem TSMIshow;
        private System.Windows.Forms.ToolStripMenuItem 日常业务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆预订ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIrent;
        private System.Windows.Forms.ToolStripMenuItem TSMIaccounts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 合同信息浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 合同信息修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户会员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}