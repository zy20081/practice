namespace 计算器
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
            this.lblwindows = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEXE = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnfu = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnCountdown = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblwindows
            // 
            this.lblwindows.BackColor = System.Drawing.Color.White;
            this.lblwindows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblwindows.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblwindows.ForeColor = System.Drawing.Color.Black;
            this.lblwindows.Location = new System.Drawing.Point(18, 34);
            this.lblwindows.Name = "lblwindows";
            this.lblwindows.Size = new System.Drawing.Size(280, 42);
            this.lblwindows.TabIndex = 0;
            this.lblwindows.Text = "0";
            this.lblwindows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblwindows.TextChanged += new System.EventHandler(this.lblwindows_TextChanged);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.Location = new System.Drawing.Point(58, 120);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(37, 33);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.Location = new System.Drawing.Point(58, 159);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(37, 33);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.Location = new System.Drawing.Point(58, 198);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(37, 33);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlus.BackgroundImage")));
            this.btnPlus.Location = new System.Drawing.Point(188, 237);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 33);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEXE
            // 
            this.btnEXE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEXE.BackgroundImage")));
            this.btnEXE.Location = new System.Drawing.Point(230, 237);
            this.btnEXE.Name = "btnEXE";
            this.btnEXE.Size = new System.Drawing.Size(37, 33);
            this.btnEXE.TabIndex = 5;
            this.btnEXE.Text = "=";
            this.btnEXE.UseVisualStyleBackColor = true;
            this.btnEXE.Click += new System.EventHandler(this.btnEXE_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinus.BackgroundImage")));
            this.btnMinus.Location = new System.Drawing.Point(187, 198);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 33);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPower.BackgroundImage")));
            this.btnPower.Location = new System.Drawing.Point(188, 159);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(37, 33);
            this.btnPower.TabIndex = 7;
            this.btnPower.Text = "*";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivide.BackgroundImage")));
            this.btnDivide.Location = new System.Drawing.Point(188, 120);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(37, 33);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.Location = new System.Drawing.Point(144, 120);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(37, 33);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.Location = new System.Drawing.Point(144, 159);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(37, 33);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.Location = new System.Drawing.Point(144, 198);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(37, 33);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.Location = new System.Drawing.Point(101, 159);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(37, 33);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.Location = new System.Drawing.Point(101, 198);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(37, 33);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(18, 86);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 28);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnfu
            // 
            this.btnfu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfu.BackgroundImage")));
            this.btnfu.Location = new System.Drawing.Point(101, 237);
            this.btnfu.Name = "btnfu";
            this.btnfu.Size = new System.Drawing.Size(37, 33);
            this.btnfu.TabIndex = 16;
            this.btnfu.Text = "±";
            this.btnfu.UseVisualStyleBackColor = true;
            this.btnfu.Click += new System.EventHandler(this.btnfu_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMod.BackgroundImage")));
            this.btnMod.Location = new System.Drawing.Point(230, 159);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(37, 33);
            this.btnMod.TabIndex = 17;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.Location = new System.Drawing.Point(212, 86);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(55, 28);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 184);
            this.button1.TabIndex = 19;
            this.button1.Text = "z制作y";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.Location = new System.Drawing.Point(101, 120);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(37, 33);
            this.btn8.TabIndex = 20;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn0.BackgroundImage")));
            this.btn0.Location = new System.Drawing.Point(58, 237);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(37, 33);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDot.BackgroundImage")));
            this.btnDot.Location = new System.Drawing.Point(144, 237);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(37, 33);
            this.btnDot.TabIndex = 22;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnCountdown
            // 
            this.btnCountdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCountdown.BackgroundImage")));
            this.btnCountdown.Location = new System.Drawing.Point(230, 198);
            this.btnCountdown.Name = "btnCountdown";
            this.btnCountdown.Size = new System.Drawing.Size(37, 33);
            this.btnCountdown.TabIndex = 17;
            this.btnCountdown.Text = "1/x";
            this.btnCountdown.UseVisualStyleBackColor = true;
            this.btnCountdown.Click += new System.EventHandler(this.btnCountdown_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.Control;
            this.btnSqrt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSqrt.BackgroundImage")));
            this.btnSqrt.Location = new System.Drawing.Point(230, 120);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(37, 33);
            this.btnSqrt.TabIndex = 20;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSin.BackgroundImage")));
            this.btnSin.Location = new System.Drawing.Point(18, 120);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(37, 33);
            this.btnSin.TabIndex = 1;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCos.BackgroundImage")));
            this.btnCos.Location = new System.Drawing.Point(18, 159);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(37, 33);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTan.BackgroundImage")));
            this.btnTan.Location = new System.Drawing.Point(18, 198);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(37, 33);
            this.btnTan.TabIndex = 1;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnPI
            // 
            this.btnPI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPI.BackgroundImage")));
            this.btnPI.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPI.Location = new System.Drawing.Point(18, 237);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(37, 33);
            this.btnPI.TabIndex = 1;
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 25);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuClose});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(44, 21);
            this.Menu.Text = "文件";
            // 
            // MenuOpen
            // 
            this.MenuOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuOpen.BackgroundImage")));
            this.MenuOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpen.Size = new System.Drawing.Size(181, 22);
            this.MenuOpen.Text = "打开（O）";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuClose.BackgroundImage")));
            this.MenuClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuClose.Size = new System.Drawing.Size(181, 22);
            this.MenuClose.Text = "关闭（C）";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(314, 279);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCountdown);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnfu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnEXE);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.lblwindows);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "z-y计算器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwindows;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEXE;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnfu;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnCountdown;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
    }
}

