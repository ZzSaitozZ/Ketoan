﻿using Ketoan.Controls.DanhMuc;
using System;
using System.Windows.Forms;
namespace Ketoan.Controls.VonBangTien.PhieuThuChi
{
    public partial class FormPhieuThu : Frame
    {
        private string phieu;
        public FormPhieuThu(string Phieu)
        {
            InitializeComponent();
            //This line of code is generated by Data Source Configuration Wizard
            e10PHVBTTableAdapter.FillByPT(ewondataset1.E10PHVBT, Phieu);
            phieu = Phieu;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            gridView1.GetDataRow(gridView1.FocusedRowHandle)["Ma_Ct"] = phieu;
            gridView1.UpdateCurrentRow();
            e10PHVBTTableAdapter.Update(ewondataset1.E10PHVBT);
            e10PHVBTTableAdapter.FillByPT(ewondataset1.E10PHVBT, phieu);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
            AddEditDeletePhieuThu editForm = new AddEditDeletePhieuThu(gridView1, true, phieu);
            editForm.ShowDialog();
            e10PHVBTTableAdapter.Update(ewondataset1.E10PHVBT);
            e10PHVBTTableAdapter.FillByPT(ewondataset1.E10PHVBT, phieu);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDeletePhieuThu editForm = new AddEditDeletePhieuThu(gridView1, false, phieu);
            editForm.ShowDialog();
            e10PHVBTTableAdapter.Update(ewondataset1.E10PHVBT);
            e10PHVBTTableAdapter.FillByPT(ewondataset1.E10PHVBT, phieu);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e10PHVBTTableAdapter.Update(ewondataset1.E10PHVBT);
            e10PHVBTTableAdapter.FillByPT(ewondataset1.E10PHVBT, phieu);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void FormPhieuThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k--;
            if (s.k == 0)
            {
                frm1.Show();
            }
        }

        private void gridView1_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string Stt = gridView1.GetDataRow(gridView1.FocusedRowHandle)["Stt"].ToString();
            // This line of code is generated by Data Source Configuration Wizard
            e10CTVBTTableAdapter.FillByStt(ewondataset1.E10CTVBT, int.Parse(Stt));
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                editBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                addBtn.PerformClick();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDeletePhieuThu editForm = new AddEditDeletePhieuThu(gridView1, false, phieu);
            editForm.ShowDialog();
            e10PHVBTTableAdapter.Update(ewondataset1.E10PHVBT);
            e10PHVBTTableAdapter.FillByPT(ewondataset1.E10PHVBT, phieu);
            gridView1.FocusedRowHandle = tempfocus;
        }

        //private void FormPhieuThu_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'ewondataset1.E10CTVBT' table. You can move, or remove it, as needed.
        //    this.e10CTVBTTableAdapter.Fill(this.ewondataset1.E10CTVBT);
        //    // TODO: This line of code loads data into the 'ewondataset1.E10PHVBT' table. You can move, or remove it, as needed.
        //    this.e10PHVBTTableAdapter.Fill(this.ewondataset1.E10PHVBT);
        //}
    }
}