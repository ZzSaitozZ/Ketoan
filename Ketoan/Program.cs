using System;
using System.Windows.Forms;

namespace Ketoan
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FThemHoaDon s = new FThemHoaDon();
            //Ketoan.Controls.DanhMuc.DMBANGGIA.DMBANGGIA e = new Controls.DanhMuc.DMBANGGIA.DMBANGGIA();
            StartForm e = new StartForm();
            //s.Tag = 0;
            //Login login = new Login();
            Application.Run(e);
        }
    }
}
