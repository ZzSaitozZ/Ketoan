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
private void login()
        {
            bool flagUser = false;
            bool flagPass = false;
            string User = txtUser.Text;
            string Password = txtPass.Text;
            DataTable dt = new DataTable();
            dt = e005PHANQUYENTableAdapter1.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                string user = dr[0].ToString();
                if (User == user)
                {
                    flagUser = true;
                }
                string password = dr[1].ToString();

                if (Password == password)
                {
                    flagPass = true;

                }


            }
            if (flagUser == true && flagPass == true)
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
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }
    }
}
