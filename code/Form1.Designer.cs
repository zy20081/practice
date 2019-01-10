namespace code
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnstr = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSpaceCreate = new System.Windows.Forms.Button();
            this.btnLeading = new System.Windows.Forms.Button();
            this.folderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBLL = new System.Windows.Forms.CheckBox();
            this.checkDAL = new System.Windows.Forms.CheckBox();
            this.checkModel = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接字符串：";
            // 
            // txtConnstr
            // 
            this.txtConnstr.Location = new System.Drawing.Point(111, 24);
            this.txtConnstr.Name = "txtConnstr";
            this.txtConnstr.Size = new System.Drawing.Size(355, 21);
            this.txtConnstr.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(472, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // clbTables
            // 
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(17, 20);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(126, 276);
            this.clbTables.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "输出路劲：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "命名空间：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(252, 95);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(204, 21);
            this.txtFilePath.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(6, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(360, 134);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "欢迎光临Z-Y代码生成器";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSpaceCreate
            // 
            this.btnSpaceCreate.Location = new System.Drawing.Point(472, 124);
            this.btnSpaceCreate.Name = "btnSpaceCreate";
            this.btnSpaceCreate.Size = new System.Drawing.Size(75, 23);
            this.btnSpaceCreate.TabIndex = 4;
            this.btnSpaceCreate.Text = "生成";
            this.btnSpaceCreate.UseVisualStyleBackColor = true;
            this.btnSpaceCreate.Click += new System.EventHandler(this.btnSpaceCreate_Click);
            // 
            // btnLeading
            // 
            this.btnLeading.Location = new System.Drawing.Point(472, 93);
            this.btnLeading.Name = "btnLeading";
            this.btnLeading.Size = new System.Drawing.Size(75, 23);
            this.btnLeading.TabIndex = 4;
            this.btnLeading.Text = "浏览";
            this.btnLeading.UseVisualStyleBackColor = true;
            this.btnLeading.Click += new System.EventHandler(this.btnLeading_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.checkBLL);
            this.groupBox1.Controls.Add(this.checkDAL);
            this.groupBox1.Controls.Add(this.checkModel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(172, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 188);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态信息";
            // 
            // checkBLL
            // 
            this.checkBLL.AutoSize = true;
            this.checkBLL.Location = new System.Drawing.Point(127, 20);
            this.checkBLL.Name = "checkBLL";
            this.checkBLL.Size = new System.Drawing.Size(42, 16);
            this.checkBLL.TabIndex = 9;
            this.checkBLL.Text = "BLL";
            this.checkBLL.UseVisualStyleBackColor = true;
            // 
            // checkDAL
            // 
            this.checkDAL.AutoSize = true;
            this.checkDAL.Location = new System.Drawing.Point(69, 20);
            this.checkDAL.Name = "checkDAL";
            this.checkDAL.Size = new System.Drawing.Size(42, 16);
            this.checkDAL.TabIndex = 9;
            this.checkDAL.Text = "DAL";
            this.checkDAL.UseVisualStyleBackColor = true;
            // 
            // checkModel
            // 
            this.checkModel.AutoSize = true;
            this.checkModel.Location = new System.Drawing.Point(7, 20);
            this.checkModel.Name = "checkModel";
            this.checkModel.Size = new System.Drawing.Size(54, 16);
            this.checkModel.TabIndex = 9;
            this.checkModel.Text = "Model";
            this.checkModel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.clbTables);
            this.groupBox2.Location = new System.Drawing.Point(13, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 302);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tables";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Location = new System.Drawing.Point(172, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "路径/命名空间";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(252, 127);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(204, 21);
            this.txtNameSpace.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.Location = new System.Drawing.Point(12, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 49);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据库信息";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 370);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLeading);
            this.Controls.Add(this.btnSpaceCreate);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtConnstr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码生成器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnstr;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSpaceCreate;
        private System.Windows.Forms.Button btnLeading;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBLL;
        private System.Windows.Forms.CheckBox checkDAL;
        private System.Windows.Forms.CheckBox checkModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

