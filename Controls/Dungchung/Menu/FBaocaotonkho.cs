using Ketoan.Controls.HangTonKho.BaoCao.BangKe;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Ketoan.Controls.DungChung.Menu
{
    public partial class FBaoCaoTonKho : Form
    {
        public FBaoCaoTonKho(string a)
        {
            InitializeComponent();
            txtTieuDe.Text = a + "";
            loaibaocao = txtTieuDe.Text;

        }

        private string tungay;
        private string denngay;
        private string loaibaocao = "";
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(txtTungay.Text, "dd/mm/yyyy", null, DateTimeStyles.None, out DateTime Test) == true)
            {
                tungay = txtTungay.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng điền đúng định dạng ngày theo dạng dd/mm/yyyy");
            }

            if (DateTime.TryParseExact(txtDenngay.Text, "dd/mm/yyyy", null, DateTimeStyles.None, out Test) == true)
            {
                denngay = txtDenngay.Text;
            }

            else
            {
                MessageBox.Show("Vui lòng điền đúng định dạng ngày theo dạng dd/mm/yyyy");
            }
            switch (txtTieuDe.Text)
            {
                case "Bảng kê phiếu xuất":
                    {
                        FBangKeXuatBan f = new FBangKeXuatBan(tungay,denngay,loaibaocao);
                        f.Show();
                        break;
                    }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FBaoCaoTonKho_FormClosing(object sender, FormClosingEventArgs e)
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
