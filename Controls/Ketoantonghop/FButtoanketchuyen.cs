using Ketoan.Controls.DungChung.Menu;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.KeToanTongHop
{
    public partial class FButToanKetChuyen : Form
    {
        public FButToanKetChuyen()
        {
            //  InitializeComponent();
        }

        public FButToanKetChuyen(string a)
        {
            InitializeComponent();
            load_table(a);
        }

        private void load_table(string table)
        {
            switch (table)
            {

                case "btkc":
                    {
                        EDCMenu u1 = new EDCMenu(table)
                        {
                            Dock = DockStyle.Fill
                        };
                        panelDetails.Controls.Add(u1);
                        break;
                    }
            }

        }

        private void FButToanKetChuyen_FormClosing(object sender, FormClosingEventArgs e)
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
