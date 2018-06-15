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
    public partial class R00MODULE : UserControl
    {
        public R00MODULE()
        {
            InitializeComponent();
            r00MODULETableAdapter.Fill(r50NAMKIMDataSet.R00MODULE);
        }
    }
}
