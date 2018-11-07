using System;
using System.Windows.Forms;

namespace Ketoan.Controls.CpGiaThanh
{
    public partial class FKhaiBaoDinhMucSp : Form
    {
        public FKhaiBaoDinhMucSp()
        {
            InitializeComponent();
        }

        private void FKhaiBaoDinhMucSp_Load(object sender, EventArgs e)
        {
            CpGiaThanh u1 = new CpGiaThanh
            {
                Dock = DockStyle.Fill
            };
            panelDetails.Controls.Add(u1);
        }

        private void FKhaiBaoDinhMucSp_FormClosing(object sender, FormClosingEventArgs e)
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
