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
    public partial class R06CTTS : UserControl
    {
        public R06CTTS()
        {
            InitializeComponent();
            r06CTTSTableAdapter.Fill(r50NAMKIMDataSet.R06CTTS);
        }
    }
}
