using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class EDCHoaDon : Form
    {
        public EDCHoaDon()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ChiTietChungTuHoaDonBanHang u1 = new ChiTietChungTuHoaDonBanHang
            {
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(u1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            EDCChiTietNghiepVu u1 = new EDCChiTietNghiepVu
            {
                Dock = DockStyle.Fill
            };
            panel3.Controls.Add(u1);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            EDCChiTietNghiepVu u1 = new EDCChiTietNghiepVu
            {
                Dock = DockStyle.Fill
            };
            panel4.Controls.Add(u1);
        }
    }
}
