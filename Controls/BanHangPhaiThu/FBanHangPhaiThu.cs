using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class FBanHangPhaiThu : DevExpress.XtraEditors.XtraForm
    {
        public FBanHangPhaiThu()
        {
            InitializeComponent();
        }

        private void FBanHangPhaiThu_Load(object sender, EventArgs e)
        {
            //HoaDonBanHang u1 = new HoaDonBanHang();
            //u1.Dock = DockStyle.Fill;
            //panel1.Controls.Add(u1);
        }

        private void FBanHangPhaiThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k--;
            if (s.k == 0)
            {
                frm1.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            HoaDonBanHang u1 = new HoaDonBanHang();
            u1.Dock = DockStyle.Fill;
            panel1.Controls.Add(u1);
        }
    }
}
