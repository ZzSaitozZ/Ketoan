using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class FDanhMucNghiepVu : DevExpress.XtraEditors.XtraForm
    {
        public FDanhMucNghiepVu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            EUDMNV u1 = new EUDMNV();
            u1.Dock = DockStyle.Fill;
            panel1.Controls.Add(u1);
        }
    }
}