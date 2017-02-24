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
        sortObject[] sortArray;

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
        public ImageDeleteComfirmForm(int delete_rate, MainForm mf, sortObject[] sortArray)
        {
            InitializeComponent();
            this.delete_rate = delete_rate;
            this.mf = mf;
            this.sortArray = sortArray;
            initTabPanel();
        }

        /*
         * 显示需要删除的图片
         */
        private void initTabPanel()
        {
            //images_to_be_deleted_panel
        }

        /*
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
                    MainForm.picInfo[imagePath].image.Dispose();
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
            int n = MainForm.tot;
            int i = n - (int)((double)n * delete_rate / 100);
            int tot = 0;
            for (; i < n; i++,tot++)
            {
                picturePanel p = new picturePanel();
                if (tot % 4 == 0)
                {
                    result.RowStyles.Insert(result.RowCount++, new RowStyle());
                }
                result.Controls.Add(p, tot % 4, tot / 4);
                p.init(MainForm.picInfo[MainForm.path_name[i]].image, "质量分数：" + (sortArray[i].grade / sortArray[0].grade * 100).ToString("f2"));
            }
            TableLayoutRowStyleCollection rowstyles;
            rowstyles = result.RowStyles;
            foreach (RowStyle style in rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = result.Width / 4 - 20;
            }
            this.Refresh();
        }
    }
}
