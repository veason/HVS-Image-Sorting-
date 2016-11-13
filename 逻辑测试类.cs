using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace demo1
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Pic image1 = new Pic("F://测试图像/1.png");
            Pic image2 = new Pic("F://测试图像/-1.png");
            Pic test1 = new Pic("F://测试图像/test1.jpg");
            Pic test2 = new Pic("F://测试图像/test2.jpg");
            Pic test3 = new Pic("F://测试图像/test3.jpg");
            Pic test4 = new Pic("F://测试图像/test4.jpg");
            Pic test5 = new Pic("F://测试图像/test5.jpg");
            Console.WriteLine(image1.psnr(image2, 100, 100));
            Console.WriteLine(test1.tenengrad());
            Console.WriteLine(test2.tenengrad());
            Console.WriteLine(test3.tenengrad());
            Console.WriteLine(test4.tenengrad());
            Console.WriteLine(test5.tenengrad());
            Pic[] im = new Pic[6];
            for (int i = 0; i<6;i++ )
            {
                im[i] = new Pic("F://测试图像/" + i.ToString() + ".png");
                im[i].grade = im[i].tenengrad();
            }
            Array.Sort(im, new PicComparer());
            for (int i = 0;i<6 ;i++ )
            {
                Console.WriteLine(im[i].path + "  " + im[i].grade);
            }
            Bitmap bm = new Bitmap(test2.compress(100, 100));
            bm.Save("F://测试图像/tt.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Pic image = new Pic("F://测试图像/tt.jpg");
            Console.WriteLine(image.tenengrad());
            Console.WriteLine(test2.psnr(image, 100, 100));
            Console.ReadLine();
        }
        */
    }
}
