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

namespace Ketoan.Controls.Danhmuc.DMDT
{
    public partial class AddEditDMDT : AddEditFrame
    {        
        public AddEditDMDT(GridView gridview,string state)
        {
            InitializeComponent();
            this.Gridview = gridview;
            this.State = state;
            this.madtTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"].ToString();
            this.tenTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Dt"].ToString();
            this.manhomdtTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Dt"].ToString();
            this.ctyTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Cong_Ty"].ToString();
            this.diachiTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dia_Chi"].ToString();
            this.msthueTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_So_Thue"].ToString();
            this.tknhTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Tk_NH"].ToString();
            this.tennhTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_NH"].ToString();
            this.sdtTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Phone"].ToString();
        }
        protected GridView Gridview;
        protected string State;
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"] = this.madtTB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Dt"] = this.tenTB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Dt"]= this.manhomdtTB.Text ;
           Gridview.GetDataRow(Gridview.FocusedRowHandle)["Cong_Ty"] = this.ctyTB.Text  ;
           Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dia_Chi"] = this.diachiTB.Text ;
           Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_So_Thue"] = this.msthueTB.Text  ;
           Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Tk_NH"] = this.tknhTB.Text  ;
           Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_NH"]= this.tennhTB.Text ;
           Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Phone"] = this.sdtTB.Text ;
           if (State == "Add") Gridview.UpdateCurrentRow();
           this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
