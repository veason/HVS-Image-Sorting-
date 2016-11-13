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
    public partial class ClearSetting : Form
    {
        public ClearSetting()
        {
            InitializeComponent();
        }

        public ClearSetting(MainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
        }

        private void clearRatioBar_Scroll(object sender, EventArgs e)
        {
            ratio.Text = clearRatioBar.Value.ToString() + "%";
            MainForm.clear_ratio = clearRatioBar.Value;
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            ImageDeleteComfirmForm imageDeleteComfirmForm = new ImageDeleteComfirmForm(clearRatioBar.Value, mf);
            imageDeleteComfirmForm.Show();

        }
    }
}
