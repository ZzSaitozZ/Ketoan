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
    public partial class R81DMNHDT : UserControl
    {
        public R81DMNHDT()
        {
            InitializeComponent();
            r81DMNHDTTableAdapter.Fill(r50NAMKIMDataSet.R81DMNHDT);
        }
    }
}
