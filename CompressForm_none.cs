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
    public partial class CompressForm_none : Form
    {
        Dictionary<string, ImageFormat> imageformat = new Dictionary<string,ImageFormat>(); //图像格式字符串映射到c#库的图像格式的索引表
        public CompressForm_none()
        {
            InitializeComponent();
            imageformat["jpeg"] = ImageFormat.Jpeg;
            imageformat["png"] = ImageFormat.Png;
            imageformat["bmp"] = ImageFormat.Bmp;
            imageformat["gif"] = ImageFormat.Gif;
            if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_RATE)
            {
                this.method_name_text.Text = "压缩比";
                this.result.Text = "质量分数";
            }
            else if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_SCORE)
            {
                this.method_name_text.Text = "质量分数";
                this.result.Text = "压缩比";
            }
            
        }

        //更新压缩程度/质量分数进度条对应的数值
        private void quality_bar_Scroll(object sender, EventArgs e)
        {
            method_size.Text = method_bar.Value.ToString();
        }

      

        private void compressForm_none_Load(object sender, EventArgs e)
        {
            //添加两个PictureBox作为图像容器
            PictureBox uncompressed_image = new PictureBox();
            PictureBox compressed_image = new PictureBox();
            int id = 0;
            for(int i=0;i<MainForm.tot;i++)
            {
                if(MainForm.selected[i])
                {
                    id = i; //获得被选中的图像的id，这里只选一张图片
                    break;
                }
            }
            string path = MainForm.path_name[id]; //获得被选图片路径
            Bitmap image = new Bitmap(path);
            int height = image.Height;
            int width = image.Width;
            int basement = height > width ? height : width;

            //左边未压缩图片的缩略图
            uncompressed_image.Height = (int)((double)height / basement * 160);
            uncompressed_image.Width = (int)((double)width / basement * 160);
            uncompressed_image.BorderStyle = BorderStyle.FixedSingle;
            uncompressed_image.ImageLocation = path;
            uncompressed_image.SizeMode = PictureBoxSizeMode.StretchImage;
            uncompressed_image.Anchor = AnchorStyles.None;
            uncompressed_image.Location = new Point((uncompressed.Width - uncompressed_image.Width) / 2, (uncompressed.Height - uncompressed_image.Height) / 2);
            uncompressed.Controls.Add(uncompressed_image);

            //右边已经压缩图片的缩略图
            compressed_image.Height = (int)((double)height / basement * 160);
            compressed_image.Width = (int)((double)width / basement * 160);
            compressed_image.BorderStyle = BorderStyle.FixedSingle;
            compressed_image.SizeMode = PictureBoxSizeMode.StretchImage;
            compressed_image.Anchor = AnchorStyles.None;
            compressed_image.Location = new Point((compressed.Width - compressed_image.Width) / 2, (compressed.Height - compressed_image.Height) / 2);
            compressed.Controls.Add(compressed_image);
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

                //保存压缩图片到本地，建议以后动态添加路径
                Pic image = new Pic(((PictureBox)(uncompressed.Controls[0])).ImageLocation);
                Bitmap new_image = new Bitmap(image.compress(method_bar.Value, 100, format_selection.Text));
                new_image.Save("F:\\测试图像\\compressed_image." + format_selection.Text, imageformat[format_selection.Text]);
                ((PictureBox)(compressed.Controls[0])).ImageLocation = "F:\\测试图像\\compressed_image." + format_selection.Text; //显示压缩后图片的缩略图
                Pic compress_image = new Pic("F:\\测试图像\\compressed_image." + format_selection.Text);
                result.Text = "质量分数：" + image.psnr(compress_image, image.height, image.width).ToString();
            }
            else if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_SCORE)
            {
                //保存压缩图片到本地，建议以后动态添加路径
                Pic image = new Pic(((PictureBox)(uncompressed.Controls[0])).ImageLocation);
                Bitmap new_image = new Bitmap(image.compress(method_bar.Value, 100, format_selection.Text));
                new_image.Save("F:\\测试图像\\compressed_image." + format_selection.Text, imageformat[format_selection.Text]);
                ((PictureBox)(compressed.Controls[0])).ImageLocation = "F:\\测试图像\\compressed_image." + format_selection.Text; //显示压缩后图片的缩略图
                Pic compress_image = new Pic("F:\\测试图像\\compressed_image." + format_selection.Text);
                result.Text = "压缩比：" +　image.psnr(compress_image, image.height, image.width).ToString();
            }

          
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Dispose();
        }
    }
}
