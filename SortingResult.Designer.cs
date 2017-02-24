namespace UI
{
    partial class SortingResult
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
            this.beforeSortingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.afterSortingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hint = new System.Windows.Forms.Label();
            this.referenceImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.referenceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(376, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "排序前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(376, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "排序后";
            // 
            // beforeSortingPanel
            // 
            this.beforeSortingPanel.AutoScroll = true;
            this.beforeSortingPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.beforeSortingPanel.ColumnCount = 1;
            this.beforeSortingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.beforeSortingPanel.Location = new System.Drawing.Point(25, 65);
            this.beforeSortingPanel.Name = "beforeSortingPanel";
            this.beforeSortingPanel.RowCount = 1;
            this.beforeSortingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.beforeSortingPanel.Size = new System.Drawing.Size(785, 195);
            this.beforeSortingPanel.TabIndex = 2;
            // 
            // afterSortingPanel
            // 
            this.afterSortingPanel.AutoScroll = true;
            this.afterSortingPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.afterSortingPanel.ColumnCount = 1;
            this.afterSortingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.afterSortingPanel.Location = new System.Drawing.Point(25, 300);
            this.afterSortingPanel.Name = "afterSortingPanel";
            this.afterSortingPanel.RowCount = 1;
            this.afterSortingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.afterSortingPanel.Size = new System.Drawing.Size(785, 195);
            this.afterSortingPanel.TabIndex = 3;
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("宋体", 14F);
            this.hint.Location = new System.Drawing.Point(924, 108);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(0, 19);
            this.hint.TabIndex = 4;
            // 
            // referenceImage
            // 
            this.referenceImage.ErrorImage = null;
            this.referenceImage.InitialImage = null;
            this.referenceImage.Location = new System.Drawing.Point(854, 130);
            this.referenceImage.Name = "referenceImage";
            this.referenceImage.Size = new System.Drawing.Size(300, 300);
            this.referenceImage.TabIndex = 5;
            this.referenceImage.TabStop = false;
            // 
            // SortingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 521);
            this.Controls.Add(this.referenceImage);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.afterSortingPanel);
            this.Controls.Add(this.beforeSortingPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SortingResult";
            this.Text = "排序结果";
            this.Load += new System.EventHandler(this.SortingResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.referenceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel beforeSortingPanel;
        private System.Windows.Forms.TableLayoutPanel afterSortingPanel;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.PictureBox referenceImage;
    }
}