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
        public string _path;
        private const int size = 195;
        public SortingResult()
        {
            InitializeComponent();
            _path = null;
        }
        public SortingResult(string _path)
        {
            InitializeComponent();
            this._path = _path;
        }

        private void SortingResult_Load(object sender, EventArgs e)
        {
            if(_path != null)
            {
                picturePanel p = new picturePanel();
                referenceImage.Controls.Add(p);
                p.init(MainForm.picInfo[_path].image,null);
                hint.Text = "全参考排序参考图";
            }
            TableLayoutColumnStyleCollection columnstyles = beforeSortingPanel.ColumnStyles;
            foreach (ColumnStyle style in columnstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Width = size;
            }
            columnstyles = afterSortingPanel.ColumnStyles;
            foreach (ColumnStyle style in columnstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Width = size;
            }

            for (int i = 0; i < MainForm.tot; i++)
            {
                picturePanel p = new picturePanel();
                beforeSortingPanel.ColumnStyles.Insert(beforeSortingPanel.ColumnCount++, new ColumnStyle(SizeType.Absolute, size));
                beforeSortingPanel.Controls.Add(p, i, 0);
                p.init(MainForm.picInfo[MainForm.path_name_copy[i]].image, MainForm.name_copy[i]);
            }

            for (int i = 0; i < MainForm.tot; i++)
            {
                picturePanel p = new picturePanel();
                afterSortingPanel.ColumnStyles.Insert(afterSortingPanel.ColumnCount++, new ColumnStyle(SizeType.Absolute, size));
                afterSortingPanel.Controls.Add(p, i, 0);
                p.init(MainForm.picInfo[MainForm.path_name[i]].image, MainForm.name[i]);
            }
        }
    }
}
