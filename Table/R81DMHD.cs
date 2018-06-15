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
    public partial class R81DMHD : UserControl
    {
        public R81DMHD()
        {
            InitializeComponent();
            r81DMHDTableAdapter.Fill(r50NAMKIMDataSet.R81DMHD);
        }
    }
}
