using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Ketoan.Controls.BanHangPhaiThu.baocao.Report;
using DevExpress.XtraReports.UI;

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class baocaodoanhthu : UserControl
    {
        public baocaodoanhthu()
        {
            InitializeComponent();
        }

        public baocaodoanhthu(string tungay, string denngay)
        {
            InitializeComponent();
           
            string[] Tungay = tungay.Split('/');
            string[] Denngay = denngay.Split('/');          


            gridControl1.DataSource = baocaobanhangTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));
            //          gridControl1.DataSource = cthoadonTableAdapter2.GetData(tungay,denngay);
        }

        

        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Baocaobanhang report = new Baocaobanhang();

            //bangkexuatbanTableAdapter tableAdapters = new bangkexuatbanTableAdapter();
            //tableAdapters.Fill(bangkexuatbanTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0]))), new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));



            //        Bangkephieuxuat report = new Bangkephieuxuat(tableAdapters, tngay, dngay);
            ReportPrintTool print = new ReportPrintTool(report);
            report.ShowPreviewDialog();
        }
    }
}
