namespace UI
{
    partial class CompressForm_full
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
            this.uncompressed = new System.Windows.Forms.Panel();
            this.method_size = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.comfirm = new System.Windows.Forms.Button();
            this.method_name_text = new System.Windows.Forms.Label();
            this.图片格式 = new System.Windows.Forms.Label();
            this.format_selection = new System.Windows.Forms.ComboBox();
            this.method_bar = new System.Windows.Forms.TrackBar();
            this.compressed = new System.Windows.Forms.Panel();
            this.before_compress = new System.Windows.Forms.Label();
            this.after_compress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.method_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // uncompressed
            // 
            this.uncompressed.AutoSize = true;
            this.uncompressed.Location = new System.Drawing.Point(140, 43);
            this.uncompressed.Name = "uncompressed";
            this.uncompressed.Size = new System.Drawing.Size(200, 200);
            this.uncompressed.TabIndex = 27;
            // 
            // method_size
            // 
            this.method_size.AutoSize = true;
            this.method_size.Location = new System.Drawing.Point(513, 344);
            this.method_size.Name = "method_size";
            this.method_size.Size = new System.Drawing.Size(17, 12);
            this.method_size.TabIndex = 25;
            this.method_size.Text = "50";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(426, 391);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 32);
            this.cancel.TabIndex = 24;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // comfirm
            // 
            this.comfirm.Location = new System.Drawing.Point(289, 391);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(91, 32);
            this.comfirm.TabIndex = 23;
            this.comfirm.Text = "确定";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // method_name_text
            // 
            this.method_name_text.AutoSize = true;
            this.method_name_text.Location = new System.Drawing.Point(272, 344);
            this.method_name_text.Name = "method_name_text";
            this.method_name_text.Size = new System.Drawing.Size(71, 12);
            this.method_name_text.TabIndex = 21;
            this.method_name_text.Text = "method_name";
            // 
            // 图片格式
            // 
            this.图片格式.AutoSize = true;
            this.图片格式.Location = new System.Drawing.Point(287, 293);
            this.图片格式.Name = "图片格式";
            this.图片格式.Size = new System.Drawing.Size(53, 12);
            this.图片格式.TabIndex = 20;
            this.图片格式.Text = "图片格式";
            // 
            // format_selection
            // 
            this.format_selection.FormattingEnabled = true;
            this.format_selection.Items.AddRange(new object[] {
            "jpeg",
            "png",
            "bmp",
            "gif"});
            this.format_selection.Location = new System.Drawing.Point(362, 290);
            this.format_selection.Name = "format_selection";
            this.format_selection.Size = new System.Drawing.Size(132, 20);
            this.format_selection.TabIndex = 19;
            this.format_selection.Text = "jpeg";
            // 
            // method_bar
            // 
            this.method_bar.Location = new System.Drawing.Point(349, 330);
            this.method_bar.Maximum = 100;
            this.method_bar.Name = "method_bar";
            this.method_bar.Size = new System.Drawing.Size(158, 45);
            this.method_bar.TabIndex = 17;
            this.method_bar.Value = 50;
            this.method_bar.Scroll += new System.EventHandler(this.quality_bar_Scroll);
            // 
            // compressed
            // 
            this.compressed.AutoSize = true;
            this.compressed.Location = new System.Drawing.Point(440, 43);
            this.compressed.Name = "compressed";
            this.compressed.Size = new System.Drawing.Size(200, 200);
            this.compressed.TabIndex = 29;
            // 
            // before_compress
            // 
            this.before_compress.AutoSize = true;
            this.before_compress.Font = new System.Drawing.Font("宋体", 10F);
            this.before_compress.Location = new System.Drawing.Point(201, 258);
            this.before_compress.Name = "before_compress";
            this.before_compress.Size = new System.Drawing.Size(77, 14);
            this.before_compress.TabIndex = 30;
            this.before_compress.Text = "图像压缩前";
            // 
            // after_compress
            // 
            this.after_compress.AutoSize = true;
            this.after_compress.Font = new System.Drawing.Font("宋体", 10F);
            this.after_compress.Location = new System.Drawing.Point(498, 258);
            this.after_compress.Name = "after_compress";
            this.after_compress.Size = new System.Drawing.Size(77, 14);
            this.after_compress.TabIndex = 31;
            this.after_compress.Text = "图像压缩后";
            // 
            // CompressForm_full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.after_compress);
            this.Controls.Add(this.before_compress);
            this.Controls.Add(this.compressed);
            this.Controls.Add(this.uncompressed);
            this.Controls.Add(this.method_size);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.method_name_text);
            this.Controls.Add(this.图片格式);
            this.Controls.Add(this.format_selection);
            this.Controls.Add(this.method_bar);
            this.MaximizeBox = false;
            this.Name = "CompressForm_full";
            this.Text = "全参考图像压缩";
            this.Load += new System.EventHandler(this.compressForm_full_Load);
            ((System.ComponentModel.ISupportInitialize)(this.method_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel uncompressed;
        private System.Windows.Forms.Label method_size;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Label method_name_text;
        private System.Windows.Forms.Label 图片格式;
        private System.Windows.Forms.ComboBox format_selection;
        private System.Windows.Forms.TrackBar method_bar;
        private System.Windows.Forms.Panel compressed;
        private System.Windows.Forms.Label before_compress;
        private System.Windows.Forms.Label after_compress;
    }
}