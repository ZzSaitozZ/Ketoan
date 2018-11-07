using Ketoan.Controls.BanHangPhaiThu.BaoCao.BangKe;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu.BaoCao
{
    public partial class FBaoCaoMuaHang : Form
    {
        public FBaoCaoMuaHang(string a)
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
            if (txtTungay.Text == "" || txtDenngay.Text == "")
            {

            }
            else
            {
                switch (txtTieuDe.Text)
                {
                    case "Báo cáo doanh thu bán hàng":
                        {
                            FBangKeBanHang f = new FBangKeBanHang(tungay, denngay, loaibaocao);
                            f.Show();
                            break;
                        }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FBaoCaoMuaHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form frm1 = Application.OpenForms["StartForm"];
            //StartForm s = frm1 as StartForm;
            //s.k--;
            //if (s.k == 0)
            //{
            //    frm1.Show();
            //}
        }

        private void FBaoCaoMuaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FBaoCaoMuaHang f = new FBaoCaoMuaHang("1");
            f.Close();
        }
    }
}
