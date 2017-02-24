using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class SelectCompressForm : Form
    {
        public SelectCompressForm()
        {
            InitializeComponent();
        }

        /*
        private void to_compress_rate_Click(object sender, EventArgs e)
        {
            Dispose();
            SettingInfo.SELECT_COMPRESS_METHOD = SettingInfo.SELECT_COMPRESS_RATE;
            if (MainForm.COMPRESS_SELECTED == SettingInfo.SELECT_COMPRESS_FULL) 
            {
                CompressForm_full cf_full = new CompressForm_full(); //弹出图片压缩参数设置窗口
                cf_full.Show();
            }else if(MainForm.COMPRESS_SELECTED == SettingInfo.SELECT_COMPRESS_NONE)
            {
                 CompressForm_none cf_none = new CompressForm_none(); //弹出图片压缩参数设置窗口
                 cf_none.Show();
            }
        }

        private void to_compress_score_Click(object sender, EventArgs e)
        {
            Dispose();
            SettingInfo.SELECT_COMPRESS_METHOD = SettingInfo.SELECT_COMPRESS_SCORE;
            if (MainForm.COMPRESS_SELECTED == SettingInfo.SELECT_COMPRESS_FULL) {
                CompressForm_full cf_full = new CompressForm_full(); //弹出图片压缩参数设置窗口
                cf_full.Show();
            }else if(MainForm.COMPRESS_SELECTED == SettingInfo.SELECT_COMPRESS_NONE){
                CompressForm_none cf_none = new CompressForm_none(); //弹出图片压缩参数设置窗口
                cf_none.Show();

            }
        }
         */
    }
}
