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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(92, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片清理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(92, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "保质压缩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(92, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "质量排序";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(207, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "全参考";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(207, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "无参考";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(207, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "全参考";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(207, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "无参考";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(207, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "全参考";
            // 
            // image_clean_full_combobox
            // 
            this.image_clean_full_combobox.FormattingEnabled = true;
            this.image_clean_full_combobox.Items.AddRange(new object[] {
            "image_clean_full_algorithm_1",
            "image_clean_full_algorithm_2",
            "image_clean_full_algorithm_3"});
            this.image_clean_full_combobox.Location = new System.Drawing.Point(323, 68);
            this.image_clean_full_combobox.Name = "image_clean_full_combobox";
            this.image_clean_full_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_clean_full_combobox.TabIndex = 9;
            // 
            // image_clean_none_combobox
            // 
            this.image_clean_none_combobox.FormattingEnabled = true;
            this.image_clean_none_combobox.Items.AddRange(new object[] {
            "image_clean_none_algorithm_1",
            "image_clean_none_algorithm_2",
            "image_clean_none_algorithm_3"});
            this.image_clean_none_combobox.Location = new System.Drawing.Point(323, 108);
            this.image_clean_none_combobox.Name = "image_clean_none_combobox";
            this.image_clean_none_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_clean_none_combobox.TabIndex = 10;
            // 
            // image_compress_full_combobox
            // 
            this.image_compress_full_combobox.FormattingEnabled = true;
            this.image_compress_full_combobox.Items.AddRange(new object[] {
            "image_compress_full_algorithm_1",
            "image_compress_full_algorithm_2",
            "image_compress_full_algorithm_3"});
            this.image_compress_full_combobox.Location = new System.Drawing.Point(323, 151);
            this.image_compress_full_combobox.Name = "image_compress_full_combobox";
            this.image_compress_full_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_compress_full_combobox.TabIndex = 11;
            // 
            // image_sort_full_combobox
            // 
            this.image_sort_full_combobox.FormattingEnabled = true;
            this.image_sort_full_combobox.Items.AddRange(new object[] {
            "image_sort_full_algorithm_1",
            "image_sort_full_algorithm_2",
            "image_sort_full_algorithm_3"});
            this.image_sort_full_combobox.Location = new System.Drawing.Point(323, 199);
            this.image_sort_full_combobox.Name = "image_sort_full_combobox";
            this.image_sort_full_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_sort_full_combobox.TabIndex = 13;
            // 
            // image_sort_none_combobox
            // 
            this.image_sort_none_combobox.FormattingEnabled = true;
            this.image_sort_none_combobox.Items.AddRange(new object[] {
            "image_sort_none_algorithm_1",
            "image_sort_none_algorithm_2",
            "image_sort_none_algorithm_3"});
            this.image_sort_none_combobox.Location = new System.Drawing.Point(323, 235);
            this.image_sort_none_combobox.Name = "image_sort_none_combobox";
            this.image_sort_none_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_sort_none_combobox.TabIndex = 14;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(172, 324);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 15;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(292, 324);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // image_compare_none_combobox
            // 
            this.image_compare_none_combobox.FormattingEnabled = true;
            this.image_compare_none_combobox.Items.AddRange(new object[] {
            "image_compare_none_algorithm_1",
            "image_compare_none_algorithm_2",
            "image_compare_none_algorithm_3"});
            this.image_compare_none_combobox.Location = new System.Drawing.Point(323, 275);
            this.image_compare_none_combobox.Name = "image_compare_none_combobox";
            this.image_compare_none_combobox.Size = new System.Drawing.Size(198, 20);
            this.image_compare_none_combobox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(207, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "无参考";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F);
            this.label10.Location = new System.Drawing.Point(92, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "质量比较";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 382);
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
    }
}