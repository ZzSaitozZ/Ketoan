﻿using System.Windows.Forms;

namespace Ketoan.Table
{
    public partial class EDMBP : UserControl
    {
        public EDMBP()
        {
            InitializeComponent();
            //eDMBPTableAdapter.Fill(eWONDataSet.EDMBP);
            // This line of code is generated by Data Source Configuration Wizard
            Dock = DockStyle.Fill;
            e00DMBPTableAdapters.Fill(ewondatasets.E00DMBP);
        }
    }
}