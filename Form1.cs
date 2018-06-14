using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Ketoan.Table.R81DMBP DMBP = new Ketoan.Table.R81DMBP();
        Ketoan.Table.R81DMDT DMDT = new Ketoan.Table.R81DMDT();
        public Form1(string a)
        {
            InitializeComponent();
            load_table(a);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = Application.OpenForms["Form1"];
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k--;
            if(s.k ==0)
            {
                frm1.Show();
            }
       
        }

        private void load_table(string table)
        {
            if(table == "DMBP")
            {
                DMBP.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMBP);
            }
            else if(table == "DMDT")
            {
                Tablearea.Controls.Clear();
                DMDT.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMDT);
            }
        }

       
    }
}
