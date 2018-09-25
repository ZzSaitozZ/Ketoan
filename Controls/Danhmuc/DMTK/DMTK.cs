using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

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

        private void addBtn_Click(object sender, EventArgs e)
        {
            DateTime? dt = DateTime.Now;
            eWONDATASET.E00DMTK.AddE00DMTKRow("test31", null, null, null, false, false, false, false, null, null, null, dt.Value, dt.Value, null, null, null, null, null);
            e00DMTKTableAdapter.Update(eWONDATASET.E00DMTK);
            //var a = treeList1.GetFocusedDataRow()["Ten_Tk"].ToString();
            //gridView1.AddNewRow();
            //AddEditDMKho editForm = new AddEditDMKho(gridView1, "Add");
            //editForm.ShowDialog();
            //e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            //e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            //gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //int tempfocus = gridView1.FocusedRowHandle;
            //AddEditDMKho editForm = new AddEditDMKho(gridView1, "Edit");
            //editForm.ShowDialog();
            //e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            //e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            //gridView1.FocusedRowHandle = tempfocus;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            //e00DMKHOTableAdapter.Update(eWONDATASET.E00DMKHO);
            //e00DMKHOTableAdapter.Fill(eWONDATASET.E00DMKHO);
            //gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
