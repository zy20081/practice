namespace Car.Forms
{
    partial class alteruser
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUserPwd2 = new System.Windows.Forms.TextBox();
            this.txtUserPwd1 = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 131);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 81;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(128, 53);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(100, 21);
            this.txtUserPwd.TabIndex = 80;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(43, 64);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 79;
            this.Label4.Text = "原密码";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(43, 136);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 23);
            this.Label3.TabIndex = 78;
            this.Label3.Text = "密码确认";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(43, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 23);
            this.Label2.TabIndex = 77;
            this.Label2.Text = "请输入密码";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(43, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 23);
            this.Label1.TabIndex = 76;
            this.Label1.Text = "用户名";
            // 
            // txtUserPwd2
            // 
            this.txtUserPwd2.Location = new System.Drawing.Point(128, 133);
            this.txtUserPwd2.Name = "txtUserPwd2";
            this.txtUserPwd2.PasswordChar = '*';
            this.txtUserPwd2.Size = new System.Drawing.Size(100, 21);
            this.txtUserPwd2.TabIndex = 75;
            // 
            // txtUserPwd1
            // 
            this.txtUserPwd1.Location = new System.Drawing.Point(128, 93);
            this.txtUserPwd1.Name = "txtUserPwd1";
            this.txtUserPwd1.PasswordChar = '*';
            this.txtUserPwd1.Size = new System.Drawing.Size(100, 21);
            this.txtUserPwd1.TabIndex = 74;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(128, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 73;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(244, 91);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 72;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(128, 160);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 20);
            this.cboSex.TabIndex = 83;
            this.cboSex.Text = "男";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 82;
            this.label5.Text = "性别：";
            // 
            // alteruser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 210);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUserPwd2);
            this.Controls.Add(this.txtUserPwd1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnModify);
            this.Name = "alteruser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alteruser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.TextBox txtUserPwd;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUserPwd2;
        internal System.Windows.Forms.TextBox txtUserPwd1;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label label5;
    }
}