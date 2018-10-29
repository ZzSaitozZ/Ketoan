using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc.DMTK
{
    public partial class DMTK : Frame
    {
        public DMTK()
        {
            InitializeComponent();
        }

        private void DMTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMTK' table. You can move, or remove it, as needed.
            this.e00DMTKTableAdapter.Fill(this.eWONDATASET.E00DMTK);

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMTKTableAdapter.Update(eWONDATASET.E00DMTK);
            e00DMTKTableAdapter.Fill(eWONDATASET.E00DMTK);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMTK editForm = new AddEditDMTK(gridView1, false); // 2nd argument is false for editting
            editForm.ShowDialog();
            e00DMTKTableAdapter.Update(eWONDATASET.E00DMTK);
            e00DMTKTableAdapter.Fill(eWONDATASET.E00DMTK);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMTK editForm = new AddEditDMTK(gridView1, true); // 2nd argument is true for Adding
            editForm.ShowDialog();
            e00DMTKTableAdapter.Update(eWONDATASET.E00DMTK);
            e00DMTKTableAdapter.Fill(eWONDATASET.E00DMTK);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
