using Ketoan.Controls.Dungchung.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Ketoantonghop
{
    public partial class FButtoanketchuyen : Form
    {
        public FButtoanketchuyen()
        {

          //  InitializeComponent();
        }
        public FButtoanketchuyen(string a)
        {
            InitializeComponent();
            load_table(a);
        }
        private void load_table(string table)
        {
            switch (table)
            {
                   
                case "btkc":
                    //statements 
                    {
                        EDCMenu u1 = new EDCMenu(table);
                        u1.Dock = DockStyle.Fill;
                        panelDetails.Controls.Add(u1);
                        //statements 
                        break;
                    }
                  //  break;
            }

        }
        private void FButtoanketchuyen_Load(object sender, EventArgs e)
        {
        
        }

        private void FButtoanketchuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k--;
            if (s.k == 0)
            {
                frm1.Show();
            }
        }
    }
}
