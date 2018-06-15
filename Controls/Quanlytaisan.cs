using System;
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
    public partial class Quanlytaisan : UserControl
    {
        public Quanlytaisan()
        {
            InitializeComponent();
        }
        private void galleryControl2_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            string value = string.Format("{0}", e.Item.Value);
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k++;
            if (value.Contains("5"))
            {
                string a = "DMNV";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nghiệp vụ";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("6"))
            {
                string a = "DMTK";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục tài khoản";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("7"))
            {
                string a = "DMNHDT";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm đối tượng";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("8"))
            {
                string a = "DMBP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục bộ phận";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("10"))
            {
                string a = "DMKM";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục khoản mục";
                frm.Show();
                frm1.Hide();
            }
            else if (value.Contains("11"))
            {
                string a = "DMNHVT";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm vật tư";
                frm.Show();
                frm1.Hide();
            }

        }
    }
}
