namespace Car
{
    partial class FormAccount
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
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbomonth = new System.Windows.Forms.ComboBox();
            this.lblcate = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.lblkey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboyear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboReslutmonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboReslutyear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.labreslut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(12, 45);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(610, 301);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(552, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(69, 21);
            this.btnAll.TabIndex = 10;
            this.btnAll.Text = "显示全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(468, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 21);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "搜 索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbomonth
            // 
            this.cbomonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomonth.FormattingEnabled = true;
            this.cbomonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbomonth.Location = new System.Drawing.Point(256, 19);
            this.cbomonth.Name = "cbomonth";
            this.cbomonth.Size = new System.Drawing.Size(62, 20);
            this.cbomonth.TabIndex = 9;
            // 
            // lblcate
            // 
            this.lblcate.AutoSize = true;
            this.lblcate.Location = new System.Drawing.Point(209, 22);
            this.lblcate.Name = "lblcate";
            this.lblcate.Size = new System.Drawing.Size(41, 12);
            this.lblcate.TabIndex = 8;
            this.lblcate.Text = "月 份:";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(82, 19);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(100, 21);
            this.txtkey.TabIndex = 7;
            // 
            // lblkey
            // 
            this.lblkey.AutoSize = true;
            this.lblkey.Location = new System.Drawing.Point(23, 22);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(53, 12);
            this.lblkey.TabIndex = 6;
            this.lblkey.Text = "关键字：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "年 份:";
            // 
            // cboyear
            // 
            this.cboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboyear.FormattingEnabled = true;
            this.cboyear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cboyear.Location = new System.Drawing.Point(380, 19);
            this.cboyear.Name = "cboyear";
            this.cboyear.Size = new System.Drawing.Size(62, 20);
            this.cboyear.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "计算：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-193, 702);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "计算：";
            // 
            // cboReslutmonth
            // 
            this.cboReslutmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReslutmonth.FormattingEnabled = true;
            this.cboReslutmonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboReslutmonth.Location = new System.Drawing.Point(51, 358);
            this.cboReslutmonth.Name = "cboReslutmonth";
            this.cboReslutmonth.Size = new System.Drawing.Size(62, 20);
            this.cboReslutmonth.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "月份";
            // 
            // cboReslutyear
            // 
            this.cboReslutyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReslutyear.FormattingEnabled = true;
            this.cboReslutyear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cboReslutyear.Location = new System.Drawing.Point(154, 360);
            this.cboReslutyear.Name = "cboReslutyear";
            this.cboReslutyear.Size = new System.Drawing.Size(62, 20);
            this.cboReslutyear.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "年 份";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "总计：";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(324, 363);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 15;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(389, 360);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 16;
            this.btnCount.Text = "计算";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labreslut
            // 
            this.labreslut.AutoSize = true;
            this.labreslut.Location = new System.Drawing.Point(324, 363);
            this.labreslut.Name = "labreslut";
            this.labreslut.Size = new System.Drawing.Size(41, 12);
            this.labreslut.TabIndex = 14;
            this.labreslut.Text = "总计：";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 405);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.result);
            this.Controls.Add(this.labreslut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboReslutyear);
            this.Controls.Add(this.cboyear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboReslutmonth);
            this.Controls.Add(this.cbomonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcate);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.lblkey);
            this.Controls.Add(this.dgvInfo);
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbomonth;
        private System.Windows.Forms.Label lblcate;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Label lblkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboReslutmonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboReslutyear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label labreslut;
    }
}