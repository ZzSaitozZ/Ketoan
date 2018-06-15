﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls
{
    public partial class Muahangphaitra : UserControl
    {
        public Muahangphaitra()
        {
            InitializeComponent();
        }
        private void galleryControl2_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            string value = string.Format("{0}", e.Item.Value);
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k++;
            if (value.Contains("9"))
            {
                string a = "DMNV";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nghiệp vụ";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("10"))
            {
                string a = "DMTK";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục tài khoản";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("11"))
            {
                string a = "DMNHDT";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm đối tượng";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("12"))
            {
                string a = "DMBP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục bộ phận";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("13"))
            {
                string a = "DMBP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục bộ phận";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("14"))
            {
                string a = "DMKHO";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục kho";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("15"))
            {
                string a = "DMKV";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục khu vực";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("16"))
            {
                string a = "DMTHUE";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục thuế";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("17"))
            {
                string a = "DMVT";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục vật tư";
                frm.Show();
                frm1.Hide();
            }
            
        }
    }
}
