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
    public partial class R00ZONE : UserControl
    {
        public R00ZONE()
        {
            InitializeComponent();
            r00ZONETableAdapter.Fill(r50NAMKIMDataSet.R00ZONE);
        }
    }
}
