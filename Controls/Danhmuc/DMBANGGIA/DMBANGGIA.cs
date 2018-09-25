using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace Ketoan.Controls.Danhmuc.DMBANGGIA
{
    public partial class DMBANGGIA : Frame
    {
        public DMBANGGIA()
        {
            InitializeComponent();            
        }

        private void DMBANGGIA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMBANGGIA' table. You can move, or remove it, as needed.
            this.e00DMBANGGIATableAdapter.Fill(this.eWONDATASET.E00DMBANGGIA);

        }        

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMBANGGIATableAdapter.Update(eWONDATASET.E00DMBANGGIA);
            e00DMBANGGIATableAdapter.Fill(eWONDATASET.E00DMBANGGIA);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMBANGGIA editForm = new AddEditDMBANGGIA(gridView1, false); // 2nd argument is false for editting
            editForm.ShowDialog();
            e00DMBANGGIATableAdapter.Update(eWONDATASET.E00DMBANGGIA);
            e00DMBANGGIATableAdapter.Fill(eWONDATASET.E00DMBANGGIA);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMBANGGIA editForm = new AddEditDMBANGGIA(gridView1, true); // 2nd argument is true for Adding
            editForm.ShowDialog();
            e00DMBANGGIATableAdapter.Update(eWONDATASET.E00DMBANGGIA);
            e00DMBANGGIATableAdapter.Fill(eWONDATASET.E00DMBANGGIA);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}
