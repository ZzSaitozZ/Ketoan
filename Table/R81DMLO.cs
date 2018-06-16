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
    public partial class R81DMLO : UserControl
    {
        public R81DMLO()
        {
            InitializeComponent();
            r81DMLOTableAdapter.Fill(r50NAMKIMDataSet.R81DMLO);
        }
    }
}
