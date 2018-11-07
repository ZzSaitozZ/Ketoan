using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ketoan.Controls.Danhmuc.DMNVU
{
    public partial class DMNVU : Frame
    {
        public DMNVU()
        {
            InitializeComponent();
        }
        private void DMNVU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMNHVT' table. You can move, or remove it, as needed.
            this.e00DMNVUTableAdapter.Fill(this.eWONDATASET.E00DMNVU);

        }
        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMNVUTableAdapter.Update(eWONDATASET.E00DMNVU);
            e00DMNVUTableAdapter.Fill(eWONDATASET.E00DMNVU);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMNVU editForm = new AddEditDMNVU(gridView1, false); // 2nd argument is false for editting
            editForm.ShowDialog();
            e00DMNVUTableAdapter.Update(eWONDATASET.E00DMNVU);
            e00DMNVUTableAdapter.Fill(eWONDATASET.E00DMNVU);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMNVU editForm = new AddEditDMNVU(gridView1, true); // 2nd argument is true for Adding
            editForm.ShowDialog();
            e00DMNVUTableAdapter.Update(eWONDATASET.E00DMNVU);
            e00DMNVUTableAdapter.Fill(eWONDATASET.E00DMNVU);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
