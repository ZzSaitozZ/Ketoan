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

namespace Ketoan.Controls.Hangtonkho.Phieuxuatban
{
    public partial class FPhieuxuatban : Form
    {

        public FPhieuxuatban()
        {
            InitializeComponent();
        }
        public FPhieuxuatban(string a)
        {
            load_table(a);
        }
        private void load_table(string a)
        {
            InitializeComponent();
            EDCM2 u1 = new EDCM2(a);
            u1.Dock = DockStyle.Fill;
            panelDetail.Controls.Add(u1);

        }
        private void FPhieuxuatban_Load(object sender, EventArgs e)
        {
            
        }
    
        private void FPhieuxuatban_FormClosing(object sender, FormClosingEventArgs e)
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
