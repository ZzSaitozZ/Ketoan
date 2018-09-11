﻿using Ketoan.Controls.Hangtonkho.Baocao.Bangke;
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

namespace Ketoan.Controls.Dungchung.Menu
{
    public partial class FBaocaotonkho : Form
    {
        public FBaocaotonkho(string a)
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
            switch (txtTieuDe.Text)
            {
                case "Bảng kê phiếu xuất":
                    {


                        FBangkexuatban f = new FBangkexuatban(tungay,denngay,loaibaocao);
                        f.Show();
                        break;
                    }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FBaocaotonkho_FormClosing(object sender, FormClosingEventArgs e)
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
