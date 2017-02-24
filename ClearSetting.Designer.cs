using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Threading;
using System.IO;
using System.Collections;
using demo1;
using Microsoft.VisualBasic.FileIO;

namespace UI
{
    partial class ClearSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;
        MainForm mf;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            /*
            //下面是删除左侧图片显示框中的所有图片，当有具体清除方案后可直接使用下面方法删除对应控件（如删除第i张图片）
            int n = MainForm.tot;//获取左侧显示框控件数目（全部是包含picturebox以及label的tablepannel）
            string imagePath = "";

            int i = n - (int)((double)n * clearRatioBar.Value / 100);
            for (; i < n; i++)
            {
                imagePath = MainForm.path_name[i];
                if (File.Exists(imagePath))
                {
                    FileSystem.DeleteFile(imagePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                MainForm.state[i] = true;
            }
            mf.delete();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            */
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearRatioBar = new System.Windows.Forms.TrackBar();
            this.text = new System.Windows.Forms.Label();
            this.ratio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clearRatioBar)).BeginInit();
            this.SuspendLayout();
            // 
            // clearRatioBar
            // 
            this.clearRatioBar.Location = new System.Drawing.Point(143, 82);
            this.clearRatioBar.Maximum = 100;
            this.clearRatioBar.Name = "clearRatioBar";
            this.clearRatioBar.Size = new System.Drawing.Size(104, 45);
            this.clearRatioBar.TabIndex = 0;
            this.clearRatioBar.Value = 50;
            this.clearRatioBar.Scroll += new System.EventHandler(this.clearRatioBar_Scroll);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("宋体", 10F);
            this.text.Location = new System.Drawing.Point(48, 92);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(77, 14);
            this.text.TabIndex = 1;
            this.text.Text = "图片清理率";
            // 
            // ratio
            // 
            this.ratio.AutoSize = true;
            this.ratio.Font = new System.Drawing.Font("宋体", 10F);
            this.ratio.Location = new System.Drawing.Point(267, 92);
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(28, 14);
            this.ratio.TabIndex = 2;
            this.ratio.Text = "50%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ratio);
            this.Controls.Add(this.text);
            this.Controls.Add(this.clearRatioBar);
            this.Name = "ClearSetting";
            this.Text = "ClearSetting";
            ((System.ComponentModel.ISupportInitialize)(this.clearRatioBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar clearRatioBar;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label ratio;
        private System.Windows.Forms.Button button1;
    }
}