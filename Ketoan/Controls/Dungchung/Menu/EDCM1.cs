using Ketoan.Controls.KeToanTongHop;
using System.Windows.Forms;

namespace Ketoan.Controls.DungChung.Menu
{
    public partial class EDCM1 : UserControl
    {
        public EDCM1()
        {

        }

        public EDCM1(string a)
        {
            InitializeComponent();
            load_table(a);
        }

        private void load_table(string table)
        {
            switch (table)
            {
                case "btcn":
                    {
                        PhieuKeToanKhac u1 = new PhieuKeToanKhac
                        {
                            Dock = DockStyle.Fill
                        };
                        panel1.Controls.Add(u1);
                        break;
                    }
            }

        }
    }
}