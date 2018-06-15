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
    public partial class R81DMTK : UserControl
    {
        public R81DMTK()
        {
            InitializeComponent();
            r81DMTKTableAdapter.Fill(r50NAMKIMDataSet.R81DMTK);
        }
    }
}
