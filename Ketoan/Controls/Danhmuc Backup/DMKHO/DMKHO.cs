using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc.DMKHO
{
    public partial class DMKHO : Frame
    {
        public DMKHO()
        {
            InitializeComponent();
        }

        private void DMKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMKHO' table. You can move, or remove it, as needed.
            this.e00DMKHOTableAdapter.Fill(this.eWONDATASET.E00DMKHO);

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMKHO editForm = new AddEditDMKHO(gridView1, false); // 2nd argument is false for editting
            editForm.ShowDialog();
            e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMKHO editForm = new AddEditDMKHO(gridView1, true); // 2nd argument is true for Adding
            editForm.ShowDialog();
            e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
