﻿using System.Windows.Forms;

namespace Ketoan.Table
{
    public partial class EDMNVU : UserControl
    {
        public EDMNVU()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard.
            Dock = DockStyle.Fill;
            e00DMNVUTableAdapter1.Fill(ewondataset1.E00DMNVU);
        }
    }
}
