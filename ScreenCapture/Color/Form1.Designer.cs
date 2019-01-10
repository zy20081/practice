namespace Color1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.trbgreen = new System.Windows.Forms.TrackBar();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.trbAlpha = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "红色（Red）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "蓝色（Blue）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "绿色（green）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alpha";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelColor.Location = new System.Drawing.Point(42, 197);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(596, 178);
            this.panelColor.TabIndex = 4;
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(139, 17);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(419, 45);
            this.trbRed.TabIndex = 5;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // trbgreen
            // 
            this.trbgreen.Location = new System.Drawing.Point(139, 60);
            this.trbgreen.Maximum = 255;
            this.trbgreen.Name = "trbgreen";
            this.trbgreen.Size = new System.Drawing.Size(419, 45);
            this.trbgreen.TabIndex = 6;
            this.trbgreen.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(139, 111);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(419, 45);
            this.trbBlue.TabIndex = 7;
            this.trbBlue.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // trbAlpha
            // 
            this.trbAlpha.Location = new System.Drawing.Point(139, 150);
            this.trbAlpha.Maximum = 255;
            this.trbAlpha.Name = "trbAlpha";
            this.trbAlpha.Size = new System.Drawing.Size(419, 45);
            this.trbAlpha.TabIndex = 8;
            this.trbAlpha.Value = 250;
            this.trbAlpha.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 411);
            this.Controls.Add(this.trbAlpha);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbgreen);
            this.Controls.Add(this.trbRed);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TrackBar trbgreen;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TrackBar trbAlpha;
    }
}

