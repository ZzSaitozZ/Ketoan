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

namespace Ketoan.Controls.BanHangPhaiThu
{
    public partial class FBaocaomuahang : Form
    {
        public FBaocaomuahang(string a)
        {
            InitializeComponent();
            load_table(a);

        }
        private void load_table(string table)
        {
            switch (table)
            {
                case "bcmh":
                    {
                        string a = "bcmh";
                        EDCM2 u1 = new EDCM2(a);
                        u1.Dock = DockStyle.Fill;
                        panel1.Controls.Add(u1);
                        //statements 
                        break;
                    }
            }

        }

        private void FBaocaomuahang_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Form frm1 = Application.OpenForms["StartForm"];
                StartForm s = frm1 as StartForm;
                s.k--;
                if (s.k == 0)
                {

                    frm1.Show();

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
