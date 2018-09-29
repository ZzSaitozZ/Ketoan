using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc.DMDT
{
    public partial class DMDT : Frame
    {
        public DMDT()
        {
            InitializeComponent();            
        }        

        private void DMDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMDT' table. You can move, or remove it, as needed.
            this.e00DMDTTableAdapter.Fill(this.eWONDATASET.E00DMDT);

        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMDT editForm = new AddEditDMDT(gridView1, true);
            editForm.ShowDialog();
            e00DMDTTableAdapter.Update(eWONDATASET.E00DMDT);
            e00DMDTTableAdapter.Fill(eWONDATASET.E00DMDT);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMDT editForm = new AddEditDMDT(gridView1, false);
            editForm.ShowDialog();
            e00DMDTTableAdapter.Update(eWONDATASET.E00DMDT);
            e00DMDTTableAdapter.Fill(eWONDATASET.E00DMDT);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMDTTableAdapter.Update(eWONDATASET.E00DMDT);
            e00DMDTTableAdapter.Fill(eWONDATASET.E00DMDT);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
