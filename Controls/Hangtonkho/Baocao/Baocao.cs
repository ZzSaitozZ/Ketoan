﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ketoan.Controls.Dungchung.Menu;
using DevExpress.XtraTreeList;

namespace Ketoan.Controls.Hangtonkho.Baocao
{
    public partial class Baocao : UserControl
    {
        public Baocao()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // This line of code is generated by Data Source Configuration Wizard
            //e004MBCKTableAdapter1.Fill(ewondataset1.E004MBCK);
        }
        int count = 0;
        //private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        //{   if (count >= 1)
        //    {
        //        string t = e.Node.GetValue(treeList1.KeyFieldName).ToString();
        //        string value=e.Node.GetValue("tenmenu").ToString();
               
        //                    FBaocaotonkho bc = new FBaocaotonkho(value);
        //                    bc.Show();
               
        //        }
        //    count = count + 1;
        //}

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            Point fPoint = Control.MousePosition;
             TreeList tl= (TreeList)sender;
            fPoint = tl.PointToClient(fPoint);
        TreeListHitInfo hInfo = (TreeListHitInfo)tl.CalcHitInfo(fPoint);
        if (hInfo.Node !=null)
                {
                Text = hInfo.Node.GetDisplayText(1);
                FBaocaotonkho bc = new FBaocaotonkho(Text);
                bc.Show();

            }
        }
    }
    }
