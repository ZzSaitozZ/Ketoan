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

namespace Ketoan.Controls.Cpgiathanh
{
    public partial class Cpgiathanh : UserControl
    {
        public Cpgiathanh()
        {
            InitializeComponent();
            tbTabChinh.SelectedPageIndex = 0;
          //  ECPGT u1 = new ECPGT();

            ETHYT u1 = new ETHYT();
            //  u1.TopLevel = false;
            u1.Dock = DockStyle.Fill;
            pDetails.Controls.Add(u1);
        }

        bool flag1 = false;
        bool flag2 = false;
        private void tabPane1_Click(object sender, EventArgs e)
        {

        }

      

        

        private void tbTabChinh_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (e.Page == tbPhanBo)
            {
                if (flag1 == false)
                {
          
                    ECPGT u1 = new ECPGT();
                    //  u1.TopLevel = false;
                    u1.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u1);
                }
               
                    flag1 = true;
                

            }
            if (e.Page == tbTinhGia)
            {
                if (flag2 == false)
                {

                    ETGT u1 = new ETGT();
                    //  u1.TopLevel = false;
                    u1.Dock = DockStyle.Fill;
                    panel2.Controls.Add(u1);
                }

                flag2 = true;


            }
        }
    }
}