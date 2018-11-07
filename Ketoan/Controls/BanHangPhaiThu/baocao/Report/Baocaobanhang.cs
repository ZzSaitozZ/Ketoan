namespace Ketoan.Controls.BanHangPhaiThu.BaoCao.Report
{
    public partial class BaoCaoBanHang : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoBanHang()
        {
            InitializeComponent();
            sqlDataSource1.Queries[0].Parameters[0].Value = "01/01/2018";
            sqlDataSource1.Queries[0].Parameters[1].Value = "10/01/2018";
        }
    }
}
