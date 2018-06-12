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
            Form1 frm = new Form1();
            Form frm1 = Application.OpenForms["StartForm"];
            if (value.Contains("0"))
                frm.Show();
                frm1.Hide();                
        }
    }
}
