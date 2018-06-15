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
    public partial class R00MEMBER : UserControl
    {
        public R00MEMBER()
        {
            InitializeComponent();
            r00MEMBERTableAdapter.Fill(r50NAMKIMDataSet.R00MEMBER);
        }
    }
}
