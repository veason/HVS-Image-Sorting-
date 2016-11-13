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
    public partial class SortingResult : Form
    {
        public SortingResult()
        {
            InitializeComponent();
        }

        private void SortingResult_Load(object sender, EventArgs e)
        {
            TableLayoutColumnStyleCollection columnstyles = beforeSortingPanel1.ColumnStyles;
            foreach (ColumnStyle style in columnstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Width = 110;
            }
            columnstyles = afterSortingPanel1.ColumnStyles;
            foreach (ColumnStyle style in columnstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Width = 110;
            }

            int n = MainForm.tot;
            n = 5;
            //int[] a = new int[] { 1, 4, 5, 2, 10, 3, 11, 0, 7, 6, 8, 9 };
            int[] a = new int[] { 1, 4,2,0,3 };

            for (int j = 0; j < n; j++)
            {
                int i = a[j];
                Panel p = new Panel();
                PictureBox image = new PictureBox();
                Label image_name = new Label();
                p.Dock = DockStyle.Fill;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                FileStream fs = new FileStream(MainForm.path_name_copy[i], FileMode.Open, FileAccess.Read);
                Image bm = Image.FromStream(fs);
                int basement = bm.Height > bm.Width ? bm.Height : bm.Width;
                image.Height = (int)((double)bm.Height / basement * 100);
                image.Width = (int)((double)bm.Width / basement * 100);
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

                beforeSortingPanel1.ColumnStyles.Insert(beforeSortingPanel1.ColumnCount++, new ColumnStyle(SizeType.Absolute, 130));
                beforeSortingPanel1.Controls.Add(p, j, 0);
            }

            for (int i = 0; i < n; i++)
            {
                /*
                Panel p = new Panel();
                PictureBox image = new PictureBox();
                Label image_name = new Label();
                p.Anchor = AnchorStyles.None;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                FileStream fs = new FileStream(MainForm.path_name[i], FileMode.Open, FileAccess.Read);
                Image bm = Image.FromStream(fs);
                int basement = bm.Height > bm.Width ? bm.Height : bm.Width;
                image.Height = (int)((double)bm.Height / basement * 100);
                image.Width = (int)((double)bm.Width / basement * 100);
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

                afterSortingPanel1.ColumnStyles.Insert(afterSortingPanel1.ColumnCount++, new ColumnStyle(SizeType.Absolute, 130));
                afterSortingPanel1.Controls.Add(p, i, 0);
                */

                Panel p = new Panel();
                PictureBox image = new PictureBox();
                Label image_name = new Label();
                p.Dock = DockStyle.Fill;
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                FileStream fs = new FileStream(MainForm.path_name_copy[i], FileMode.Open, FileAccess.Read);
                Image bm = Image.FromStream(fs);
                int basement = bm.Height > bm.Width ? bm.Height : bm.Width;
                image.Height = (int)((double)bm.Height / basement * 100);
                image.Width = (int)((double)bm.Width / basement * 100);
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

                afterSortingPanel1.ColumnStyles.Insert(afterSortingPanel1.ColumnCount++, new ColumnStyle(SizeType.Absolute, 130));
                afterSortingPanel1.Controls.Add(p, i, 0);
            }
        }
    }
}
