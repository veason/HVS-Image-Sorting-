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
        MainForm mf;
        string imagePath = "";
        public ImageDeleteComfirmForm()
        {
            InitializeComponent();
        }

        public ImageDeleteComfirmForm(int delete_rate, MainForm mf)
        {
            InitializeComponent();
            this.delete_rate = delete_rate;
            this.mf = mf;
            initTabPanel();
        }

        /**
         * 显示需要删除的图片
         */
        private void initTabPanel()
        {
            //images_to_be_deleted_panel

        }

        /**
         * 删除图片
         */
        private void comfirm_Click(object sender, EventArgs e)
        {
            //下面是删除左侧图片显示框中的所有图片，当有具体清除方案后可直接使用下面方法删除对应控件（如删除第i张图片）
            int n = MainForm.tot;//获取左侧显示框控件数目（全部是包含picturebox以及label的tablepannel）


            int i = n - (int)((double)n * delete_rate / 100);
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
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ImageDeleteComfirmForm_Load(object sender, EventArgs e)
        {
            TableLayoutColumnStyleCollection columnstyles = images_to_be_deleted_tablelayoutpanel.ColumnStyles;
            foreach (ColumnStyle style in columnstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Width = 150;
            }

            int n = MainForm.tot;
            int i = n - (int)((double)n * delete_rate / 100);
            for (; i < n; i++)
            {
                Panel p = new Panel();
                PictureBox image = new PictureBox();
                Label image_name = new Label();
                p.Dock = DockStyle.Fill;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                FileStream fs = new FileStream(MainForm.path_name[i], FileMode.Open, FileAccess.Read);
                Image bm = Image.FromStream(fs);
                int basement = bm.Height > bm.Width ? bm.Height : bm.Width;
                image.Height = (int)((double)bm.Height / basement * 150);
                image.Width = (int)((double)bm.Width / basement * 150);
                image.Image = Image.FromStream(fs);
                fs.Close();
                image_name.Height = 15;
                image_name.Width = image.Width;
                image_name.TextAlign = ContentAlignment.MiddleCenter;
                image_name.Font = new Font("宋体", 10);
                image_name.Text = MainForm.name[i];
                image.Anchor = AnchorStyles.None;
                image_name.Anchor = AnchorStyles.None;

                image.Location = new Point((p.Width - image.Width) / 2, (p.Height - 15 - image.Height) / 2);
                image_name.Location = new Point(image.Location.X, image.Location.Y + image.Height + 5);
                p.Controls.Add(image);
                p.Controls.Add(image_name);

                images_to_be_deleted_tablelayoutpanel.ColumnStyles.Insert(images_to_be_deleted_tablelayoutpanel.ColumnCount++, new ColumnStyle(SizeType.Absolute, 150));
                images_to_be_deleted_tablelayoutpanel.Controls.Add(p);
            }
            this.Refresh();
        }
    }
}
