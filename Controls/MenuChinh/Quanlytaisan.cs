using System.Windows.Forms;

namespace Ketoan.Controls.MenuChinh
{
    public partial class QuanLyTaiSan : UserControl
    {
        public QuanLyTaiSan()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void galleryControl2_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            string MenuBtn = string.Format("{0}", e.Item.Tag);
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.showFormDanhMuc(MenuBtn);
        }
    }
}
