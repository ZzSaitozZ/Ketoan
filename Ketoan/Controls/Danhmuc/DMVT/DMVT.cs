using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMVT
{
    public partial class DMVT : Frame
    {
        public DMVT()
        {
            InitializeComponent();
        }

        private void DMVT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMKHO' table. You can move, or remove it, as needed.
            e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMNHVT' table. You can move, or remove it, as needed.
            e00DMNHVTTableAdapter.Fill(eWONDATASET.E00DMNHVT);
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMVT' table. You can move, or remove it, as needed.
            e00DMVTTableAdapter.Fill(eWONDATASET.E00DMVT);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            e00DMVTTableAdapter.Update(eWONDATASET.E00DMVT);
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
                e00DMVTTableAdapter.Update(eWONDATASET.E00DMVT);
            }
        }

        private void gridView1_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            if (e.RowHandle <= gridView1.RowCount - 1 && e.RowHandle >= 0)
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Chỉnh sửa thông tin " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["Ten_Vt"].ToString();
            }
            else
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Thêm mới";
            }
        }

        private void repositoryItemGridLookUpEdit2View_RowUpdated(object sender, RowObjectEventArgs e)
        {
            e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
        }

        private void repositoryItemGridLookUpEdit1View_RowUpdated(object sender, RowObjectEventArgs e)
        {
            e00DMNHVTTableAdapter.Update(eWONDATASET.E00DMNHVT);
        }
    }
}
