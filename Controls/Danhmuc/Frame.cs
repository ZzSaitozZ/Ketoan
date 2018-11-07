using DevExpress.LookAndFeel;

namespace Ketoan.Controls.DanhMuc
{
    public partial class Frame : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frame()
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }
    }
}
