using Ketoan.Controls.BanHangPhaiThu;
using Ketoan.Controls.PhanQuyen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FThemHoaDon s = new FThemHoaDon();
            s.Tag = 0;
            Login login = new Login();
            Application.Run(login);
        }
    }
}
