using DevExpress.XtraGrid.Views.Grid;
using KeToan.DAO;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class ChungTuHoaDonBanHang : UserControl
    {
        public ChungTuHoaDonBanHang()
        {
            InitializeComponent();
            LoadCTHDBH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemHoaDon frm = new FThemHoaDon();
            frm.Show();
        }

        #region Test Insert,Update,Delete
        public bool Insert(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.table ( name, id, price )VALUES  ( N'{0}', {1}, {2})",
                name, id, price);
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }

        public bool Update(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.table SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}",
                name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }

        public bool Delete(int id)
        {
            //BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);
            string query = string.Format("Delete table where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNoneQuery(query);
            return result > 0;
        }
        #endregion

        private void LoadCTHDBH()
        {
            string query = "EXECUTE	dbo.ESP_GetCTHD";
            gridControl1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            LoadCTHD("HD01");
        }

        private void LoadCTHD(string id)
        {
            string query = "EXECUTE dbo.ESP_GetCTCTHD @Ma_HD";
            gridControl2.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            //gridControl2.DataSource = esP_GetCTCTHDTableAdapter1.GetData(stt);
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            string stt = gridView1.GetFocusedRowCellValue("Ma_HD").ToString();
            LoadCTHD(stt);
        }
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            string stt = gridView1.GetFocusedRowCellValue("Ma_HD").ToString();
            LoadCTHD(stt);
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string stt = gridView1.GetFocusedRowCellValue("Ma_HD").ToString();
            LoadCTHD(stt);
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            string stt = gridView1.GetFocusedRowCellValue("Ma_HD").ToString();
            LoadCTHD(stt);
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            string stt = gridView1.GetFocusedRowCellValue("Ma_HD").ToString();
            LoadCTHD(stt);
        }
    }
}