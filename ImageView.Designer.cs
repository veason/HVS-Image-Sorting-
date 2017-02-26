namespace UI
{
    partial class ImageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton2 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton1 = new LT.WinForm.ImageButton.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(63, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pictureBox1.Size = new System.Drawing.Size(192, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-7, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 244);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // imageButton2
            // 
            this.imageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("imageButton2.ButtonImage")));
            this.imageButton2.ButtonText = "";
            this.imageButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageButton2.Location = new System.Drawing.Point(258, 20);
            this.imageButton2.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.imageButton2.MouseClickImage = ((System.Drawing.Image)(resources.GetObject("imageButton2.MouseClickImage")));
            this.imageButton2.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("imageButton2.MouseOverImage")));
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(44, 138);
            this.imageButton2.TabIndex = 2;
            this.imageButton2.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageButton2_Click);
            // 
            // imageButton1
            // 
            this.imageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.ButtonImage")));
            this.imageButton1.ButtonText = "";
            this.imageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imageButton1.Location = new System.Drawing.Point(10, 20);
            this.imageButton1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.imageButton1.MouseClickImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.MouseClickImage")));
            this.imageButton1.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.MouseOverImage")));
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(44, 138);
            this.imageButton1.TabIndex = 3;
            this.imageButton1.Click += new LT.WinForm.ImageButton.ImageButton.ClickEventHandler(this.imageButton1_Click);
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImageView";
            this.Text = "ImageView";
            this.Load += new System.EventHandler(this.ImageView_Load);
            this.Resize += new System.EventHandler(this.ImageView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected LT.WinForm.ImageButton.ImageButton imageButton2;
        protected LT.WinForm.ImageButton.ImageButton imageButton1;
    }
}