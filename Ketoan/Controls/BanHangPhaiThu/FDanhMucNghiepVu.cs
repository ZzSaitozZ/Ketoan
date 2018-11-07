using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class FDanhMucNghiepVu : DevExpress.XtraEditors.XtraForm
    {
        public FDanhMucNghiepVu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            EUDMNV u1 = new EUDMNV
            {
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(u1);
        }
    }
}