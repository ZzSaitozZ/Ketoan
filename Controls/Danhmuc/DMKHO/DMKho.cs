using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc.DMKho
{
    public partial class DMKho : Frame
    {
        public DMKho()
        {
            InitializeComponent();
        }

        private void DMKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMKHO' table. You can move, or remove it, as needed.
            this.e00DMKHOTableAdapter.Fill(this.eWONDATASET.E00DMKHO);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMKho editForm = new AddEditDMKho(gridView1, "Add");
            editForm.ShowDialog();
            e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMKho editForm = new AddEditDMKho(gridView1, "Edit");
            editForm.ShowDialog();
            e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
