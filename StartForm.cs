﻿using System;
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
    public partial class StartForm : Form
    {
        //Point lastClick;
        Ketoan.Controls.Vonbangtien vonbangtien = new Ketoan.Controls.Vonbangtien();
        Ketoan.Controls.Banhangphaithu banhangphaithu = new Ketoan.Controls.Banhangphaithu();
        Ketoan.Controls.Chiphigiathanh chiphigiathanh = new Ketoan.Controls.Chiphigiathanh();
        Ketoan.Controls.Hangtonkho hangtonkho = new Ketoan.Controls.Hangtonkho();
        Ketoan.Controls.Hethong hethong = new Ketoan.Controls.Hethong();
        Ketoan.Controls.Ketoantonghop ketoantonghop = new Ketoan.Controls.Ketoantonghop();
        Ketoan.Controls.Muahangphaitra muahangphaitra = new Ketoan.Controls.Muahangphaitra();
        Ketoan.Controls.Quanlytaisan quanlytaisan = new Ketoan.Controls.Quanlytaisan();
        public StartForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            vonbangtien.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(vonbangtien);
        }
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            //e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maxbutton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minbutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void VBTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            vonbangtien.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(vonbangtien);
            
        }

        private void MHPTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            muahangphaitra.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(muahangphaitra);
        }

        private void BHPTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            banhangphaithu.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(banhangphaithu);
        }

        private void HTKbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            hangtonkho.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(hangtonkho);
        }

        private void QLTSbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            quanlytaisan.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(quanlytaisan);
        }

        private void CPGTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            chiphigiathanh.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(chiphigiathanh);
        }

        private void KTTHbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            ketoantonghop.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(ketoantonghop);
        }

        private void Systembtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            hethong.Dock = DockStyle.Fill;
            DetailPanel.Controls.Add(hethong);
        }




        //Moveable panel
        //private void Titlepanel_MouseDown(object sender, MouseEventArgs e)
        //{
        //    lastClick = e.Location;
        //}

        //private void Titlepanel_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        this.Left += e.X - lastClick.X;
        //        this.Top += e.Y - lastClick.Y;
        //    }
        //}
    }
}
