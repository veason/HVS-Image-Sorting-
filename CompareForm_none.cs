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
            //添加两个PictureBox作为图像容器
            PictureBox image1 = new PictureBox();
            PictureBox image2 = new PictureBox();
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
            compare_image_1.Controls.Add(p1);
            compare_image_2.Controls.Add(p2);
            p1.init(MainForm.picInfo[MainForm.path_name[id1]].image, MainForm.name[id1]);
            p2.init(MainForm.picInfo[MainForm.path_name[id2]].image, MainForm.name[id2]);

            int score1 = (int)(new Pic(MainForm.path_name[id1])).tenengrad();
            int score2 = (int)(new Pic(MainForm.path_name[id2])).tenengrad();
            compare_image_score_1.Text = "得分：" +　score1.ToString();
            compare_image_score_2.Text = "得分："　+　score2.ToString();
            if (score1 > score2) op.Text = ">";
            else if (score1 < score2) op.Text = "<";
            else op.Text = "=";
        }
    }
}
