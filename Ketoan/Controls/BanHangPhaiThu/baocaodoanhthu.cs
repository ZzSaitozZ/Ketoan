using DevExpress.XtraReports.UI;
using Ketoan.Controls.BanHangPhaiThu.BaoCao.Report;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class BaoCaoDoanhThu : UserControl
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        public BaoCaoDoanhThu(string tungay, string denngay)
        {
            InitializeComponent();
            string[] Tungay = tungay.Split('/');
            string[] Denngay = denngay.Split('/');
            gridControl1.DataSource = baocaobanhangTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));
            //          gridControl1.DataSource = cthoadonTableAdapter2.GetData(tungay,denngay);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BaoCaoBanHang report = new BaoCaoBanHang();
            //bangkexuatbanTableAdapter tableAdapters = new bangkexuatbanTableAdapter();
            //tableAdapters.Fill(bangkexuatbanTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0]))), new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));
            //        Bangkephieuxuat report = new Bangkephieuxuat(tableAdapters, tngay, dngay);
            ReportPrintTool print = new ReportPrintTool(report);
            report.ShowPreviewDialog();
        }
    }
}
