using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ketoan.Table;
using Ketoan.Controls.Ketoantonghop;
using Ketoan.Controls.Hangtonkho.Baocao.Bangke;
using Ketoan.Controls.BanHangPhaiThu;

namespace Ketoan.Controls.Dungchung.Menu
{
    public partial class EDCMenu : UserControl
    {
        public EDCMenu()
        { 
           
          
        }
        public EDCMenu(string tungay, string denngay, string loaibaocao)
        {
            InitializeComponent();

            load_table(tungay, denngay, loaibaocao);
        }
        private void load_table(string tungay, string denngay, string loaibaocao)
        {
            switch (loaibaocao)
            {
                case "Báo cáo doanh thu bán hàng":
                    {

                        baocaodoanhthu u4 = new baocaodoanhthu(tungay, denngay);
                        u4.Dock = DockStyle.Fill;
                        panel1.Controls.Add(u4);

                        break;
                    }
            }



        }
        public EDCMenu(string a)
        {
            InitializeComponent();
            buttoanketchuyen u1 = new buttoanketchuyen();
            u1.Dock = DockStyle.Fill;
          //  panel1.Controls.Add(u1);

           
            load_table(a);
        }
        private void load_table(string table)
        {
            switch (table)
            {
                case "btkc":

                    buttoanketchuyen u1 = new buttoanketchuyen();
                    u1.Dock = DockStyle.Fill;
                    panel1.Controls.Add(u1);
                    //statements 
                    break;
             
          //      default:
                    //optional 
                    //statements 
            }
            
        }


        private void EDCMenu_Load(object sender, EventArgs e)
        {

        }
    }
}