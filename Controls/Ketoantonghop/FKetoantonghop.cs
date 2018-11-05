using DevExpress.LookAndFeel;
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
    public partial class FKetoantonghop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FKetoantonghop()
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }

        private void FKetoantonghop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E70PHKT' table. You can move, or remove it, as needed.
            this.e70PHKTTableAdapter.Fill(this.eWONDATASET.E70PHKT);

        }
    }
}
