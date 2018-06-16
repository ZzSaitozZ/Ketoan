using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls
{
    public partial class Hangtonkho : UserControl
    {
        public Hangtonkho()
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
            if (MenuBtn.Contains("DMBP"))
            {
                string a = "DMBP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục bộ phận";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMKHO"))
            {
                //string a = "DMKHO";
                //Form1 frm = new Form1(a);
                //frm.Text = "Danh mục kho";
                //frm.Show();
                //frm1.Hide();
            }
            else if (MenuBtn.Contains("DMKM"))
            {
                //string a = "DMKM";
                //Form1 frm = new Form1(a);
                //frm.Text = "Danh mục khoản mục";
                //frm.Show();
                //frm1.Hide();
            }
            else if (MenuBtn.Contains("DMKTHU"))
            {
                //string a = "DMKM";
                //Form1 frm = new Form1(a);
                //frm.Text = "Danh mục khoản thu";
                //frm.Show();
                //frm1.Hide();
            }
            else if (MenuBtn.Contains("DMKV"))
            {
                string a = "DMKV";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục khu vực";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMLO"))
            {
                string a = "DMLO";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục lô";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNVU"))
            {
                string a = "DMNVU";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nghiệp vụ";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNVON"))
            {
                string a = "DMNVON";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nguồn vốn";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHTP"))
            {
                string a = "DMNHTP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhãn thành phẩm";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHCCDC"))
            {
                string a = "DMNHCCDC";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm CCDC";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHDT"))
            {
                string a = "DMNHDT";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm đối tượng";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHHD"))
            {
                string a = "DMNHHD";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm hợp đồng";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHNV"))
            {
                string a = "DMNHNV";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm nhân viên";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHSP"))
            {
                string a = "DMNHSP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm sản phẩm";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHTS"))
            {
                string a = "DMNHTS";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm tài sản";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMNHVT"))
            {
                string a = "DMNHVT";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục nhóm vật tư";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMPL"))
            {
                string a = "DMPL";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục phân loại";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMTK"))
            {
                string a = "DMTK";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục tài khoản";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMTHUE"))
            {
                string a = "DMTHUE";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục thuế";
                frm.Show();
                frm1.Hide();
            }
            else if (MenuBtn.Contains("DMYTCP"))
            {
                string a = "DMYTCP";
                Form1 frm = new Form1(a);
                frm.Text = "Danh mục yếu tố chi phí";
                frm.Show();
                frm1.Hide();
            }
            #endregion
        }
    }
}
