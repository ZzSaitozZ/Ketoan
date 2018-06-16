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
                Ketoan.Table.R81DMBP DMBP = new Ketoan.Table.R81DMBP();
                DMBP.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMBP);
            }
            else if (table == "DMKHO")
            {
                Ketoan.Table.R81DMKHO DMKHO = new Ketoan.Table.R81DMKHO();
                DMKHO.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKHO);
            }
            else if (table == "DMKM")
            {
                Ketoan.Table.R81DMKM DMKM = new Ketoan.Table.R81DMKM();
                DMKM.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKM);
            }
            else if (table == "DMKTHU")
            {
                Ketoan.Table.R81DMKM DMKM = new Ketoan.Table.R81DMKM();
                DMKM.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKM);
            }
            else if (table == "DMKV")
            {
                Ketoan.Table.R81DMKV DMKV = new Ketoan.Table.R81DMKV();
                DMKV.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMKV);
            }
            else if (table == "DMLO")
            {
                Ketoan.Table.R81DMLO DMLO = new Ketoan.Table.R81DMLO();
                DMLO.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMLO);
            }
            else if (table == "DMNVU")
            {
                Ketoan.Table.R81DMNVU DMNVU = new Ketoan.Table.R81DMNVU();
                DMNVU.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNVU);
            }
            else if (table == "DMNVON")
            {
                //Ketoan.Table.R81DMNVON DMNVON = new Ketoan.Table.R81DMNVON();
                //DMNVON.Dock = DockStyle.Fill;
                //Tablearea.Controls.Add(DMNVON);
            }
            else if (table == "DMNHTP")
            {
                //Ketoan.Table.R81DMNVU DMNVU = new Ketoan.Table.R81DMNVU();
                //DMNVU.Dock = DockStyle.Fill;
                //Tablearea.Controls.Add(DMNVU);
            }
            else if (table == "DMNHCCDC")
            {
                //Ketoan.Table.R81DMNVU DMNVU = new Ketoan.Table.R81DMNVU();
                //DMNVU.Dock = DockStyle.Fill;
                //Tablearea.Controls.Add(DMNVU);
            }
            else if (table == "DMNHDT")
            {
                Ketoan.Table.R81DMNHDT DMNHDT = new Ketoan.Table.R81DMNHDT();
                DMNHDT.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNHDT);
            }
            else if (table == "DMNHHD")
            {
                Ketoan.Table.R81DMNHHD DMNHHD = new Ketoan.Table.R81DMNHHD();
                DMNHHD.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNHHD);
            }
            else if (table == "DMNHNV")
            {
                //Ketoan.Table.R81DMNVU DMNVU = new Ketoan.Table.R81DMNVU();
                //DMNVU.Dock = DockStyle.Fill;
                //Tablearea.Controls.Add(DMNVU);
            }
            else if (table == "DMNHSP")
            {
                //Ketoan.Table.R81DMNVU DMNVU = new Ketoan.Table.R81DMNVU();
                //DMNVU.Dock = DockStyle.Fill;
                //Tablearea.Controls.Add(DMNVU);
            }
            else if (table == "DMNHTS")
            {
                //Ketoan.Table.R81DMNVU DMNVU = new Ketoan.Table.R81DMNVU();
                //DMNVU.Dock = DockStyle.Fill;
                //Tablearea.Controls.Add(DMNVU);
            }
            else if (table == "DMNHVT")
            {
                Ketoan.Table.R81DMNHVT DMNHVT = new Ketoan.Table.R81DMNHVT();
                DMNHVT.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMNHVT);
            }
            else if (table == "DMPL")
            {
                //Ketoan.Table.R81DMNVU DMNVU = new Ketoan.Table.R81DMNVU();
                //DMNVU.Dock = DockStyle.Fill;
                //Tablearea.Controls.Add(DMNVU);
            }
            else if (table == "DMTK")
            {
                Ketoan.Table.R81DMTK DMTK = new Ketoan.Table.R81DMTK();
                DMTK.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMTK);
            }
            else if (table == "DMTHUE")
            {
                Ketoan.Table.R81DMTHUE DMTHUE = new Ketoan.Table.R81DMTHUE();
                DMTHUE.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMTHUE);
            }
            else if (table == "DMYTCP")
            {
                Ketoan.Table.R07DMYT DMYT = new Ketoan.Table.R07DMYT();
                DMYT.Dock = DockStyle.Fill;
                Tablearea.Controls.Add(DMYT);
            }
        }
       
    }
}
