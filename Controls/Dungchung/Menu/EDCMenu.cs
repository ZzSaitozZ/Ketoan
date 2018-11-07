using Ketoan.Controls.BanHangPhaiThu;
using Ketoan.Controls.KeToanTongHop;
using System.Windows.Forms;

namespace Ketoan.Controls.DungChung.Menu
{
    public partial class EDCMenu : UserControl
    {
        public EDCMenu()
        {


        }

        public EDCMenu(string tungay, string denngay, string loaibaocao)
        {
            InitializeComponent();
            load_table(tungay, denngay, loaibaocao);
        }
        private void load_table(string tungay, string denngay, string loaibaocao)
        {
            switch (loaibaocao)
            {
                case "Báo cáo doanh thu bán hàng":
                    {
                        BaoCaoDoanhThu u4 = new BaoCaoDoanhThu(tungay, denngay)
                        {
                            Dock = DockStyle.Fill
                        };
                        panel1.Controls.Add(u4);
                        break;
                    }
            }
        }
        public EDCMenu(string a)
        {
            InitializeComponent();
            ButToanKetChuyen u1 = new ButToanKetChuyen
            {
                Dock = DockStyle.Fill
            };
            //  panel1.Controls.Add(u1);
            load_table(a);
        }
        private void load_table(string table)
        {
            switch (table)
            {
                case "btkc":
                    ButToanKetChuyen u1 = new ButToanKetChuyen
                    {
                        Dock = DockStyle.Fill
                    };
                    panel1.Controls.Add(u1);
                    break;
            }
        }
    }
}