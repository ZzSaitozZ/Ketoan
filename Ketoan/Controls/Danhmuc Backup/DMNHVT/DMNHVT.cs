﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc.DMNHVT
{
    public partial class DMNHVT : Frame
    {
        public DMNHVT()
        {
            InitializeComponent();
        }

        private void DMNHVT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMNHVT' table. You can move, or remove it, as needed.
            this.e00DMNHVTTableAdapter.Fill(this.eWONDATASET.E00DMNHVT);

        }
        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa dự liệu này?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) { gridView1.DeleteRow(gridView1.FocusedRowHandle); }
            e00DMNHVTTableAdapter.Update(eWONDATASET.E00DMNHVT);
            e00DMNHVTTableAdapter.Fill(eWONDATASET.E00DMNHVT);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int tempfocus = gridView1.FocusedRowHandle;
            AddEditDMNHVT editForm = new AddEditDMNHVT(gridView1, false); // 2nd argument is false for editting
            editForm.ShowDialog();
            e00DMNHVTTableAdapter.Update(eWONDATASET.E00DMNHVT);
            e00DMNHVTTableAdapter.Fill(eWONDATASET.E00DMNHVT);
            gridView1.FocusedRowHandle = tempfocus;
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            AddEditDMNHVT editForm = new AddEditDMNHVT(gridView1, true); // 2nd argument is true for Adding
            editForm.ShowDialog();
            e00DMNHVTTableAdapter.Update(eWONDATASET.E00DMNHVT);
            e00DMNHVTTableAdapter.Fill(eWONDATASET.E00DMNHVT);
            gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;
        }
    }
}