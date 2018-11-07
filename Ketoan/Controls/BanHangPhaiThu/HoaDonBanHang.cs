using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class HoaDonBanHang : UserControl
    {
        public HoaDonBanHang()
        {
            InitializeComponent();
            ChungTuHoaDonBanHang u1 = new ChungTuHoaDonBanHang
            {
                //  u1.TopLevel = false;
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(u1);
        }
    }
}