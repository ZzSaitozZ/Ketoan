﻿using System.Windows.Forms;

namespace Ketoan.Table
{
    public partial class EDMNHHD : UserControl
    {
        public EDMNHHD()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            Dock = DockStyle.Fill;
            e00DMNHHDTableAdapter1.Fill(ewondataset1.E00DMNHHD);
        }
    }
}