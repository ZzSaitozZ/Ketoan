using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ketoan.Table;
using Ketoan.Controls.Ketoantonghop;

namespace Ketoan.Controls.Dungchung.Menu
{
    public partial class EDCM1 : UserControl
    {
        public EDCM1()
        { 
           
          
        }
        public EDCM1(string a)
        {
            InitializeComponent();
            
            load_table(a);
        }
        private void load_table(string table)
        {
            switch (table)
            {
                case "btcn":

                    Phieuketoankhac u1 = new Phieuketoankhac();
                    u1.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u1);
                    //statements 
                    break;
             
          //      default:
                    //optional 
                    //statements 
            }
            
        }


        private void EDCM1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}