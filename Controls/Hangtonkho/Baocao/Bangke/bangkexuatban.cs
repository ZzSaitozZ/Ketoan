using DevExpress.XtraReports.UI;
using Ketoan.Controls.HangTonKho.BaoCao.Report;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.HangTonKho.BaoCao.BangKe
{
    public partial class BangKeXuatBan : UserControl
    {
        private string tngay;
        private string dngay;
        public BangKeXuatBan(string tungay, string denngay)
        {
            InitializeComponent();
            tngay = tungay;
            dngay = denngay;
            string[] Tungay = tungay.Split('/');
            string[] Denngay = denngay.Split('/');
            //       gridControl1.DataSource = BangKeXuatBanTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])),new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string[] Tungay = tngay.Split('/');
            string[] Denngay = dngay.Split('/');
            BaoCaoR report = new BaoCaoR();
            //BangKeXuatBanTableAdapter tableAdapters = new BangKeXuatBanTableAdapter();
            //tableAdapters.Fill(BangKeXuatBanTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0]))), new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));
            //        Bangkephieuxuat report = new Bangkephieuxuat(tableAdapters, tngay, dngay);
            ReportPrintTool print = new ReportPrintTool(report);
            report.ShowPreviewDialog();
        }
    }
}
