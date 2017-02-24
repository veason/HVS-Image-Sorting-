namespace UI
{
    partial class CompressForm_none
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
            this.before_compress = new System.Windows.Forms.Label();
            this.after_compress = new System.Windows.Forms.Label();
            this.rate_bar1 = new System.Windows.Forms.TrackBar();
            this.format_selection = new System.Windows.Forms.ComboBox();
            this.图片格式 = new System.Windows.Forms.Label();
            this.method1 = new System.Windows.Forms.Label();
            this.comfirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.rate1 = new System.Windows.Forms.Label();
            this.uncompressed = new System.Windows.Forms.Panel();
            this.compressed = new System.Windows.Forms.Panel();
            this.method2 = new System.Windows.Forms.Label();
            this.rate_bar2 = new System.Windows.Forms.TrackBar();
            this.rate2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.rate_bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_bar2)).BeginInit();
            this.SuspendLayout();
            // 
            // before_compress
            // 
            this.before_compress.AutoSize = true;
            this.before_compress.Font = new System.Drawing.Font("宋体", 10F);
            this.before_compress.Location = new System.Drawing.Point(195, 280);
            this.before_compress.Name = "before_compress";
            this.before_compress.Size = new System.Drawing.Size(77, 14);
            this.before_compress.TabIndex = 2;
            this.before_compress.Text = "图像压缩前";
            // 
            // after_compress
            // 
            this.after_compress.AutoSize = true;
            this.after_compress.Font = new System.Drawing.Font("宋体", 10F);
            this.after_compress.Location = new System.Drawing.Point(520, 280);
            this.after_compress.Name = "after_compress";
            this.after_compress.Size = new System.Drawing.Size(77, 14);
            this.after_compress.TabIndex = 3;
            this.after_compress.Text = "图像压缩后";
            // 
            // rate_bar1
            // 
            this.rate_bar1.Location = new System.Drawing.Point(330, 365);
            this.rate_bar1.Maximum = 100;
            this.rate_bar1.Name = "rate_bar1";
            this.rate_bar1.Size = new System.Drawing.Size(174, 45);
            this.rate_bar1.TabIndex = 4;
            this.rate_bar1.Value = 50;
            this.rate_bar1.Scroll += new System.EventHandler(this.rate_bar1_Scroll);
            // 
            // format_selection
            // 
            this.format_selection.Font = new System.Drawing.Font("宋体", 10F);
            this.format_selection.FormattingEnabled = true;
            this.format_selection.Items.AddRange(new object[] {
            "jpeg",
            "png",
            "bmp",
            "gif"});
            this.format_selection.Location = new System.Drawing.Point(342, 323);
            this.format_selection.Name = "format_selection";
            this.format_selection.Size = new System.Drawing.Size(140, 21);
            this.format_selection.TabIndex = 7;
            this.format_selection.Text = "jpeg";
            // 
            // 图片格式
            // 
            this.图片格式.AutoSize = true;
            this.图片格式.Location = new System.Drawing.Point(268, 326);
            this.图片格式.Name = "图片格式";
            this.图片格式.Size = new System.Drawing.Size(53, 12);
            this.图片格式.TabIndex = 8;
            this.图片格式.Text = "图片格式";
            // 
            // method1
            // 
            this.method1.AutoSize = true;
            this.method1.Location = new System.Drawing.Point(244, 370);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(77, 12);
            this.method1.TabIndex = 9;
            this.method1.Text = "按压缩率压缩";
            // 
            // comfirm
            // 
            this.comfirm.Location = new System.Drawing.Point(270, 465);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(91, 32);
            this.comfirm.TabIndex = 11;
            this.comfirm.Text = "确定";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(430, 465);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 32);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // rate1
            // 
            this.rate1.AutoSize = true;
            this.rate1.Font = new System.Drawing.Font("宋体", 10F);
            this.rate1.Location = new System.Drawing.Point(512, 370);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(21, 14);
            this.rate1.TabIndex = 13;
            this.rate1.Text = "50";
            // 
            // uncompressed
            // 
            this.uncompressed.AutoSize = true;
            this.uncompressed.Location = new System.Drawing.Point(124, 40);
            this.uncompressed.Name = "uncompressed";
            this.uncompressed.Size = new System.Drawing.Size(225, 225);
            this.uncompressed.TabIndex = 15;
            // 
            // compressed
            // 
            this.compressed.AutoSize = true;
            this.compressed.Location = new System.Drawing.Point(450, 40);
            this.compressed.Name = "compressed";
            this.compressed.Size = new System.Drawing.Size(225, 225);
            this.compressed.TabIndex = 16;
            // 
            // method2
            // 
            this.method2.AutoSize = true;
            this.method2.Location = new System.Drawing.Point(232, 419);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(89, 12);
            this.method2.TabIndex = 17;
            this.method2.Text = "按质量分数压缩";
            // 
            // rate_bar2
            // 
            this.rate_bar2.Location = new System.Drawing.Point(330, 410);
            this.rate_bar2.Maximum = 100;
            this.rate_bar2.Name = "rate_bar2";
            this.rate_bar2.Size = new System.Drawing.Size(174, 45);
            this.rate_bar2.TabIndex = 18;
            this.rate_bar2.Value = 50;
            this.rate_bar2.Scroll += new System.EventHandler(this.rate_bar2_Scroll);
            // 
            // rate2
            // 
            this.rate2.AutoSize = true;
            this.rate2.Font = new System.Drawing.Font("宋体", 10F);
            this.rate2.Location = new System.Drawing.Point(512, 420);
            this.rate2.Name = "rate2";
            this.rate2.Size = new System.Drawing.Size(21, 14);
            this.rate2.TabIndex = 19;
            this.rate2.Text = "50";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(549, 371);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(549, 421);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // CompressForm_none
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 521);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rate2);
            this.Controls.Add(this.rate_bar2);
            this.Controls.Add(this.method2);
            this.Controls.Add(this.compressed);
            this.Controls.Add(this.uncompressed);
            this.Controls.Add(this.rate1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.method1);
            this.Controls.Add(this.图片格式);
            this.Controls.Add(this.format_selection);
            this.Controls.Add(this.rate_bar1);
            this.Controls.Add(this.after_compress);
            this.Controls.Add(this.before_compress);
            this.MaximizeBox = false;
            this.Name = "CompressForm_none";
            this.Text = "无参考图像压缩";
            this.Load += new System.EventHandler(this.compressForm_none_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rate_bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate_bar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label before_compress;
        private System.Windows.Forms.Label after_compress;
        private System.Windows.Forms.TrackBar rate_bar1;
        private System.Windows.Forms.ComboBox format_selection;
        private System.Windows.Forms.Label 图片格式;
        private System.Windows.Forms.Label method1;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label rate1;
        private System.Windows.Forms.Panel uncompressed;
        private System.Windows.Forms.Panel compressed;
        private System.Windows.Forms.Label method2;
        private System.Windows.Forms.TrackBar rate_bar2;
        private System.Windows.Forms.Label rate2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}