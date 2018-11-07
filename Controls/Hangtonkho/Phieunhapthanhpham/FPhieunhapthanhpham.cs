using System;
using System.Windows.Forms;

namespace Ketoan.Controls.HangTonKho.PhieuNhapThanhPham
{
    public partial class FPhieuNhapThanhPham : Form
    {
        public FPhieuNhapThanhPham()
        {
            InitializeComponent();
        }

        private void FPhieuNhapThanhPham_Load(object sender, EventArgs e)
        {
            //CpGiaThanh u1 = new CpGiaThanh();
            //u1.Dock = DockStyle.Fill;
            //panelDetails.Controls.Add(u1);
        }

        private void FPhieuNhapThanhPham_FormClosing(object sender, FormClosingEventArgs e)
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
