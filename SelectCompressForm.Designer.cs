namespace UI
{
    partial class SelectCompressForm
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
            this.to_compress_rate = new System.Windows.Forms.Button();
            this.to_compress_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // to_compress_rate
            // 
            this.to_compress_rate.Location = new System.Drawing.Point(32, 68);
            this.to_compress_rate.Name = "to_compress_rate";
            this.to_compress_rate.Size = new System.Drawing.Size(158, 23);
            this.to_compress_rate.TabIndex = 0;
            this.to_compress_rate.Text = "根据压缩程度压缩";
            this.to_compress_rate.UseVisualStyleBackColor = true;
            //this.to_compress_rate.Click += new System.EventHandler(this.to_compress_rate_Click);
            // 
            // to_compress_score
            // 
            this.to_compress_score.Location = new System.Drawing.Point(224, 68);
            this.to_compress_score.Name = "to_compress_score";
            this.to_compress_score.Size = new System.Drawing.Size(134, 23);
            this.to_compress_score.TabIndex = 1;
            this.to_compress_score.Text = "根据质量分数压缩";
            this.to_compress_score.UseVisualStyleBackColor = true;
            //this.to_compress_score.Click += new System.EventHandler(this.to_compress_score_Click);
            // 
            // SelectCompressMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 162);
            this.Controls.Add(this.to_compress_score);
            this.Controls.Add(this.to_compress_rate);
            this.Name = "SelectCompressMethod";
            this.Text = "SelectCompressMethod";
            this.ResumeLayout(false);

          
        }

        #endregion

        private System.Windows.Forms.Button to_compress_rate;
        private System.Windows.Forms.Button to_compress_score;
    }
}