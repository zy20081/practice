namespace picphoto
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
            this.picphoto = new System.Windows.Forms.PictureBox();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolSOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.停止自动换片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picphoto
            // 
            this.picphoto.BackColor = System.Drawing.SystemColors.Control;
            this.picphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picphoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picphoto.ContextMenuStrip = this.contextMenu;
            this.picphoto.Image = ((System.Drawing.Image)(resources.GetObject("picphoto.Image")));
            this.picphoto.Location = new System.Drawing.Point(32, 12);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(475, 314);
            this.picphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picphoto.TabIndex = 0;
            this.picphoto.TabStop = false;
            this.picphoto.Click += new System.EventHandler(this.picphoto_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnfirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnfirst.Location = new System.Drawing.Point(35, 351);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnfirst.Size = new System.Drawing.Size(49, 23);
            this.btnfirst.TabIndex = 1;
            this.btnfirst.Text = "首页";
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btngo
            // 
            this.btngo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btngo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btngo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btngo.Location = new System.Drawing.Point(94, 351);
            this.btngo.Name = "btngo";
            this.btngo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btngo.Size = new System.Drawing.Size(49, 23);
            this.btngo.TabIndex = 1;
            this.btngo.Text = "上一张";
            this.btngo.UseVisualStyleBackColor = false;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btndown
            // 
            this.btndown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndown.Location = new System.Drawing.Point(153, 351);
            this.btndown.Name = "btndown";
            this.btndown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndown.Size = new System.Drawing.Size(49, 23);
            this.btndown.TabIndex = 1;
            this.btndown.Text = "下一张";
            this.btndown.UseVisualStyleBackColor = false;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlast.Location = new System.Drawing.Point(214, 351);
            this.btnlast.Name = "btnlast";
            this.btnlast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnlast.Size = new System.Drawing.Size(49, 23);
            this.btnlast.TabIndex = 1;
            this.btnlast.Text = "末尾";
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(173, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(238, 380);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(303, 380);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(368, 380);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(433, 380);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(59, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(303, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "z---  制  作  ---y";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSOpen,
            this.停止自动换片ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(149, 48);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // ToolSOpen
            // 
            this.ToolSOpen.Name = "ToolSOpen";
            this.ToolSOpen.Size = new System.Drawing.Size(152, 22);
            this.ToolSOpen.Text = "开启自动换片";
            this.ToolSOpen.Click += new System.EventHandler(this.ToolSOpen_Click);
            // 
            // 停止自动换片ToolStripMenuItem
            // 
            this.停止自动换片ToolStripMenuItem.Name = "停止自动换片ToolStripMenuItem";
            this.停止自动换片ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.停止自动换片ToolStripMenuItem.Text = "停止自动换片";
            this.停止自动换片ToolStripMenuItem.Click += new System.EventHandler(this.停止自动换片ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(531, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.picphoto);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "z-yPhoto";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picphoto;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolSOpen;
        private System.Windows.Forms.ToolStripMenuItem 停止自动换片ToolStripMenuItem;
    }
}

