using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc.DMVT
{
    public partial class DMVT : Frame
    {
        public DMVT()
        {
            InitializeComponent();
        }

        private void DMVT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMVT' table. You can move, or remove it, as needed.
            this.e00DMVTTableAdapter.Fill(this.eWONDATASET.E00DMVT);

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMVTTableAdapter.Update(eWONDATASET.E00DMVT);
            e00DMVTTableAdapter.Fill(eWONDATASET.E00DMVT);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMVT editForm = new AddEditDMVT(gridView1, false); // 2nd argument is false for editting
            editForm.ShowDialog();
            e00DMVTTableAdapter.Update(eWONDATASET.E00DMVT);
            e00DMVTTableAdapter.Fill(eWONDATASET.E00DMVT);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMVT editForm = new AddEditDMVT(gridView1, true); // 2nd argument is true for Adding
            editForm.ShowDialog();
            e00DMVTTableAdapter.Update(eWONDATASET.E00DMVT);
            e00DMVTTableAdapter.Fill(eWONDATASET.E00DMVT);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
