﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Table
{
    public partial class R81DMTHUE : UserControl
    {
        public R81DMTHUE()
        {
            InitializeComponent();
            r81DMTHUETableAdapter.Fill(r50NAMKIMDataSet.R81DMTHUE);
        }
    }
}
