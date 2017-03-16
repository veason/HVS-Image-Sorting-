using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using demo1;

namespace UI
{
    public partial class CompareForm_none : Form
    {
        private const double size_rate = 0.9;
        private const double image_size_rate = 0.37;
        public CompareForm_none()
        {
            InitializeComponent();
        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            this.Width = (int)(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width * size_rate);
            this.Height = (int)(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height * size_rate);
            this.Location = new Point((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 3 * 2, (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 3 * 2);
            compare_image1.Width = compare_image1.Height = (int)(this.Width * image_size_rate);
            compare_image2.Width = compare_image2.Height = (int)(this.Width * image_size_rate);
            compare_image1.Location = new Point((int)(this.Width * 0.08), (int)(this.Height * 0.01));
            compare_image2.Location = new Point((int)(this.Width * 0.55), (int)(this.Height * 0.01));
            hint.Location = new Point((int)(this.Width * 0.46), (int)(this.Height * 0.74));
            score_text1.Location = new Point((int)(this.Width * 0.38), (int)(this.Height * 0.8));
            score_text2.Location = new Point((int)(this.Width * 0.55), (int)(this.Height * 0.8));
            op.Location = new Point((int)(this.Width * 0.49), (int)(this.Height * 0.8));
            confirm.Location = new Point((int)(this.Width * 0.47), (int)(this.Height * 0.86));

            int id1 = 0, id2 = 0;
            for (int i = 0; i < MainForm.tot; i++)
            {
                if (MainForm.selected[i])
                {
                    id1 = i; //获得被选中的图像的id，这里只选一张图片
                    break;
                }
            }
            for (int i = id1 + 1; i < MainForm.tot; i++)
            {
                if (MainForm.selected[i])
                {
                    id2 = i; //获得被选中的图像的id，这里只选一张图片
                    break;
                }
            }

            picturePanel p1 = new picturePanel();
            picturePanel p2 = new picturePanel();
            compare_image1.Controls.Add(p1);
            compare_image2.Controls.Add(p2);
            p1.init(MainForm.picInfo[MainForm.path_name[id1]].image, MainForm.name[id1]);
            p2.init(MainForm.picInfo[MainForm.path_name[id2]].image, MainForm.name[id2]);
            p1.image_name.Height = 25;
            p2.image_name.Height = 25;
            p1.image_name.Font = new Font("微软雅黑", 14);
            p2.image_name.Font = new Font("微软雅黑", 14);

            int score1 = (int)(new Pic(MainForm.path_name[id1], null)).tenengrad();
            int score2 = (int)(new Pic(MainForm.path_name[id2], null)).tenengrad();
            score_text1.Text = "得分：" +　score1.ToString();
            score_text2.Text = "得分："　+　score2.ToString();
            if (score1 > score2) 
            {
                op.Text = ">";
            }
            else if (score1 < score2)
            {
                op.Text = "<";
            }
            else
            {
                op.Text = "=";
            }
        }

        private void CompareForm_none_Resize(object sender, EventArgs e)
        {
            compare_image1.Width = compare_image1.Height = (int)(this.Width * image_size_rate);
            compare_image2.Width = compare_image2.Height = (int)(this.Width * image_size_rate);
            compare_image1.Location = new Point((int)(this.Width * 0.08), (int)(this.Height * 0.02));
            compare_image2.Location = new Point((int)(this.Width * 0.55), (int)(this.Height * 0.02));
            hint.Location = new Point((int)(this.Width * 0.46), (int)(this.Height * 0.75));
            score_text1.Location = new Point((int)(this.Width * 0.38), (int)(this.Height * 0.81));
            score_text2.Location = new Point((int)(this.Width * 0.55), (int)(this.Height * 0.81));
            op.Location = new Point((int)(this.Width * 0.49), (int)(this.Height * 0.81));
            confirm.Location = new Point((int)(this.Width * 0.47), (int)(this.Height * 0.87));
        }
    }
}
