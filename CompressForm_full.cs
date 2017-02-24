using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using demo1;

namespace UI
{
    public partial class CompressForm_full : Form
    {
        Dictionary<string, ImageFormat> imageformat = new Dictionary<string, ImageFormat>(); //图像格式字符串映射到c#库的图像格式的索引表
        public CompressForm_full()
        {
            InitializeComponent();
            imageformat["jpeg"] = ImageFormat.Jpeg;
            imageformat["png"] = ImageFormat.Png;
            imageformat["bmp"] = ImageFormat.Bmp;
            imageformat["gif"] = ImageFormat.Gif;

            if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_RATE)
            {
                this.method_name_text.Text = "压缩比";
            }
            else if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_SCORE)
            {
                this.method_name_text.Text = "质量分数";
            }
            
        }

        //更新质量分数进度条对应的数值
        private void quality_bar_Scroll(object sender, EventArgs e)
        {
            method_size.Text = method_bar.Value.ToString();
        }

      
        private void compressForm_full_Load(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < MainForm.tot; i++)
            {
                if (MainForm.selected[i])
                {
                    id = i; //获得被选中的图像的id，这里只选一张图片
                    break;
                }
            }

            picturePanel p1 = new picturePanel();
            picturePanel p2 = new picturePanel();
            uncompressed.Controls.Add(p1);
            compressed.Controls.Add(p2);
            p1.init(MainForm.picInfo[MainForm.path_name[id]].image, null);
            p2.init(null, null);
        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            imageformat["gif"] = ImageFormat.Gif;
            /**
             * 压缩处理
             */
            if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_RATE)
            {
                if (method_bar.Value == 0)
                {
                    MessageBox.Show("压缩程度不能为0!");
                    return;
                }
                Pic image = new Pic(((PictureBox)(uncompressed.Controls[0])).ImageLocation);
                Bitmap new_image = new Bitmap(image.compress(method_bar.Value, 100, format_selection.Text));
                new_image.Save("F:\\测试图像\\compressed_image." + format_selection.Text, imageformat[format_selection.Text]);
                ((picturePanel)compressed.Controls[1]).init(new_image, null);
            }
            else if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_SCORE)
            {
                Pic image = new Pic(((PictureBox)(uncompressed.Controls[0])).ImageLocation);
                Bitmap new_image = new Bitmap(image.compress(method_bar.Value,100, format_selection.Text));
                new_image.Save("F:\\测试图像\\compressed_image." + format_selection.Text, imageformat[format_selection.Text]);
                ((PictureBox)(compressed.Controls[0])).ImageLocation = "F:\\测试图像\\compressed_image." + format_selection.Text; //显示压缩后图片的缩略图
                Pic compress_image = new Pic("F:\\测试图像\\compressed_image." + format_selection.Text);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Dispose();
        }
    }
}
