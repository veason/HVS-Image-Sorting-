using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI
{
    public class SettingInfo
    {
        /**
         *
         * 用户设置的方法
         * 赋值为默认值
         */
        public static string image_clean_full = "image_clean_full_algorithm_1";
        public static string image_clean_none = "image_clean_none_algorithm_1";
        public static string image_compress_full = "image_compress_full_algorithm_1";
        public static string image_compare_none = "image_compare_none_algorithm_1";
        public static string image_sort_full = "image_sort_full_algorithm_1";
        public static string image_sort_none = "image_sort_none_algorithm_1";

        public static int image_clean_full_selected = 0;
        public static int image_clean_none_selected = 0;
        public static int image_compress_full_selected = 0;
        public static int image_compare_none_selected = 0;
        public static int image_sort_full_selected = 0;
        public static int image_sort_none_selected = 0;




        /**
         * 
         */
        public static int SELECT_COMPRESS_FULL = 1;
        public static int SELECT_COMPRESS_NONE = 2;
        public static int SELECT_COMPRESS_METHOD;
        public static int SELECT_COMPRESS_SCORE = 4;
        public static int SELECT_COMPRESS_RATE = 5;


    }
}
