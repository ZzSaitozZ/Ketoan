using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using Ketoan.Controls.Hangtonkho.Baocao.Report;

namespace Ketoan.Controls.Hangtonkho.Baocao.Bangke
{
    public partial class bangkexuatban : UserControl
    {
        string tngay;
        string dngay;
        public bangkexuatban(string tungay,string denngay)
        {
            InitializeComponent();
            tngay = tungay;
            dngay = denngay;
            string[] Tungay = tungay.Split('/');
            string[] Denngay = denngay.Split('/');
         
     //       gridControl1.DataSource = bangkexuatbanTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])),new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));
        }

        private void btnPrint_Click(object sender, EventArgs e)

        {
            string[] Tungay = tngay.Split('/');
            string[] Denngay = dngay.Split('/');
            baocaoR report = new baocaoR();
          
            //bangkexuatbanTableAdapter tableAdapters = new bangkexuatbanTableAdapter();
            //tableAdapters.Fill(bangkexuatbanTableAdapter1.GetData(new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0]))), new DateTime(int.Parse(Tungay[2]), int.Parse(Tungay[1]), int.Parse(Tungay[0])), new DateTime(int.Parse(Denngay[2]), int.Parse(Denngay[1]), int.Parse(Denngay[0])));



    //        Bangkephieuxuat report = new Bangkephieuxuat(tableAdapters, tngay, dngay);
            ReportPrintTool print = new ReportPrintTool(report);
            report.ShowPreviewDialog();

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

 
    }
}
