using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace Ketoan.Controls.HangTonKho.PhieuXuatBan

{
    public partial class PhieuXuatBan : UserControl
    {
        public PhieuXuatBan()
        {
            InitializeComponent();
            //      gridControl1.DataSource= filterPhieuXBTableAdapter1.GetData();
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
