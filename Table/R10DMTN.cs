using System;
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
    public partial class R10DMTN : UserControl
    {
        public R10DMTN()
        {
            InitializeComponent();
            r10DMTNTableAdapter.Fill(r50NAMKIMDataSet.R10DMTN);
        }
    }
}
