using DevExpress.LookAndFeel;
using System.Windows.Forms;

namespace Ketoan
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1(string a)
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rbiGallery, true);
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            load_table(a);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k--;
            if (s.k == 0)
            {
                frm1.Show();
            }
        }

        private void load_table(string table)
        {
            UserControl userCrl = null;
            switch (table)
            {
                case "DMBP":
                    {
                        userCrl = new Ketoan.Table.EDMBP();
                        break;
                    }
                case "DMKHO":
                    {
                        userCrl = new Ketoan.Table.EDMKHO();
                        break;
                    }
                    case "DMKM":
                    {
                        userCrl = new Ketoan.Table.EDMKM();
                        break;
                    }

                    case "DMKV":
                    {
                        userCrl = new Ketoan.Table.EDMKV();
                        break;
                    }
                    case "DMLO":
                    {
                        userCrl = new Ketoan.Table.EDMLO();
                        break;
                    }
                    case "DMNVU":
                    {
                        userCrl = new Ketoan.Table.EDMNVU();
                        break;
                    }
                    case "DMNHDT":
                    {
                        userCrl = new Ketoan.Table.EDMNHDT();
                        break;
                    }
                    case "DMNHHD":
                    {
                        userCrl = new Ketoan.Table.EDMNHHD();
                        break;
                    }

                    case "DMNHNHAN":
                    {
                        userCrl = new Ketoan.Table.EDMNHNHAN();
                        break;
                    }

                    case "DMNHVT":
                    {
                        userCrl = new Ketoan.Table.EDMNHVT();
                        break;
                    }
                    case "DMPLHD":
                    {
                        userCrl = new Ketoan.Table.EDMPLHD();
                        break;
                    }
                    case "DMTK":
                    {
                        userCrl = new Ketoan.Table.EDMTK();
                        break;
                    }
                    case "DMTHUE":
                    {
                        userCrl = new Ketoan.Table.EDMTHUE();
                        break;
                    }
                    case "DMYTCP":
                    {
                        userCrl = new Ketoan.Table.EDMYT();
                        break;
                    }
            }
            if (userCrl != null)
            {
                Tablearea.Controls.Add(userCrl);
            }
            else
            {
                MessageBox.Show("Couldn't found tables");
            }
        }
    }
}
