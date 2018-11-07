using DevExpress.LookAndFeel;
using System;

namespace Ketoan.Controls.KeToanTongHop
{
    public partial class FKeToanTongHop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FKeToanTongHop()
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }

        private void FKeToanTongHop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E70PHKT' table. You can move, or remove it, as needed.
            e70PHKTTableAdapter.Fill(eWONDATASET.E70PHKT);
        }
    }
}
