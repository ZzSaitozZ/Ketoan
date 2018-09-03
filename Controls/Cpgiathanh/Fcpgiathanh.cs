using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Cpgiathanh
{
    public partial class FKhaibaodinhmucsp : Form
    {
        public FKhaibaodinhmucsp()
        {
            InitializeComponent();
        }

        private void Fcpgiathanh_Load(object sender, EventArgs e)
        {
                Cpgiathanh u1 = new Cpgiathanh();
                u1.Dock = DockStyle.Fill;
                panelDetails.Controls.Add(u1);

        }

        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fcpgiathanh_FormClosing(object sender, FormClosingEventArgs e)
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
