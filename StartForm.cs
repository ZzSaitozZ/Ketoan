using Ketoan.Controls.BanHangPhaiThu;
using Ketoan.Controls.CpGiaThanh;
using Ketoan.Controls.DanhMuc.DMDT;
using Ketoan.Controls.DanhMuc.DMKHO;
using Ketoan.Controls.DanhMuc.DMKM;
using Ketoan.Controls.DanhMuc.DMKV;
using Ketoan.Controls.DanhMuc.DMNHCCDC;
using Ketoan.Controls.DanhMuc.DMNHDT;
using Ketoan.Controls.DanhMuc.DMNHNV;
using Ketoan.Controls.DanhMuc.DMNHSP;
using Ketoan.Controls.DanhMuc.DMNHVT;
using Ketoan.Controls.DanhMuc.DMNV;
using Ketoan.Controls.DanhMuc.DMNVU;
using Ketoan.Controls.DanhMuc.DMTK;
using Ketoan.Controls.DanhMuc.DMVT;
using Ketoan.Controls.DanhMuc.DMVTTS;
using Ketoan.Controls.HangTonKho.PhieuNhapThanhPham;
using Ketoan.Controls.MenuChinh;
using Ketoan.Controls.VonBangTien.PhieuThuChi;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ketoan
{
    public partial class StartForm : Form
    {
        //Point lastClick;
        private VonBangTien vonbangtien;
        private BanHangPhaiThu banhangphaithu;
        private ChiPhiGiaThanh chiphigiathanh;
        private HangTonKho hangtonkho;
        private HeThong hethong;
        private KeToanTongHop ketoantonghop;
        private MuaHangPhaiTra muahangphaitra;
        private QuanLyTaiSan quanlytaisan;
        public int k =0;
        public StartForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            if (vonbangtien == null)
            {
                vonbangtien = new VonBangTien();
            }
            DetailPanel.Controls.Add(vonbangtien);
        }

        #region Moveable and expandable windown
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
            rc = new Rectangle(0, 0, ClientSize.Width, cCaption);
            //e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        #region button event
        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Maxbutton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Minbutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void VBTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (vonbangtien == null)
            {
                vonbangtien = new VonBangTien();
            }
            DetailPanel.Controls.Add(vonbangtien);
        }

        private void MHPTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (muahangphaitra == null)
            {
                muahangphaitra = new MuaHangPhaiTra();
            }
            DetailPanel.Controls.Add(muahangphaitra);
        }

        private void BHPTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (banhangphaithu == null)
            {
                banhangphaithu = new BanHangPhaiThu();
            }
            DetailPanel.Controls.Add(banhangphaithu);
        }

        private void HTKbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (hangtonkho == null)
            {
                hangtonkho = new HangTonKho();
            }
            DetailPanel.Controls.Add(hangtonkho);
        }

        private void QLTSbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (quanlytaisan == null)
            {
                quanlytaisan = new QuanLyTaiSan();
            }
            DetailPanel.Controls.Add(quanlytaisan);
        }

        private void CPGTbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (chiphigiathanh == null)
            {
                chiphigiathanh = new ChiPhiGiaThanh();
            }
            DetailPanel.Controls.Add(chiphigiathanh);
        }

        private void KTTHbtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (ketoantonghop == null)
            {
                ketoantonghop = new KeToanTongHop();
            }
            DetailPanel.Controls.Add(ketoantonghop);
        }

        private void Systembtn_Click(object sender, EventArgs e)
        {
            DetailPanel.Controls.Clear();
            if (hethong == null)
            {
                hethong = new HeThong();
            }
            DetailPanel.Controls.Add(hethong);
        }
        #endregion

        #region Danh Muc
        public void showFormDanhMuc(string nameTag)
        {
            k++;
            Form frm = null;
            switch (nameTag)
            {
                #region Danh Muc Chung
                case "DMDT":
                    {
                        frm = new DMDT
                        {
                            Text = "Danh mục đối tượng"
                        };
                        break;
                    }
                case "DMKHO":
                    {
                        frm = new DMKHO
                        {
                            Text = "Danh mục kho"
                        };
                        break;
                    }
                case "DMKM":
                    {
                        frm = new DMKM
                        {
                            Text = "Danh mục khoản mục"
                        };
                        break;
                    }
                case "DMKV":
                    {
                        frm = new DMKV
                        {
                            Text = "Danh mục khu vực"
                        };
                        break;
                    }
                case "DMNHCCDC":
                    {
                        frm = new DMNHCCDC
                        {
                            Text = "Danh mục nhóm công cụ dụng cụ"
                        };
                        break;
                    }
                case "DMNDT":
                    {
                        frm = new DMNHDT
                        {
                            Text = "Danh mục nhóm đối tượng"
                        };
                        break;
                    }
                case "DMNHNV":
                    {
                        frm = new DMNHNV
                        {
                            Text = "Danh mục nhóm nhân viên"
                        };
                        break;
                    }
                case "DMNHSP":
                    {
                        frm = new DMNHSP
                        {
                            Text = "Danh mục nhóm sản phẩm"
                        };
                        break;
                    }
                case "DMNHVT":
                    {
                        frm = new DMNHVT
                        {
                            Text = "Danh mục nhóm vật tư"
                        };
                        break;
                    }
                case "DMNV":
                    {
                        frm = new DMNV
                        {
                            Text = "Danh mục nhóm vật tư"
                        };
                        break;
                    }
                case "DMNVU":
                    {
                        frm = new DMNVU
                        {
                            Text = "Danh mục nghiệp vụ"
                        };
                        break;
                    }
                case "DMTK":
                    {
                        frm = new DMTK
                        {
                            Text = "Danh mục tài khoản"
                        };
                        break;
                    }
                case "DMVT":
                    {
                        frm = new DMVT
                        {
                            Text = "Danh mục vật tư"
                        };
                        break;
                    }
                case "DMVTTS":
                    {
                        frm = new DMVTTS
                        {
                            Text = "Danh mục vật tư tài sản"
                        };
                        break;
                    }
                #endregion

                #region BanHangPhaiThu
                case "bcmh":
                    {
                        frm = new FBaoCaoMuaHang("bcmh")
                        {
                            Text = "Báo cáo bán hàng"
                        };
                        break;
                    }
                case "HDBH":
                    {
                        frm = new FBanHangPhaiThu
                        {
                            Text = "Bán hàng phải thu"
                        };
                        break;
                    }
                #endregion

                #region CpGiaThanh
                case "tgtp":
                    {
                        frm = new FKhaiBaoDinhMucSp();
                        break;
                    }
                #endregion

                #region HangTonKho.PhieuNhapThanhPham
                case "PNHAPTP":
                    {
                        frm = new FrPhieuNhapThanhPham
                        {
                            Text = "Phiếu nhập thành phẩm"
                        };
                        break;
                    }
                #endregion

                #region VonBangTien.PhieuThuChi
                case "PT":
                    {
                        frm = new FormPhieuThu("PT")
                        {
                            Text = "Phiếu thu"
                        };
                        break;
                    }
                case "PC":
                    {
                        frm = new FormPhieuThu("PC")
                        {
                            Text = "Phiếu chi"
                        };
                        break;
                    }
                case "BC":
                    {
                        frm = new FormPhieuThu("BC")
                        {
                            Text = "Báo có ngân hàng"
                        };
                        break;
                    }
                case "BN":
                    {
                        frm = new FormPhieuThu("BN")
                        {
                            Text = "Báo nợ ngân hàng"
                        };
                        break;
                    }
                #endregion
            }
            if (frm != null)
            {
                frm.Show();
                Hide();
            }
        }
        #endregion
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
