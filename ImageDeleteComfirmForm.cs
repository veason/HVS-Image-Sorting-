using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Threading.Tasks;
using CCWin;
using System.Threading;
using System.IO;
using System.Collections;

namespace UI
{
    public partial class ImageDeleteComfirmForm : Form
    {
        int delete_rate;
        private const double size_rate = 0.9;
        MainForm mf;
        string imagePath = "";
        sortObject[] sortedArray;
        string[] picList;
        EventHandler e1; //双击单元格打开图片查看器
        EventHandler e2; //双击单元格打开图片查看器
        EventHandler e3; //双击单元格打开图片查看器

        public ImageDeleteComfirmForm()
        {
            InitializeComponent();
            e1 = new EventHandler(item_double_click);
            e2 = new EventHandler(pictureBox_double_click);
            e3 = new EventHandler(label_double_click);
        }

        public ImageDeleteComfirmForm(int delete_rate, MainForm mf, sortObject[] sortedArray)
        {
            InitializeComponent();
            this.delete_rate = delete_rate;
            this.mf = mf;
            this.sortedArray = sortedArray;
            e1 = new EventHandler(item_double_click);
            e2 = new EventHandler(pictureBox_double_click);
            e3 = new EventHandler(label_double_click);
        }


        /*
         * 删除图片
         */
        private void comfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < picList.Length; i++)
            {
                imagePath = picList[i];
                if (File.Exists(imagePath))
                {
                    MainForm.picInfo[imagePath].image.Dispose();
                    FileSystem.DeleteFile(imagePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
                for (int j = 0; j < MainForm.tot; j++)
                {
                    if (MainForm.path_name[j] == imagePath)
                    {
                        MainForm.imageToDelete[j] = true;
                        break;
                    }
                }
            }
            mf.delete();
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ImageDeleteComfirmForm_Load(object sender, EventArgs e)
        {
            this.Width = (int)(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width * size_rate);
            this.Height = (int)(this.Width * 0.45);
            this.Location = new Point((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 3 * 2, (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 3 * 2);
            result.Width = (int)(this.Width * 0.9);
            result.Height = (int)(result.Width / 4);
            result.Location = new Point((int)(this.Width * 0.05), (int)(this.Height * 0.1));
            hint.Location = new Point((int)(this.Width * 0.43), (int)(this.Height * 0.65));
            confirm.Location = new Point((int)(this.Width * 0.37), (int)(this.Height * 0.82));
            cancel.Location = new Point((int)(this.Width * 0.57), (int)(this.Height * 0.82));

            int n = sortedArray.Length;
            int i = n - (int)((double)n * delete_rate / 100);
            int tot = 0;
            picList = new string[n - i];
            for (; i < n; i++)
            {
                picturePanel p = new picturePanel(tot);
                if (tot % 4 == 0 && tot != 0)
                {
                    result.RowStyles.Insert(result.RowCount++, new RowStyle());
                }
                result.Controls.Add(p, tot % 4, tot / 4);
                p.init(MainForm.picInfo[sortedArray[i].path].image, "质量分数：" + (sortedArray[i].grade / sortedArray[0].grade * 100).ToString("f2"));
                p.DoubleClick += e1;
                ((PictureBox)(p.Controls[0])).DoubleClick += e2;
                ((Label)(p.Controls[1])).DoubleClick += e3;
                picList[tot++] = sortedArray[i].path;
            }
            TableLayoutRowStyleCollection rowstyles;
            rowstyles = result.RowStyles;
            foreach (RowStyle style in rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = result.Height - 4;
            }
            this.Refresh();
        }

        //双击单元格
        private void item_double_click(object sender, EventArgs e)
        {
            picturePanel p = (picturePanel)sender;
            int position = p.id;
            Form imageshow = new ImageView(picList, position);
            imageshow.Size = new Size(1024, 800);//新窗口界面大小和原窗口同样大
            imageshow.Show();
        }

        //双击图片
        private void pictureBox_double_click(object sender, EventArgs e)
        {
            PictureBox curPicture = (PictureBox)(sender);
            picturePanel p = (picturePanel)(curPicture.Parent);
            int position = p.id;
            Form imageshow = new ImageView(picList, position);
            imageshow.Size = new Size(1024, 800);//新窗口界面大小和原窗口同样大
            imageshow.Show();
        }

        //双击文字
        private void label_double_click(object sender, EventArgs e)
        {
            picturePanel p = (picturePanel)(((Label)sender).Parent);
            int position = p.id;
            Form imageshow = new ImageView(picList, position);
            imageshow.Size = new Size(1024, 800);//新窗口界面大小和原窗口同样大
            imageshow.Show();
        }

        private void ImageDeleteComfirmForm_Resize(object sender, EventArgs e)
        {
            result.Width = (int)(this.Width * 0.9);
            result.Height = (int)(result.Width / 4);
            result.Location = new Point((int)(this.Width * 0.05), (int)(this.Height * 0.1));
            hint.Location = new Point((int)(this.Width * 0.43), (int)(this.Height * 0.65));
            confirm.Location = new Point((int)(this.Width * 0.37), (int)(this.Height * 0.82));
            cancel.Location = new Point((int)(this.Width * 0.57), (int)(this.Height * 0.82));
            TableLayoutRowStyleCollection rowstyles;
            rowstyles = result.RowStyles;
            foreach (RowStyle style in rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = result.Height - 4;
            }
        }
    }
}
