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

namespace Ketoan.Controls.Danhmuc.DMNVU
{
    public partial class AddEditDMNVU : AddEditFrame
    {
        public AddEditDMNVU (GridView gridview, bool isadd)
        {
            InitializeComponent();
            Gridview = gridview;
            isAdd = isadd;
            if (isAdd) this.Text = "Thêm mới";
            else this.Text = "Chỉnh sửa";


            ewErrorProvider1.SetIconAlignment(manvuTE, ErrorIconAlignment.MiddleRight);

            this.manvuTE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"].ToString();
            this.manvuTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"].ToString();
            this.tennvuTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nvu"].ToString();
            this.mactTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct"].ToString();
            this.mactruleTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct_Rule"].ToString();
            this.tknoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No"].ToString();
            this.tknoruleTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No_Rule"].ToString();
            this.tkcoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co"].ToString();
            this.tkcoruleTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co_Rule"].ToString();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"] = this.manvuTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nvu"] = this.tennvuTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct"] = this.mactTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct_Rule"] = this.mactruleTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No"] = this.tknoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No_Rule"] = this.tknoruleTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co"] = this.tkcoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co_Rule"] = this.tkcoruleTE.Text;
            if (isAdd) Gridview.UpdateCurrentRow();
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manvuTE_EditValueChanged(object sender, EventArgs e)
        {
            if (Gridview.LocateByValue("Ma_Nvu", manvuTE.Text) < 0)
            {
                ewErrorProvider1.SetError(manvuTE, "", ErrorType.Information);
            }
            else
            {
                if (isAdd)
                    ewErrorProvider1.SetError(manvuTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                else
                {
                    if (manvuTE.EditValue.ToString() == manvuTE.Tag.ToString()) ewErrorProvider1.SetError(manvuTE, "", ErrorType.Information);
                    else ewErrorProvider1.SetError(manvuTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                }
            }
        }
    }
}
