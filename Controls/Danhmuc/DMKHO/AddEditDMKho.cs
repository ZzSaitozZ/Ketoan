using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;

namespace Ketoan.Controls.Danhmuc.DMKHO
{
    public partial class AddEditDMKHO : AddEditFrame
    { 
        public AddEditDMKHO(GridView gridview, bool isadd)
        {
            InitializeComponent();
            if (isAdd) this.Text = "Thêm mới";
            else this.Text = "Chỉnh sửa";
            Gridview = gridview;
            isAdd = isadd;
            ewErrorProvider1.SetIconAlignment(makhoTE, ErrorIconAlignment.MiddleRight);
            //Editvalue
            makhoTE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"].ToString();
            this.tenkhoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_kho"].ToString();
            this.makhoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"].ToString();
            this.sttTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"].ToString();
        }
       
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_kho"] = this.tenkhoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"] = this.makhoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"] = this.sttTE.Text;
            if (isAdd) Gridview.UpdateCurrentRow();
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void makhoTE_EditValueChanged(object sender, EventArgs e)
        {
            if (Gridview.LocateByValue("Ma_Kho", makhoTE.Text) < 0)
            {
                ewErrorProvider1.SetError(makhoTE, "", ErrorType.Information);
            }
            else
            {
                if (isAdd)
                    ewErrorProvider1.SetError(makhoTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                else
                {
                    if (makhoTE.EditValue.ToString() == makhoTE.Tag.ToString()) ewErrorProvider1.SetError(makhoTE, "", ErrorType.Information);
                    else ewErrorProvider1.SetError(makhoTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                }
            }
        }
    }
}
