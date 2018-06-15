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
    public partial class R81DMVT : UserControl
    {
        public R81DMVT()
        {
            InitializeComponent();
            r81DMVTTableAdapter.Fill(r50NAMKIMDataSet.R81DMVT);
        }
    }
}
