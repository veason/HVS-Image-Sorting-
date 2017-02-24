namespace UI
{
    partial class CompareForm_none
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
            this.compare_image_1 = new System.Windows.Forms.Panel();
            this.compare_image_2 = new System.Windows.Forms.Panel();
            this.compare_image_name_1 = new System.Windows.Forms.Label();
            this.compare_image_score_1 = new System.Windows.Forms.Label();
            this.compare_image_name2 = new System.Windows.Forms.Label();
            this.compare_image_score_2 = new System.Windows.Forms.Label();
            this.comfirm = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compare_image_1
            // 
            this.compare_image_1.AutoSize = true;
            this.compare_image_1.Location = new System.Drawing.Point(120, 40);
            this.compare_image_1.Name = "compare_image_1";
            this.compare_image_1.Size = new System.Drawing.Size(225, 225);
            this.compare_image_1.TabIndex = 16;
            // 
            // compare_image_2
            // 
            this.compare_image_2.AutoSize = true;
            this.compare_image_2.Location = new System.Drawing.Point(400, 40);
            this.compare_image_2.Name = "compare_image_2";
            this.compare_image_2.Size = new System.Drawing.Size(225, 225);
            this.compare_image_2.TabIndex = 17;
            // 
            // compare_image_name_1
            // 
            this.compare_image_name_1.AutoSize = true;
            this.compare_image_name_1.Font = new System.Drawing.Font("宋体", 10F);
            this.compare_image_name_1.Location = new System.Drawing.Point(200, 280);
            this.compare_image_name_1.Name = "compare_image_name_1";
            this.compare_image_name_1.Size = new System.Drawing.Size(42, 14);
            this.compare_image_name_1.TabIndex = 33;
            this.compare_image_name_1.Text = "图片1";
            // 
            // compare_image_score_1
            // 
            this.compare_image_score_1.AutoSize = true;
            this.compare_image_score_1.Font = new System.Drawing.Font("宋体", 10F);
            this.compare_image_score_1.Location = new System.Drawing.Point(200, 310);
            this.compare_image_score_1.Name = "compare_image_score_1";
            this.compare_image_score_1.Size = new System.Drawing.Size(49, 14);
            this.compare_image_score_1.TabIndex = 34;
            this.compare_image_score_1.Text = "score:";
            // 
            // compare_image_name2
            // 
            this.compare_image_name2.AutoSize = true;
            this.compare_image_name2.Font = new System.Drawing.Font("宋体", 10F);
            this.compare_image_name2.Location = new System.Drawing.Point(490, 280);
            this.compare_image_name2.Name = "compare_image_name2";
            this.compare_image_name2.Size = new System.Drawing.Size(42, 14);
            this.compare_image_name2.TabIndex = 35;
            this.compare_image_name2.Text = "图片2";
            // 
            // compare_image_score_2
            // 
            this.compare_image_score_2.AutoSize = true;
            this.compare_image_score_2.Font = new System.Drawing.Font("宋体", 10F);
            this.compare_image_score_2.Location = new System.Drawing.Point(490, 310);
            this.compare_image_score_2.Name = "compare_image_score_2";
            this.compare_image_score_2.Size = new System.Drawing.Size(49, 14);
            this.compare_image_score_2.TabIndex = 36;
            this.compare_image_score_2.Text = "score:";
            // 
            // comfirm
            // 
            this.comfirm.Location = new System.Drawing.Point(334, 360);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(78, 34);
            this.comfirm.TabIndex = 37;
            this.comfirm.Text = "确定";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // op
            // 
            this.op.AutoSize = true;
            this.op.Font = new System.Drawing.Font("宋体", 20F);
            this.op.Location = new System.Drawing.Point(359, 308);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(26, 27);
            this.op.TabIndex = 38;
            this.op.Text = ">";
            // 
            // CompareForm_none
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.op);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.compare_image_score_2);
            this.Controls.Add(this.compare_image_name2);
            this.Controls.Add(this.compare_image_score_1);
            this.Controls.Add(this.compare_image_name_1);
            this.Controls.Add(this.compare_image_2);
            this.Controls.Add(this.compare_image_1);
            this.MaximizeBox = false;
            this.Name = "CompareForm_none";
            this.Text = "图片比较";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel compare_image_1;
        private System.Windows.Forms.Panel compare_image_2;
        private System.Windows.Forms.Label compare_image_name_1;
        private System.Windows.Forms.Label compare_image_score_1;
        private System.Windows.Forms.Label compare_image_name2;
        private System.Windows.Forms.Label compare_image_score_2;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Label op;
    }
}