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
    public partial class FloatForm : Form
    {
        Bitmap bmp;
        Bitmap background;
        Graphics g;
        
        float x = 0;
        public FloatForm()
        {
            InitializeComponent();
            loading();
        }
        private void FloatForm_Load(object sender, EventArgs e)
        {
            
            
        }
         string strDraw;

         public FloatForm(string str) : this()
        {
            strDraw = str;
        }

         private void loading()
         {
            
             bmp = new Bitmap("E:/picture/sucai/MainIcon.ico");
             background = new Bitmap(pictureBox.Width, pictureBox.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);//画在PictureBox上
             g = Graphics.FromImage(background);
             g.TranslateTransform(background.Width / 2, background.Height / 2);//移动一下中心点，画在背景的中央，好看些

             Timer.Interval = 100;

             Timer.Enabled = true;

         }

         void Timer_Tick(object sender, EventArgs e)
         {

             // g.Clear(Color.White);
             g.Clear(Color.FromArgb(92, 200, 249));
             g.RotateTransform(10.0F);//每次旋转10度，实际上是画图坐标旋转
             g.DrawImage(bmp, -bmp.Width / 2, -bmp.Height / 2);//源图中心点和画图对象中心重合，自旋转效果，否则会以左上角为中心旋转
             Graphics gb = pictureBox.CreateGraphics();
             //x += 3.0f;//水平移动效果，步长3像素
             gb.DrawImage(background, x, 0.0f);

         }
       
    }
}
