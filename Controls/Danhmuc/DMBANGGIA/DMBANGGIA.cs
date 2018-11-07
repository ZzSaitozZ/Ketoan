using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMBANGGIA
{
    public partial class DMBANGGIA : Frame
    {
        public DMBANGGIA()
        {
            InitializeComponent();
        }

        private void DMBANGGIA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMVT' table. You can move, or remove it, as needed.
            e00DMVTTableAdapter.Fill(eWONDATASET.E00DMVT);
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMBANGGIA' table. You can move, or remove it, as needed.
            e00DMBANGGIATableAdapter.Fill(eWONDATASET.E00DMBANGGIA);

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            e00DMBANGGIATableAdapter.Update(eWONDATASET.E00DMBANGGIA);
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //gridView1.ShowEditForm();
            AddEditDMBANGGIA add = new AddEditDMBANGGIA(gridView1, true);
            add.ShowDialog();
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
                e00DMBANGGIATableAdapter.Update(eWONDATASET.E00DMBANGGIA);
            }
        }

        private void gridView1_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            if (e.RowHandle <= gridView1.RowCount - 1 && e.RowHandle >= 0)
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Chỉnh sửa thông tin " + gridView1.GetDataRow(gridView1.FocusedRowHandle)["Ten_Nh_Dt"].ToString();
            }
            else
            {
                gridView1.OptionsEditForm.FormCaptionFormat = "Thêm mới";
            }
        }
    }
}
