using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ketoan.Controls.BanHangPhaiThu;
using Ketoan.Controls.Danhmuc.DMDT;
using Ketoan.Controls.Danhmuc.DMBANGGIA;
using Ketoan.Controls.Danhmuc.DMVTTS;
using Ketoan.Controls.Danhmuc.DMVT;
using Ketoan.Controls.Danhmuc.DMTK;
using Ketoan.Controls.Danhmuc.DMNVU;
using Ketoan.Controls.Danhmuc.DMKHO;
using Ketoan.Controls.Danhmuc.DMKM;
using Ketoan.Controls.Danhmuc.DMKV;
using Ketoan.Controls.Danhmuc.DMNHCCDC;
using Ketoan.Controls.Danhmuc.DMNHDT;
using Ketoan.Controls.Danhmuc.DMNHNV;
using Ketoan.Controls.Danhmuc.DMNHSP;
using Ketoan.Controls.Danhmuc.DMNHVT;
using Ketoan.Controls.Danhmuc.DMNV;

namespace Ketoan.Controls
{
    public partial class Muahangphaitra : UserControl
    {
        public Muahangphaitra()
        {
            InitializeComponent();
        }
        private void galleryControl2_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            string MenuBtn = string.Format("{0}", e.Item.Tag);
            Form frm1 = Application.OpenForms["StartForm"];
            StartForm s = frm1 as StartForm;
            s.k++;
            #region Danh muc
            if (MenuBtn.Contains("DMDT"))
            {
                DMDT frm = new DMDT();
                frm.Text = "Danh mục đối tượng";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMKHO"))
            {
                //string a = "DMKHO";
                DMKHO frm = new DMKHO();
                frm.Text = "Danh mục kho";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMKM"))
            {
                DMKM frm = new DMKM();
                frm.Text = "Danh mục khoản mục";
                frm.Show();
                frm1.Hide();
            }

            else if (MenuBtn.Contains("DMKV"))
            {
                DMKV frm = new DMKV();
                frm.Text = "Danh mục khu vực";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHCCDC"))
            {
                DMNHCCDC frm = new DMNHCCDC();
                frm.Text = "Danh mục nhóm công cụ dụng cụ";
                frm.Show();
                frm1.Hide();


            }
            else if (MenuBtn.Contains("DMNDT"))
            {
                DMNHDT frm = new DMNHDT();
                frm.Text = "Danh mục nhóm đối tượng";
                frm.Show();
                frm1.Hide();

            }
            else if (MenuBtn.Contains("DMNHNV"))
            {
                DMNHNV frm = new DMNHNV();
                frm.Text = "Danh mục nhóm nhân viên";
                frm.Show();
                frm1.Hide();


            }
            else if (MenuBtn.Contains("DMNHSP"))
            {
                DMNHSP frm = new DMNHSP();
                frm.Text = "Danh mục nhóm sản phẩm";
                frm.Show();
                frm1.Hide();

            }
            else if (MenuBtn.Contains("DMNHVT"))
            {

                DMNHVT frm = new DMNHVT();
                frm.Text = "Danh mục nhóm vật tư";
                frm.Show();
                frm1.Hide();


            }
            else if (MenuBtn.Contains("DMNV"))
            {
                DMNV frm = new DMNV();
                frm.Text = "Danh mục nhóm vật tư";
                frm.Show();
                frm1.Hide();

            }
            else if (MenuBtn.Contains("DMNVU"))
            {
                DMNVU frm = new DMNVU();
                frm.Text = "Danh mục nghiệp vụ";
                frm.Show();
                frm1.Hide();


            }
            else if (MenuBtn.Contains("DMTK"))
            {
                DMTK frm = new DMTK();
                frm.Text = "Danh mục tài khoản";
                frm.Show();
                frm1.Hide();



            }
            else if (MenuBtn.Contains("DMVT"))
            {
                DMVT frm = new DMVT();
                frm.Text = "Danh mục vật tư";
                frm.Show();
                frm1.Hide();


            }
            else if (MenuBtn.Contains("DMVTTS"))
            {
                DMVTTS frm = new DMVTTS();
                frm.Text = "Danh mục vật tư tài sản";
                frm.Show();
                frm1.Hide();


            }
            #endregion


        }
    }
}
