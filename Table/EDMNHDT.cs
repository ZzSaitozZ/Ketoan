﻿using System;
using System.Windows.Forms;

namespace Ketoan.Table
{
    public partial class EDMNHDT : UserControl
    {
        public EDMNHDT()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            Dock = DockStyle.Fill;
            e00DMNHDTTableAdapter1.Fill(ewondataset1.E00DMNHDT);
        }
    }
}