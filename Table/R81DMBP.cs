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
    public partial class R81DMBP : UserControl
    {
        public R81DMBP()
        {
            InitializeComponent();
            r81DMBPTableAdapter.Fill(r50NAMKIMDataSet.R81DMBP);
        }
    }
}
