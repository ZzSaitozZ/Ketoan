
using Ketoan.Controls.Dungchung.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ketoan.Controls.Hangtonkho.Baocao.Bangke
{
    public partial class FBangkebanhang : Form
    {
        public FBangkebanhang(string tungay,string denngay,string baocao)
        {
            InitializeComponent();
            EDCMenu f = new EDCMenu(tungay, denngay,baocao);
            f.Dock = DockStyle.Fill;
            panel1.Controls.Add(f);

        }
    }
}
