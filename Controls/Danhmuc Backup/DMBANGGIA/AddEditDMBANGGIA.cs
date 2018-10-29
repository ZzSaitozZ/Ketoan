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
using DevExpress.XtraEditors.DXErrorProvider;
using System.Reflection;

namespace Ketoan.Controls.Danhmuc.DMBANGGIA
{    
    public partial class AddEditDMBANGGIA : AddEditFrame
    {
      

        public AddEditDMBANGGIA(GridView gridview, bool isadd)
        {
            InitializeComponent();
            if (isAdd) this.Text = "Thêm mới";
            else this.Text = "Chỉnh sửa";
            Gridview = gridview;
            isAdd = isadd;
            
            this.e00DMVTTableAdapter.Fill(this.eWONDATASET.E00DMVT);                        
            ewErrorProvider1.SetIconAlignment(mavtLUE, ErrorIconAlignment.MiddleRight);                      
            //Initial mavtLUE
            mavtLUE.Properties.ForceInitialize();


            if (!isAdd) //!isNew  is Edit
            {
                //Use Tag property as old value for Edit scenario
                mavtLUE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Vt"].ToString();
                mavtLUE.ItemIndex = mavtLUE.Properties.GetDataSourceRowIndex("Ma_Vt", mavtLUE.Tag.ToString());
            }
            else mavtLUE.ItemIndex = 0;

            //giaTE
            this.giaTE.EditValue = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Gia"].ToString();
                  
        }       

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Vt"] = this.mavtLUE.Text;               
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Gia"] = this.giaTE.Text;
            if (isAdd)  Gridview.UpdateCurrentRow();
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void mavtLUE_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView s = (DataRowView)mavtLUE.GetSelectedDataRow();
            this.vtLB.Text = s["Ma_Vt"].ToString();
            if (Gridview.LocateByValue("Ma_Vt", mavtLUE.EditValue) < 0)
            {
                ewErrorProvider1.SetError(mavtLUE, "", ErrorType.Information);
            }
            else
            {
                if (isAdd)
                    ewErrorProvider1.SetError(mavtLUE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                else
                {
                    if (mavtLUE.EditValue.ToString() == mavtLUE.Tag.ToString()) ewErrorProvider1.SetError(mavtLUE, "", ErrorType.Information);
                    else ewErrorProvider1.SetError(mavtLUE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                }
            }
        }
        

        private void giaTE_EditValueChanged(object sender, EventArgs e)
        {
            if (giaTE.EditValue.ToString() == "") { giaTE.EditValue = "1000";  }
        }

    }
}
