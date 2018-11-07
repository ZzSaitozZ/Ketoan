using Ketoan.Controls.DungChung.Menu;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class FBaoCaoMuaHang : Form
    {
        public FBaoCaoMuaHang(string a)
        {
            InitializeComponent();
            load_table(a);
        }

        private void load_table(string table)
        {
            switch (table)
            {
                case "bcmh":
                    {
                        string a = "bcmh";
                        EDCM2 u1 = new EDCM2(a)
                        {
                            Dock = DockStyle.Fill
                        };
                        panel1.Controls.Add(u1);
                        break;
                    }
            }
        }

        private void FBaoCaoMuaHang_FormClosing(object sender, FormClosingEventArgs e)
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
