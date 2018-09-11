using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Ketoan.Controls.Hangtonkho.Baocao.Report
{
    public partial class baocaoR : DevExpress.XtraReports.UI.XtraReport
    {
        public baocaoR()
        {
            InitializeComponent();
            sqlDataSource1.Queries[0].Parameters[0].Value = "01/01/2018";
            sqlDataSource1.Queries[0].Parameters[1].Value = "10/01/2018";
        }

    }
}
