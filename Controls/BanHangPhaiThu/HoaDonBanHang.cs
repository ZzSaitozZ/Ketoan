using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ketoan.Table;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class HoaDonBanHang : UserControl
    {
        public HoaDonBanHang()
        {
            InitializeComponent();
            ChungTuHoaDonBanHang u1 = new ChungTuHoaDonBanHang();
            //  u1.TopLevel = false;
            u1.Dock = DockStyle.Fill;
            panel.Controls.Add(u1);
        }
    }
}