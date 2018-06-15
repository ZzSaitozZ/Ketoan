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
    public partial class R81DMNHVT : UserControl
    {
        public R81DMNHVT()
        {
            InitializeComponent();
            r81DMNHVTTableAdapter.Fill(r50NAMKIMDataSet.R81DMNHVT);
        }
    }
}
