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
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace UI
{
    public partial class CompressForm_none : Form
    {
        public string _path;
        public string _name;
        Dictionary<string, ImageFormat> imageformat = new Dictionary<string,ImageFormat>(); //图像格式字符串映射到c#库的图像格式的索引表
        public CompressForm_none(string _path,string _name)
        {
            InitializeComponent();
            this._path = _path;
            this._name = _name;
            imageformat["jpeg"] = ImageFormat.Jpeg;
            imageformat["png"] = ImageFormat.Png;
            imageformat["bmp"] = ImageFormat.Bmp;
            imageformat["gif"] = ImageFormat.Gif;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            SettingInfo.SELECT_COMPRESS_METHOD = SettingInfo.SELECT_COMPRESS_RATE;
        }

        //更新压缩程度/质量分数进度条对应的数值
        private void rate_bar1_Scroll(object sender, EventArgs e)
        {
            rate1.Text = rate_bar1.Value.ToString();
        }
        private void rate_bar2_Scroll(object sender, EventArgs e)
        {
            rate1.Text = rate_bar2.Value.ToString();
        }
        private void compressForm_none_Load(object sender, EventArgs e)
        {
            picturePanel p1 = new picturePanel();
            uncompressed.Controls.Add(p1);
            p1.init(MainForm.picInfo[_path].image, _name);
            picturePanel p2 = new picturePanel();
            compressed.Controls.Add(p2);
        }
        private void comfirm_Click(object sender, EventArgs e)
        {
            if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_RATE)
            {
                if (rate_bar1.Value == 0)
                {
                    MessageBox.Show("压缩率不能为0!");
                    return;
                }
                Bitmap new_image = new Bitmap(MainForm.picInfo[_path].compress(rate_bar1.Value, 100, format_selection.Text));
                new_image.Save("压缩图像\\" + _name + "compressed_image." + format_selection.Text, imageformat[format_selection.Text]);
                ((picturePanel)(compressed.Controls[0])).init(new_image, _name);
            }
            else if (SettingInfo.SELECT_COMPRESS_METHOD == SettingInfo.SELECT_COMPRESS_SCORE)
            {
                if (rate_bar2.Value == 0)
                {
                    MessageBox.Show("质量分数不能为0!");
                    return;
                }
                int T = 10;
                int l = 0, r = 100, mid = (l + r) / 2;
                double baseGrade = MainForm.picInfo[_path].tenengrad();
                for(int i= 0 ; i < T; i++)
                {
                    mid = (l + r) / 2;
                    Bitmap temp = new Bitmap(MainForm.picInfo[_path].compress(mid, 100, format_selection.Text));
                    string image_path = "压缩图像\\temp" + i.ToString() + _name + "compressed_image." + format_selection.Text;
                    temp.Save(image_path, imageformat[format_selection.Text]);
                    Pic pic = new Pic(image_path);
                    double grade = pic.tenengrad();
                    if (grade / baseGrade * 100 > rate_bar2.Value)
                    {
                        r = mid;
                    }
                    else
                    {
                        l = mid;
                    }
                    pic.image.Dispose();
                    temp.Dispose();
                    if (File.Exists(image_path))
                    {
                        FileSystem.DeleteFile(image_path, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
                    }
                }
                Bitmap new_image = new Bitmap(MainForm.picInfo[_path].compress(mid, 100, format_selection.Text));
                new_image.Save("压缩图像\\" + _name + "compressed_image." + format_selection.Text, imageformat[format_selection.Text]);
                ((picturePanel)(compressed.Controls[0])).init(new_image, _name);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Dispose();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            SettingInfo.SELECT_COMPRESS_METHOD = SettingInfo.SELECT_COMPRESS_RATE;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            SettingInfo.SELECT_COMPRESS_METHOD = SettingInfo.SELECT_COMPRESS_SCORE;
        }
    }
}