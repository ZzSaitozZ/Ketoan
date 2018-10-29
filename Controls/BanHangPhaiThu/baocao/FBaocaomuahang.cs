using Ketoan.Controls.Hangtonkho.Baocao.Bangke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu.baocao
{
    public partial class FBaocaomuahang : Form
    {
        public FBaocaomuahang(string a)
        {
            InitializeComponent();
            txtTieuDe.Text = a + "";
            loaibaocao = txtTieuDe.Text;

        }
        string tungay;
        string denngay;
        string loaibaocao = "";
        private void btnDongY_Click(object sender, EventArgs e)
        {
            DateTime Test;
            if (DateTime.TryParseExact(txtTungay.Text, "dd/mm/yyyy", null, DateTimeStyles.None, out Test) == true)
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


                            FBangkebanhang f = new FBangkebanhang(tungay, denngay, loaibaocao);
                            f.Show();
                            break;
                        }
                }
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FBaocaomuahang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form frm1 = Application.OpenForms["StartForm"];
            //StartForm s = frm1 as StartForm;
            //s.k--;
            //if (s.k == 0)
            //{
            //    frm1.Show();
            //}
          
        }

        private void FBaocaomuahang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FBaocaomuahang f = new FBaocaomuahang("1");     
       f.Close();

        }
    }
}
