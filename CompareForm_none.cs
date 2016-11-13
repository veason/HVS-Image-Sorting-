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

            string path;
            Bitmap image;
            int height;
            int width;
            int basement;

            //左边图片
            path = MainForm.path_name[id1]; //获得被选图片路径
            image = new Bitmap(path);
            height = image.Height;
            width = image.Width;
            basement = height > width ? height : width;
            image1.Height = (int)((double)height / basement * 160);
            image1.Width = (int)((double)width / basement * 160);
            image1.BorderStyle = BorderStyle.FixedSingle;
            image1.ImageLocation = path;
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.Anchor = AnchorStyles.None;
            image1.Location = new Point((compare_image_1.Width - image1.Width) / 2, (compare_image_1.Height - image1.Height) / 2);
            compare_image_1.Controls.Add(image1);

            //右边图片
            path = MainForm.path_name[id2]; //获得被选图片路径
            image = new Bitmap(path);
            height = image.Height;
            width = image.Width;
            basement = height > width ? height : width;
            image2.Height = (int)((double)height / basement * 160);
            image2.Width = (int)((double)width / basement * 160);
            image2.BorderStyle = BorderStyle.FixedSingle;
            image2.ImageLocation = path;
            image2.SizeMode = PictureBoxSizeMode.StretchImage;
            image2.Anchor = AnchorStyles.None;
            image2.Location = new Point((compare_image_2.Width - image2.Width) / 2, (compare_image_2.Height - image2.Height) / 2);
            compare_image_2.Controls.Add(image2);

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
