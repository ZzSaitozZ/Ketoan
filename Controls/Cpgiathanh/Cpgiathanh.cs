using Ketoan.Table;
using System.Windows.Forms;

namespace Ketoan.Controls.CpGiaThanh
{
    public partial class CpGiaThanh : UserControl
    {
        public CpGiaThanh()
        {
            InitializeComponent();
            tbTabChinh.SelectedPageIndex = 0;
            //  ECPGT u1 = new ECPGT();
            ETHYT u1 = new ETHYT
            {
                //  u1.TopLevel = false;
                Dock = DockStyle.Fill
            };
            pDetails.Controls.Add(u1);
        }

        private bool flag1 = false;
        private bool flag2 = false;
        private void tbTabChinh_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (e.Page == tbPhanBo)
            {
                if (flag1 == false)
                {
                    ECPGT u1 = new ECPGT
                    {
                        //  u1.TopLevel = false;
                        Dock = DockStyle.Fill
                    };
                    panel1.Controls.Add(u1);
                }
                flag1 = true;
            }
            if (e.Page == tbTinhGia)
            {
                if (flag2 == false)
                {
                    ETGT u1 = new ETGT
                    {
                        //  u1.TopLevel = false;
                        Dock = DockStyle.Fill
                    };
                    panel2.Controls.Add(u1);
                }
                flag2 = true;
            }
        }
    }
}