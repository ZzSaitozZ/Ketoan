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
            if(s.k ==0)
            {
                frm1.Show();
            }       
        }
        private void load_table(string table)
        {
            if (table == "DMBP")
            {
                Ketoan.Table.EDMBP DMBP = new Ketoan.Table.EDMBP();
                DMBP.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMBP);
            }
            else if (table == "DMKHO")
            {
                Ketoan.Table.EDMKHO DMKHO = new Ketoan.Table.EDMKHO();
                DMKHO.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKHO);
            }
            else if (table == "DMKM")
            {
                Ketoan.Table.EDMKM DMKM = new Ketoan.Table.EDMKM();
                DMKM.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKM);
            }

            else if (table == "DMKV")
            {
                Ketoan.Table.EDMKV DMKV = new Ketoan.Table.EDMKV();
                DMKV.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKV);
            }
            else if (table == "DMLO")
            {
                Ketoan.Table.EDMLO DMLO = new Ketoan.Table.EDMLO();
                DMLO.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMLO);
            }
            else if (table == "DMNVU")
            {
                Ketoan.Table.EDMNVU DMNVU = new Ketoan.Table.EDMNVU();
                DMNVU.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNVU);
            }


            else if (table == "DMNHDT")
            {
                Ketoan.Table.EDMNHDT DMNHDT = new Ketoan.Table.EDMNHDT();
                DMNHDT.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNHDT);
            }
            else if (table == "DMNHHD")
            {
                Ketoan.Table.EDMNHHD DMNHHD = new Ketoan.Table.EDMNHHD();
                DMNHHD.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNHHD);
            }

            else if (table == "DMNHNHAN")
            {
                Ketoan.Table.EDMNHNHAN EDMNHNHAN = new Ketoan.Table.EDMNHNHAN();
                EDMNHNHAN.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(EDMNHNHAN);
            }
          
            else if (table == "DMNHVT")
            {
                Ketoan.Table.EDMNHVT DMNHVT = new Ketoan.Table.EDMNHVT();
                DMNHVT.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNHVT);
            }
            else if (table == "DMPLHD")
            {
                Ketoan.Table.EDMPLHD DMPLHD = new Ketoan.Table.EDMPLHD();
                DMPLHD.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMPLHD);
            }
            else if (table == "DMTK")
            {
                Ketoan.Table.EDMTK DMTK = new Ketoan.Table.EDMTK();
                DMTK.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMTK);
            }
            else if (table == "DMTHUE")
            {
                Ketoan.Table.EDMTHUE DMTHUE = new Ketoan.Table.EDMTHUE();
                DMTHUE.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMTHUE);
            }
            else if (table == "DMKV")
            {
                Ketoan.Table.EDMKV DMKV = new Ketoan.Table.EDMKV();
                DMKV.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKV);
            }
            else if (table == "DMYTCP")
            {
                Ketoan.Table.EDMYT DMYT = new Ketoan.Table.EDMYT();
                DMYT.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMYT);
            }
        }

    }
}
