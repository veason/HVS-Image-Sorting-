namespace UI
{
    partial class ImageDeleteComfirmForm
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
            this.result = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comfirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoScroll = true;
            this.result.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.result.ColumnCount = 4;
            this.result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.result.Location = new System.Drawing.Point(40, 52);
            this.result.Name = "result";
            this.result.RowCount = 1;
            this.result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.result.Size = new System.Drawing.Size(800, 200);
            this.result.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(380, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "以上图片将要被删除";
            // 
            // comfirm
            // 
            this.comfirm.Location = new System.Drawing.Point(285, 329);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(75, 41);
            this.comfirm.TabIndex = 5;
            this.comfirm.Text = "确认删除";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(534, 329);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 41);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "取消删除";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ImageDeleteComfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.MaximizeBox = false;
            this.Name = "ImageDeleteComfirmForm";
            this.Text = "图片清理";
            this.Load += new System.EventHandler(this.ImageDeleteComfirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Button cancel;

    }
}