using Ketoan.Controls.DungChung.Menu;
using System.Windows.Forms;

namespace Ketoan.Controls.KeToanTongHop
{
    public partial class FBuTruCongNo : Form
    {
        public FBuTruCongNo()
        {
            //  InitializeComponent();
        }

        public FBuTruCongNo(string a)
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
                        EDCM1 u1 = new EDCM1(table)
                        {
                            Dock = DockStyle.Fill
                        };
                        panelDetails.Controls.Add(u1);
                        break;
                    }
            }
        }

        private void FBuTruCongNo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k--;
            if (s.k == 0)
            {
                frm1.Show();
            }
        }
    }
}
