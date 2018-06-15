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
    public partial class R07DMYT : UserControl
    {
        public R07DMYT()
        {
            InitializeComponent();
            r07DMYTTableAdapter.Fill(r50NAMKIMDataSet.R07DMYT);
        }
    }
}
