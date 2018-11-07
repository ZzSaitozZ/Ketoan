using Ketoan.Controls.DungChung.Menu;
using System.Windows.Forms;

namespace Ketoan.Controls.HangTonKho.BaoCao.BangKe
{
    public partial class FBangKeXuatBan : Form
    {
        public FBangKeXuatBan(string tungay, string denngay, string baocao)
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
