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
using Ketoan.Controls.Hangtonkho.Phieuxuatban;
using Ketoan.Controls.Hangtonkho.Phieuxuatkhothanhpham;
using Ketoan.Controls.Hangtonkho.Baocao;
using Ketoan.Controls.Hangtonkho.Baocao.Bangke;
using Ketoan.Controls.BanHangPhaiThu.baocao;

namespace Ketoan.Controls.Dungchung.Menu
{
    public partial class EDCM2 : UserControl
    {
        public EDCM2()
        { 
           
          
        }
        public EDCM2(string a)
        {
            InitializeComponent();
            
            load_table(a);
        }
     
    
            private void load_table(string table)
        {
            switch (table)
            {
                case "Pxb":

                    Phieuxuatban u1 = new Phieuxuatban();
                    u1.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u1);
                    //statements 
                    break;
                case "pntp":
                    Phieuxuatkhotp u2 = new Phieuxuatkhotp();
                    u2.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u2);
                    //statements 


                    break;
                case "Baocao":
                    Baocao u3 = new Baocao();
                    u3.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u3);
                    //statements 


                    break;
                case "bcmh":
                    MenuBaocao u4 = new MenuBaocao();
                    u4.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u4);
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}