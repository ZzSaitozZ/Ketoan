using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;


namespace Ketoan.Controls.Hangtonkho.Phieuxuatban

{
    public partial class Phieuxuatban : UserControl
    {
        public Phieuxuatban()
        {
            InitializeComponent();
  
     //      gridControl1.DataSource= filterPhieuXBTableAdapter1.GetData();

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            // var view = sender as GridView;
            //var focusRowView = (DataRowView)gridView1.GetFocusedRow();
            //if (view == null)
            //    return;
            //string stt = view.GetRowCellValue(e.RowHandle, "Stt").ToString();
            string stt = gridView1.GetFocusedRowCellValue("Stt").ToString();
         //   gridControl2.DataSource = filterChiTietPhieuXBTableAdapter1.GetData(int.Parse(stt));
            //    if (view.FocusedColumn.FieldName == "Stt")
            //{
            //    var oldValue = focusRowView["Stt"].ToString();
            //    //  var newValue =e.V
            //}
        }


        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
           

        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //var view = sender as GridView;
            //var focusRowView = (DataRowView)gridView1.GetFocusedRow();
            //if (view == null)
            //    return;

            //string stt = view.GetRowCellValue(e.RowHandle, "Stt").ToString();
            //gridControl2.DataSource = filterE01CTNXTableAdapter1.GetData(stt);
            string stt = gridView1.GetFocusedRowCellValue("Stt").ToString();
         //   gridControl2.DataSource = filterChiTietPhieuXBTableAdapter1.GetData(int.Parse(stt));

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string stt = gridView1.GetFocusedRowCellValue("Stt").ToString();
         //   gridControl2.DataSource = filterChiTietPhieuXBTableAdapter1.GetData(int.Parse(stt));

        }
        //var view = sender as GridView;
        //var focusRowView = (DataRowView)gridView1.GetFocusedRow();
        //    if (view == null)
        //        return;
        //    if(view.FocusedColumn.FieldName=="Stt")
        //    {
        //        var oldValue = focusRowView["Stt"].ToString();
        ////  var newValue =e.V
        //    }

    }
}
