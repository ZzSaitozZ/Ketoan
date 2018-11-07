using Ketoan.Controls.BanHangPhaiThu.BaoCao;
using Ketoan.Controls.HangTonKho.BaoCao;
using Ketoan.Controls.HangTonKho.PhieuXuatBan;
using Ketoan.Controls.HangTonKho.PhieuXuatKhoThanhPham;
using System.Windows.Forms;

namespace Ketoan.Controls.DungChung.Menu
{
    public partial class EDCM2 : UserControl
    {
        public EDCM2()
        {

        }

        public EDCM2(string a)
        {
            InitializeComponent();
            load_table(a);
        }

        private void load_table(string table)
        {
            switch (table)
            {
                case "Pxb":
                    {
                        PhieuXuatBan u1 = new PhieuXuatBan
                        {
                            Dock = DockStyle.Fill
                        };
                        panel1.Controls.Add(u1);
                        break;
                    }
                case "pntp":
                    {
                        PhieuXuatKhoTp u2 = new PhieuXuatKhoTp
                        {
                            Dock = DockStyle.Fill
                        };
                        panel1.Controls.Add(u2);
                        break;
                    }
                case "BaoCao":
                    {
                        BaoCao u3 = new BaoCao
                        {
                            Dock = DockStyle.Fill
                        };
                        panel1.Controls.Add(u3);
                        break;
                    }
                case "bcmh":
                    {
                        MenuBaoCao u4 = new MenuBaoCao
                        {
                            Dock = DockStyle.Fill
                        };
                        panel1.Controls.Add(u4);
                        break;
                    }
            }
        }
    }
}