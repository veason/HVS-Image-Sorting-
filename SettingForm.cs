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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            this.image_clean_full_combobox.SelectedIndex = SettingInfo.image_clean_full_selected;
            this.image_clean_none_combobox.SelectedIndex = SettingInfo.image_clean_none_selected;
            this.image_compress_full_combobox.SelectedIndex = SettingInfo.image_compress_full_selected;
            this.image_compare_none_combobox.SelectedIndex = SettingInfo.image_compare_none_selected;
            this.image_sort_full_combobox.SelectedIndex = SettingInfo.image_sort_full_selected;
            this.image_sort_none_combobox.SelectedIndex = SettingInfo.image_sort_none_selected;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            SettingInfo.image_clean_full = image_clean_full_combobox.Text;
            SettingInfo.image_clean_none = image_clean_none_combobox.Text;
            SettingInfo.image_compress_full = image_compress_full_combobox.Text;
            SettingInfo.image_compare_none = image_compare_none_combobox.Text;
            SettingInfo.image_sort_full = image_sort_full_combobox.Text;
            SettingInfo.image_sort_none = image_sort_none_combobox.Text;

            SettingInfo.image_clean_full_selected = this.image_clean_full_combobox.SelectedIndex;
            SettingInfo.image_clean_none_selected = this.image_clean_none_combobox.SelectedIndex;
            SettingInfo.image_compress_full_selected = this.image_compress_full_combobox.SelectedIndex;
            SettingInfo.image_compare_none_selected = this.image_compare_none_combobox.SelectedIndex;
            SettingInfo.image_sort_full_selected = this.image_sort_full_combobox.SelectedIndex;
            SettingInfo.image_sort_none_selected = this.image_sort_none_combobox.SelectedIndex;
            Dispose();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
