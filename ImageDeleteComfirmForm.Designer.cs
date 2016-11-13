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
            this.images_to_be_deleted_tablelayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comfirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // images_to_be_deleted_tablelayoutpanel
            // 
            this.images_to_be_deleted_tablelayoutpanel.AutoScroll = true;
            this.images_to_be_deleted_tablelayoutpanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.images_to_be_deleted_tablelayoutpanel.ColumnCount = 1;
            this.images_to_be_deleted_tablelayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.images_to_be_deleted_tablelayoutpanel.Location = new System.Drawing.Point(39, 54);
            this.images_to_be_deleted_tablelayoutpanel.Name = "images_to_be_deleted_tablelayoutpanel";
            this.images_to_be_deleted_tablelayoutpanel.RowCount = 1;
            this.images_to_be_deleted_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.images_to_be_deleted_tablelayoutpanel.Size = new System.Drawing.Size(620, 150);
            this.images_to_be_deleted_tablelayoutpanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "以上图片将要被删除";
            // 
            // comfirm
            // 
            this.comfirm.Location = new System.Drawing.Point(251, 273);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(75, 23);
            this.comfirm.TabIndex = 5;
            this.comfirm.Text = "确认删除";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(364, 273);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "取消删除";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ImageDeleteComfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 343);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.images_to_be_deleted_tablelayoutpanel);
            this.Name = "ImageDeleteComfirmForm";
            this.Text = "ImageDeleteComfirmForm";
            this.Load += new System.EventHandler(this.ImageDeleteComfirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel images_to_be_deleted_tablelayoutpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Button cancel;

    }
}