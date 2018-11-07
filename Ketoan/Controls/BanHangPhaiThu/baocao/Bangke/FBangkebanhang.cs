
using Ketoan.Controls.DungChung.Menu;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu.BaoCao.BangKe
{
    public partial class FBangKeBanHang : Form
    {
        public FBangKeBanHang(string tungay, string denngay, string baocao)
        {
            InitializeComponent();
            EDCMenu f = new EDCMenu(tungay, denngay, baocao)
            {
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(f);
        }
    }
}
