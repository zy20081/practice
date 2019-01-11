namespace Car
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbNew = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTip1 = new System.Windows.Forms.Label();
            this.lblTip2 = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.rdoTruck = new System.Windows.Forms.RadioButton();
            this.rdoCar = new System.Windows.Forms.RadioButton();
            this.tpRent = new System.Windows.Forms.TabPage();
            this.listHire = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHire = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tpReturn = new System.Windows.Forms.TabPage();
            this.listback = new System.Windows.Forms.ListView();
            this.lblTip3 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPart = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbNew.SuspendLayout();
            this.tpRent.SuspendLayout();
            this.tpReturn.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbNew);
            this.tabControl1.Controls.Add(this.tpRent);
            this.tabControl1.Controls.Add(this.tpReturn);
            this.tabControl1.Location = new System.Drawing.Point(11, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tbNew
            // 
            this.tbNew.Controls.Add(this.label2);
            this.tbNew.Controls.Add(this.label1);
            this.tbNew.Controls.Add(this.txtMoney);
            this.tbNew.Controls.Add(this.txtTime);
            this.tbNew.Controls.Add(this.cbColor);
            this.tbNew.Controls.Add(this.txtLoad);
            this.tbNew.Controls.Add(this.btnCancel);
            this.tbNew.Controls.Add(this.lblTip1);
            this.tbNew.Controls.Add(this.lblTip2);
            this.tbNew.Controls.Add(this.lbWeight);
            this.tbNew.Controls.Add(this.btnAdd);
            this.tbNew.Controls.Add(this.txtName);
            this.tbNew.Controls.Add(this.txtNumber);
            this.tbNew.Controls.Add(this.lblLoad);
            this.tbNew.Controls.Add(this.lblMoney);
            this.tbNew.Controls.Add(this.lblTime);
            this.tbNew.Controls.Add(this.lblColor);
            this.tbNew.Controls.Add(this.lblName);
            this.tbNew.Controls.Add(this.lblNumber);
            this.tbNew.Controls.Add(this.rdoTruck);
            this.tbNew.Controls.Add(this.rdoCar);
            this.tbNew.Location = new System.Drawing.Point(4, 22);
            this.tbNew.Name = "tbNew";
            this.tbNew.Padding = new System.Windows.Forms.Padding(3);
            this.tbNew.Size = new System.Drawing.Size(638, 345);
            this.tbNew.TabIndex = 2;
            this.tbNew.Text = "新车入库";
            this.tbNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "年";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "元";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(232, 220);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(134, 21);
            this.txtMoney.TabIndex = 44;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(232, 194);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(134, 21);
            this.txtTime.TabIndex = 43;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "红色",
            "白色",
            "绿色",
            "蓝色",
            "青色",
            "黑色",
            "橙色",
            "紫色"});
            this.cbColor.Location = new System.Drawing.Point(232, 166);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(134, 20);
            this.cbColor.TabIndex = 41;
            this.cbColor.Text = "黑色";
            // 
            // txtLoad
            // 
            this.txtLoad.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLoad.Location = new System.Drawing.Point(232, 245);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.ReadOnly = true;
            this.txtLoad.Size = new System.Drawing.Size(134, 21);
            this.txtLoad.TabIndex = 40;
            this.txtLoad.Text = "--无--";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTip1
            // 
            this.lblTip1.AutoSize = true;
            this.lblTip1.Location = new System.Drawing.Point(414, 219);
            this.lblTip1.Name = "lblTip1";
            this.lblTip1.Size = new System.Drawing.Size(77, 12);
            this.lblTip1.TabIndex = 37;
            this.lblTip1.Text = "(请输入数字)";
            // 
            // lblTip2
            // 
            this.lblTip2.AutoSize = true;
            this.lblTip2.Location = new System.Drawing.Point(414, 248);
            this.lblTip2.Name = "lblTip2";
            this.lblTip2.Size = new System.Drawing.Size(77, 12);
            this.lblTip2.TabIndex = 38;
            this.lblTip2.Text = "(请输入数字)";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(374, 247);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(17, 12);
            this.lbWeight.TabIndex = 25;
            this.lbWeight.Text = "吨";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "入库";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 21);
            this.txtName.TabIndex = 23;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(232, 113);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(134, 21);
            this.txtNumber.TabIndex = 22;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(183, 247);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(29, 12);
            this.lblLoad.TabIndex = 35;
            this.lblLoad.Text = "载重";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(153, 219);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(53, 12);
            this.lblMoney.TabIndex = 34;
            this.lblMoney.Text = "每日租金";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(159, 194);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "使用时间";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(183, 169);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(29, 12);
            this.lblColor.TabIndex = 32;
            this.lblColor.Text = "颜色";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(183, 144);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "车名";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(159, 116);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(59, 12);
            this.lblNumber.TabIndex = 30;
            this.lblNumber.Text = " 车牌号码";
            // 
            // rdoTruck
            // 
            this.rdoTruck.AutoSize = true;
            this.rdoTruck.Location = new System.Drawing.Point(308, 71);
            this.rdoTruck.Name = "rdoTruck";
            this.rdoTruck.Size = new System.Drawing.Size(47, 16);
            this.rdoTruck.TabIndex = 21;
            this.rdoTruck.Text = "卡车";
            this.rdoTruck.UseVisualStyleBackColor = true;
            // 
            // rdoCar
            // 
            this.rdoCar.AutoSize = true;
            this.rdoCar.Checked = true;
            this.rdoCar.Location = new System.Drawing.Point(195, 71);
            this.rdoCar.Name = "rdoCar";
            this.rdoCar.Size = new System.Drawing.Size(47, 16);
            this.rdoCar.TabIndex = 20;
            this.rdoCar.TabStop = true;
            this.rdoCar.Text = "轿车";
            this.rdoCar.UseVisualStyleBackColor = true;
            this.rdoCar.CheckedChanged += new System.EventHandler(this.rdoCar_CheckedChanged);
            // 
            // tpRent
            // 
            this.tpRent.Controls.Add(this.listHire);
            this.tpRent.Controls.Add(this.btnDelete);
            this.tpRent.Controls.Add(this.btnHire);
            this.tpRent.Controls.Add(this.txtUser);
            this.tpRent.Controls.Add(this.lblUser);
            this.tpRent.Location = new System.Drawing.Point(4, 22);
            this.tpRent.Name = "tpRent";
            this.tpRent.Padding = new System.Windows.Forms.Padding(3);
            this.tpRent.Size = new System.Drawing.Size(638, 345);
            this.tpRent.TabIndex = 0;
            this.tpRent.Text = "租车";
            this.tpRent.UseVisualStyleBackColor = true;
            // 
            // listHire
            // 
            this.listHire.FullRowSelect = true;
            this.listHire.GridLines = true;
            this.listHire.HideSelection = false;
            this.listHire.LargeImageList = this.imageList1;
            this.listHire.Location = new System.Drawing.Point(0, 0);
            this.listHire.Name = "listHire";
            this.listHire.Size = new System.Drawing.Size(638, 316);
            this.listHire.SmallImageList = this.imageList2;
            this.listHire.TabIndex = 14;
            this.listHire.UseCompatibleStateImageBehavior = false;
            this.listHire.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "1.png");
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(460, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(553, 320);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(75, 23);
            this.btnHire.TabIndex = 5;
            this.btnHire.Text = "出租";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(311, 322);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(265, 325);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 12);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "姓名";
            // 
            // tpReturn
            // 
            this.tpReturn.Controls.Add(this.listback);
            this.tpReturn.Controls.Add(this.lblTip3);
            this.tpReturn.Controls.Add(this.txtDays);
            this.tpReturn.Controls.Add(this.lblDays);
            this.tpReturn.Controls.Add(this.btnBalance);
            this.tpReturn.Location = new System.Drawing.Point(4, 22);
            this.tpReturn.Name = "tpReturn";
            this.tpReturn.Padding = new System.Windows.Forms.Padding(3);
            this.tpReturn.Size = new System.Drawing.Size(638, 345);
            this.tpReturn.TabIndex = 1;
            this.tpReturn.Text = "还车";
            this.tpReturn.UseVisualStyleBackColor = true;
            // 
            // listback
            // 
            this.listback.FullRowSelect = true;
            this.listback.GridLines = true;
            this.listback.HideSelection = false;
            this.listback.LargeImageList = this.imageList1;
            this.listback.Location = new System.Drawing.Point(0, 0);
            this.listback.Name = "listback";
            this.listback.Size = new System.Drawing.Size(638, 316);
            this.listback.SmallImageList = this.imageList2;
            this.listback.TabIndex = 15;
            this.listback.UseCompatibleStateImageBehavior = false;
            this.listback.View = System.Windows.Forms.View.Details;
            // 
            // lblTip3
            // 
            this.lblTip3.AutoSize = true;
            this.lblTip3.Location = new System.Drawing.Point(409, 327);
            this.lblTip3.Name = "lblTip3";
            this.lblTip3.Size = new System.Drawing.Size(77, 12);
            this.lblTip3.TabIndex = 9;
            this.lblTip3.Text = "(请输入数字)";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(302, 323);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 21);
            this.txtDays.TabIndex = 8;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(240, 326);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(53, 12);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "租用天数";
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(535, 321);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(75, 23);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "结算";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(569, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(186, 20);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(297, 39);
            this.labTitle.TabIndex = 13;
            this.labTitle.Text = "汽车租借管理系统";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(681, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLarge,
            this.MenuSmall,
            this.MenuPart});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(50, 21);
            this.MenuItem.Text = "视图&F";
            // 
            // MenuLarge
            // 
            this.MenuLarge.Name = "MenuLarge";
            this.MenuLarge.Size = new System.Drawing.Size(119, 22);
            this.MenuLarge.Text = "大图标&T";
            this.MenuLarge.Click += new System.EventHandler(this.MenuLarge_Click);
            // 
            // MenuSmall
            // 
            this.MenuSmall.Name = "MenuSmall";
            this.MenuSmall.Size = new System.Drawing.Size(119, 22);
            this.MenuSmall.Text = "小图标&Z";
            this.MenuSmall.Click += new System.EventHandler(this.MenuSmall_Click);
            // 
            // MenuPart
            // 
            this.MenuPart.Name = "MenuPart";
            this.MenuPart.Size = new System.Drawing.Size(119, 22);
            this.MenuPart.Text = "详细&C";
            this.MenuPart.Click += new System.EventHandler(this.MenuPart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(560, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "z--y制作";
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTime.Location = new System.Drawing.Point(561, 78);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(56, 16);
            this.dateTime.TabIndex = 17;
            this.dateTime.Text = "label4";
            this.dateTime.Click += new System.EventHandler(this.dateTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(483, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "月  份：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbNew.ResumeLayout(false);
            this.tbNew.PerformLayout();
            this.tpRent.ResumeLayout(false);
            this.tpRent.PerformLayout();
            this.tpReturn.ResumeLayout(false);
            this.tpReturn.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRent;
        private System.Windows.Forms.TabPage tpReturn;
        private System.Windows.Forms.TabPage tbNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTip1;
        private System.Windows.Forms.Label lblTip2;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.RadioButton rdoTruck;
        private System.Windows.Forms.RadioButton rdoCar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTip3;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.ListView listHire;
        private System.Windows.Forms.ListView listback;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuLarge;
        private System.Windows.Forms.ToolStripMenuItem MenuSmall;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripMenuItem MenuPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Label label4;
    }
}

