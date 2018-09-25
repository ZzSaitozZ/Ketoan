using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace Ketoan.Controls.Danhmuc.DMKho
{
    public partial class AddEditDMKho : AddEditFrame
    { 
        public AddEditDMKho(GridView gridview, string state)
        {
            InitializeComponent();
            this.Gridview = gridview;
            this.State = state;
            this.tenkhoTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_kho"].ToString();
            this.makhoTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"].ToString();
            this.sttTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"].ToString();
        }
        protected GridView Gridview;
        protected string State;
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_kho"] = this.tenkhoTB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"] = this.makhoTB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"] = this.sttTB.Text;
            if (State == "Add") Gridview.UpdateCurrentRow();
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
