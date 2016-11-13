using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.IO;
namespace UI
{
    public partial class ImageView : Form
    {
        private int position;
        public ImageView()
        {
            InitializeComponent();
           
        }
        
        //显示第一张图片
        private void ImageView_Load(object sender, EventArgs e)
        {
            //控制图片大小以及按钮大小
            int formWidth=this.Width;
            int formHeight=this.Height;
            int height = (int)(((double)formHeight - 50) / 2-25);
            position = 0;
            string path = MainForm.path_name[position];
            this.tableLayoutPanel1.Width = formWidth;
            this.tableLayoutPanel1.Height = formHeight;
            this.imageButton1.Margin = new Padding(0, height, 0, 0);
            this.imageButton1.Height = 50;
            this.imageButton2.Margin = new Padding(0, height, 0, 0);
            this.imageButton2.Height = 50;
          //  this.imageButton1.Height = formHeight;
          //  this.imageButton2.Height= formHeight;
            

            //窗口名称是当前图片名称
            string name= "";
            name = path;
            string[] sArray = path.Split( '\\');
            name = sArray[sArray.Length - 1];
            this.Text = name;

            //将第一张图片添加到picturebox
            PictureBox image = this.pictureBox1;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            image.Image = Image.FromStream(fs);
            this.imageButton1.Visible = false;
            
        }

        //窗口大小自适应
        private void ImageView_Resize(object sender, EventArgs e) 
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
           int height=(int)(((double)formHeight-50)/2-25);
            //设置左部整个pannel与窗体大小一致，并设置两个上下按钮高度与窗口高度一致
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Width = formWidth;
            this.tableLayoutPanel1.Height = formHeight;
            
            this.imageButton1.Margin = new Padding(0, height, 0, 0);
            this.imageButton1.Height = 50;
            this.imageButton2.Margin = new Padding(0, height, 0, 0);
            this.imageButton2.Height = 50;
            //this.imageButton2.Height = formHeight;
 
        }

        //上一张图片
        private void imageButton1_Click(object sender, EventArgs e)
        {
            //position指第几张图片，0~length-1
            if (position < 0)
            {
                this.imageButton1.Visible = false;
            }
            else
            {
                position--;
                if (position < MainForm.tot-1)
                    this.imageButton2.Visible = true;
                string path = MainForm.path_name[position];
                string name = "";
                name = path;
                string[] sArray = path.Split('\\');
                name = sArray[sArray.Length - 1];
                this.Text = name;
                PictureBox image = this.pictureBox1;
              
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                image.Image = Image.FromStream(fs);
                if (position <= 0)
                {
                    this.imageButton1.Visible = false;

                }
            }
           }

        //下一张图片
        private void imageButton2_Click(object sender, EventArgs e)
        {
            
            if(position>=MainForm.tot-1)
            {
                this.imageButton2.Visible=false;
            }else
            {
                position++;
                if(position>=0)
                    this.imageButton1.Visible = true;
                string path = MainForm.path_name[position];
                string name = "";
                name = path;
                string[] sArray = path.Split('\\');
                name = sArray[sArray.Length - 1];
                this.Text = name;
                PictureBox image = this.pictureBox1;
                
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                image.Image = Image.FromStream(fs);
                if (position>=MainForm.tot-1)
                {
                    this.imageButton2.Visible = false;
                }
            }
           

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

    }
}
