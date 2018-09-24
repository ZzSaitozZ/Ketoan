using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.PhanQuyen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool flagUser = false;
            bool flagPass = false;  
            string User = txtUser.Text;
         string Password = txtPass.Text;
            DataTable dt = new DataTable();
            dt = e005PHANQUYENTableAdapter1.GetData();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                string user = dr[1].ToString();
                if(User==user)
                {
                    flagUser = true;
                    break;
                }
                

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                string password = dr[2].ToString();

                if (Password == password)
                {
                    flagPass = true;
                    break;
                }

            }
            if (flagUser==true&&flagPass==true)
            {
                StartForm s = new StartForm();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người sử dụng hoặc mật khẩu sai vui lòng đăng nhập lại");
            }
        }
    }
}
