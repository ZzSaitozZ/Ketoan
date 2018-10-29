﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Ketoan.Controls.Dungchung.ThemSua;

namespace Ketoan.Controls.VonBangTien.PhieuThuChi
{
    public partial class AddEditDeletePhieuThu : EDCVBTAddEdit

    {
        String stt;
        bool isAdd;
        GridView Gridview;
        String Mact;
        public AddEditDeletePhieuThu(GridView gridview, bool isadd, string phieu)
        {
            InitializeComponent();
            
            Gridview = gridview;
            Mact = phieu;
            isAdd = isadd;
            stt = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"].ToString();
            //if (isAdd) this.Text = "Thêm mới";
            //else this.Text = "Chỉnh sửa";
            E10CTVBTTableAdapter1.FillByStt(ewondataset1.E10CTVBT, int.Parse(Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"].ToString()));
            E10CTVBTTableAdapter2.FillByStt(ewondataset2.E10CTVBT, int.Parse(Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"].ToString()));


            // This line of code is generated by Data Source Configuration Wizard
            //if (!isAdd) //!isNew  is Edit
            //{
         

            //}
            //gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            this.txtMahd.Text = phieu;
            this.txtManv.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"].ToString();
            //this.txtMadt.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"].ToString();
            this.txtOngba.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ong_Ba"].ToString();
            this.txtDc.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dien_Giai"].ToString(); 
        }

        private void gridView1_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            if (e.RowHandle <= gridView1.RowCount - 1 && e.RowHandle > 0)
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Chỉnh sửa thông tin " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["Stt"].ToString();
            }
            else
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Thêm mới";
                gridView1.AddNewRow();
            }
        }
        private void gridView1_InitNewRow_1(object sender, InitNewRowEventArgs e)
        {
            gridView1.SetRowCellValue(e.RowHandle, "Stt", stt );
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            ColumnView view = gridControl1.FocusedView as ColumnView;
            if (view.UpdateCurrentRow())
            {
                E10CTVBTTableAdapter1.Update(ewondataset1.E10CTVBT);
            }
        }
        private void tabbedControlGroup1_SelectedPageChanged_1(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            E10CTVBTTableAdapter1.FillByStt(ewondataset1.E10CTVBT, int.Parse(stt));
            E10CTVBTTableAdapter2.FillByStt(ewondataset2.E10CTVBT, int.Parse(stt));
        }

        private void AddEditDeletePhieuThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ewondataset1.E00DMTHUE' table. You can move, or remove it, as needed.
            this.e00DMTHUETableAdapter.Fill(this.ewondataset1.E00DMTHUE);
            // TODO: This line of code loads data into the 'ewondataset1.E00DMKM' table. You can move, or remove it, as needed.
            this.e00DMKMTableAdapter.Fill(this.ewondataset1.E00DMKM);
            // TODO: This line of code loads data into the 'ewondataset1.E00DMBP' table. You can move, or remove it, as needed.
            this.e00DMBPTableAdapter.Fill(this.ewondataset1.E00DMBP);
            // TODO: This line of code loads data into the 'ewondataset1.E00DMDT' table. You can move, or remove it, as needed.
            this.e00DMDTTableAdapter.Fill(this.ewondataset1.E00DMDT);
            // TODO: This line of code loads data into the 'ewondataset1.E00DMNHDT' table. You can move, or remove it, as needed.
            this.e00DMNHDTTableAdapter.Fill(this.ewondataset1.E00DMNHDT);
            // This line of code is generated by Data Source Configuration Wizard
            txtMadt.Properties.ForceInitialize();
            if (!isAdd) //!isNew  is Edit
            {

                txtMadt.ItemIndex = txtMadt.Properties.GetDataSourceRowIndex("Ma_Dt", Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"].ToString());
            }
            else txtMadt.ItemIndex = 0;

            // TODO: This line of code loads data into the 'ewondataset1.E00DMTK' table. You can move, or remove it, as needed.
            this.e00DMTKTableAdapter.Fill(this.ewondataset1.E00DMTK);

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            //string Stt2 = Stt_increase(this.txtMahd.Text);-
            this.Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct"] = this.txtMahd.Text;
            this.Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"] = this.txtManv.Text;
            this.Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"] = this.simpleLabelItem5.Text;
            this.Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ong_Ba"] = this.txtOngba.Text;
            this.Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dien_Giai"] = this.txtDc.Text;
            if (isAdd) Gridview.UpdateCurrentRow();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMadt_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView s = (DataRowView)txtMadt.GetSelectedDataRow();
           simpleLabelItem5.Text = s["Ma_Dt"].ToString();
        }
        private String Stt_increase(String stt)
        {
            var prefix = Regex.Match(stt, "^\\D+0101").Value;
            var number = Regex.Replace(stt, "^\\D+0101", "");
            var i = int.Parse(number) + 1;
            var newString = prefix + i.ToString(new string('0', number.Length));
            return newString;
        }

        private void gridView2_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            if (e.RowHandle <= gridView2.RowCount - 1 && e.RowHandle > 0)
            {
                gridView2.OptionsEditForm.FormCaptionFormat = "Chỉnh sửa thông tin " + gridView2.GetDataRow(gridView2.FocusedRowHandle)["Stt"].ToString();
            }
            else
            {
                gridView2.OptionsEditForm.FormCaptionFormat = "Thêm mới";
                gridView2.AddNewRow();
            }
        }
        private void gridView2_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView2.SetRowCellValue(e.RowHandle, "Stt", stt);
        }

        private void gridView2_RowUpdated(object sender, RowObjectEventArgs e)
        {
            ColumnView view = gridControl2.FocusedView as ColumnView;
            if (view.UpdateCurrentRow())
            {
                E10CTVBTTableAdapter2.Update(ewondataset2.E10CTVBT);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }
    }
}

//private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
//{
//    if (e.FocusedRowHandle == GridControl.NewItemRowHandle)
//    {
//        gridView1.AddNewRow();
//        //this.gridView1.SetRowCellValue(e.FocusedRowHandle, "Stt", "44745");
//    }
//}

//private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
//{
//    gridView1.SetRowCellValue(e.RowHandle, "Stt", "test");
//}
