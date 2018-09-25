﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using Ketoan.Controls.Dungchung.Menu;

namespace Ketoan.Controls.BanHangPhaiThu.baocao
{
    public partial class MenuBaocao : UserControl
    {
        public MenuBaocao()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            e004MBHPTTableAdapter1.Fill(ewondataset1.E004MBHPT);
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            Point fPoint = Control.MousePosition;
            TreeList tl = (TreeList)sender;
            fPoint = tl.PointToClient(fPoint);
            TreeListHitInfo hInfo = (TreeListHitInfo)tl.CalcHitInfo(fPoint);
            if (hInfo.Node != null)
            {
                Text = hInfo.Node.GetDisplayText(1);
                FBaocaomuahang bc = new FBaocaomuahang(Text);
                bc.Show();

            }
        }
    }
}