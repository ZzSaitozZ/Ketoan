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
    public partial class Vonbangtien : UserControl
    {
        public Vonbangtien()
        {
            InitializeComponent();
        }

        private void galleryControl2_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            string value = string.Format("{0}", e.Item.Value);
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k++;
            if (value.Contains("0"))
            {
                string a = "DMBP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục bộ phận";
                frm.Show();
                frm1.Hide();
            }
            else if(value.Contains("1"))
            {
                string a = "DMDT";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục đối tượng";
                frm.Show();
                frm1.Hide();

            }
            
        }
    }
}
