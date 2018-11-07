﻿using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMTYGIA
{
    public partial class DMTYGIA : Frame
    {
        public DMTYGIA()
        {
            InitializeComponent();
        }

        private void DMTYGIA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMTYGIA' table. You can move, or remove it, as needed.
            e00DMTYGIATableAdapter.Fill(eWONDATASET.E00DMTYGIA);

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            e00DMTYGIATableAdapter.Update(eWONDATASET.E00DMTYGIA);
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ShowEditForm();
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            gridView1.ShowEditForm();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            ColumnView view = gridControl1.FocusedView as ColumnView;
            if (view.UpdateCurrentRow())
            {
                e00DMTYGIATableAdapter.Update(eWONDATASET.E00DMTYGIA);
            }
        }

        private void gridView1_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            if (e.RowHandle <= gridView1.RowCount - 1 && e.RowHandle >= 0)
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Chỉnh sửa thông tin " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["Ten_Tk"].ToString();
            }
            else
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Thêm mới";
            }
        }
    }
}
