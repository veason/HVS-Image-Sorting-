namespace UI
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.image_clean_full_combobox = new System.Windows.Forms.ComboBox();
            this.image_clean_none_combobox = new System.Windows.Forms.ComboBox();
            this.image_compress_full_combobox = new System.Windows.Forms.ComboBox();
            this.image_sort_full_combobox = new System.Windows.Forms.ComboBox();
            this.image_sort_none_combobox = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.image_compare_none_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.outputFolder = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(117, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片清理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(117, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "保质压缩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(117, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "质量排序";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(230, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "全参考";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(230, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "无参考";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(230, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "全参考";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(230, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "无参考";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(230, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "全参考";
            // 
            // image_clean_full_combobox
            // 
            this.image_clean_full_combobox.FormattingEnabled = true;
            this.image_clean_full_combobox.Items.AddRange(new object[] {
            "PSNR",
            "LBP"});
            this.image_clean_full_combobox.Location = new System.Drawing.Point(320, 40);
            this.image_clean_full_combobox.Name = "image_clean_full_combobox";
            this.image_clean_full_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_clean_full_combobox.TabIndex = 9;
            // 
            // image_clean_none_combobox
            // 
            this.image_clean_none_combobox.FormattingEnabled = true;
            this.image_clean_none_combobox.Items.AddRange(new object[] {
            "tenengrad"});
            this.image_clean_none_combobox.Location = new System.Drawing.Point(320, 85);
            this.image_clean_none_combobox.Name = "image_clean_none_combobox";
            this.image_clean_none_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_clean_none_combobox.TabIndex = 10;
            // 
            // image_compress_full_combobox
            // 
            this.image_compress_full_combobox.FormattingEnabled = true;
            this.image_compress_full_combobox.Items.AddRange(new object[] {
            "PSNR",
            "LBP"});
            this.image_compress_full_combobox.Location = new System.Drawing.Point(320, 130);
            this.image_compress_full_combobox.Name = "image_compress_full_combobox";
            this.image_compress_full_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_compress_full_combobox.TabIndex = 11;
            // 
            // image_sort_full_combobox
            // 
            this.image_sort_full_combobox.FormattingEnabled = true;
            this.image_sort_full_combobox.Items.AddRange(new object[] {
            "PSNR",
            "LBP"});
            this.image_sort_full_combobox.Location = new System.Drawing.Point(320, 180);
            this.image_sort_full_combobox.Name = "image_sort_full_combobox";
            this.image_sort_full_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_sort_full_combobox.TabIndex = 13;
            // 
            // image_sort_none_combobox
            // 
            this.image_sort_none_combobox.FormattingEnabled = true;
            this.image_sort_none_combobox.Items.AddRange(new object[] {
            "tenengrad"});
            this.image_sort_none_combobox.Location = new System.Drawing.Point(320, 225);
            this.image_sort_none_combobox.Name = "image_sort_none_combobox";
            this.image_sort_none_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_sort_none_combobox.TabIndex = 14;
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Location = new System.Drawing.Point(220, 380);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 30);
            this.confirm.TabIndex = 15;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(360, 380);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 30);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // image_compare_none_combobox
            // 
            this.image_compare_none_combobox.FormattingEnabled = true;
            this.image_compare_none_combobox.Items.AddRange(new object[] {
            "tenengrad"});
            this.image_compare_none_combobox.Location = new System.Drawing.Point(320, 270);
            this.image_compare_none_combobox.Name = "image_compare_none_combobox";
            this.image_compare_none_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_compare_none_combobox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(230, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "无参考";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(117, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "质量比较";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(150, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "图像输出文件夹";
            // 
            // outputFolder
            // 
            this.outputFolder.FormattingEnabled = true;
            this.outputFolder.Items.AddRange(new object[] {
            "default"});
            this.outputFolder.Location = new System.Drawing.Point(320, 330);
            this.outputFolder.Name = "outputFolder";
            this.outputFolder.Size = new System.Drawing.Size(198, 20);
            this.outputFolder.TabIndex = 19;
            this.outputFolder.Text = "default";
            // 
            // selection
            // 
            this.selection.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selection.Location = new System.Drawing.Point(540, 330);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(75, 30);
            this.selection.TabIndex = 20;
            this.selection.Text = "浏览文件夹";
            this.selection.UseVisualStyleBackColor = true;
            this.selection.Click += new System.EventHandler(this.selection_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 421);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.outputFolder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.image_sort_none_combobox);
            this.Controls.Add(this.image_sort_full_combobox);
            this.Controls.Add(this.image_compare_none_combobox);
            this.Controls.Add(this.image_compress_full_combobox);
            this.Controls.Add(this.image_clean_none_combobox);
            this.Controls.Add(this.image_clean_full_combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox image_clean_full_combobox;
        private System.Windows.Forms.ComboBox image_clean_none_combobox;
        private System.Windows.Forms.ComboBox image_compress_full_combobox;
        private System.Windows.Forms.ComboBox image_sort_full_combobox;
        private System.Windows.Forms.ComboBox image_sort_none_combobox;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox image_compare_none_combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox outputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button selection;
    }
}