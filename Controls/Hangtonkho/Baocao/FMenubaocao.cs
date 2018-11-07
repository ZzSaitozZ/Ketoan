using Ketoan.Controls.DungChung.Menu;
using System.Windows.Forms;

namespace Ketoan.Controls.HangTonKho.BaoCao
{
    public partial class FMenuBaoCao : Form
    {
        public FMenuBaoCao(string a)
        {
            InitializeComponent();
            load_table(a);
        }

        private void load_table(string a)
        {
            EDCM2 u1 = new EDCM2(a)
            {
                Dock = DockStyle.Fill
            };
            panelDetail.Controls.Add(u1);
        }

        private void FMenuBaoCao_Load(object sender, FormClosingEventArgs e)
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
