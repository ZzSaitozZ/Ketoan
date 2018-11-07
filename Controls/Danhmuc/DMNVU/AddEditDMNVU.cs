using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMNVU
{
    public partial class AddEditDMNVU : AddEditFrame
    {
        public AddEditDMNVU(GridView gridview, bool isadd)
        {
            InitializeComponent();
            Gridview = gridview;
            isAdd = isadd;
            if (isAdd)
            {
                Text = "Thêm mới";
            }
            else
            {
                Text = "Chỉnh sửa";
            }

            ewErrorProvider1.SetIconAlignment(manvuTE, ErrorIconAlignment.MiddleRight);

            manvuTE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"].ToString();
            manvuTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"].ToString();
            tennvuTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nvu"].ToString();
            mactTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct"].ToString();
            mactruleTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct_Rule"].ToString();
            tknoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No"].ToString();
            tknoruleTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No_Rule"].ToString();
            tkcoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co"].ToString();
            tkcoruleTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co_Rule"].ToString();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nvu"] = manvuTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nvu"] = tennvuTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct"] = mactTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Ct_Rule"] = mactruleTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No"] = tknoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_No_Rule"] = tknoruleTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co"] = tkcoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk_Co_Rule"] = tkcoruleTE.Text;
            if (isAdd)
            {
                Gridview.UpdateCurrentRow();
            }

            Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            Close();
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
                {
                    ewErrorProvider1.SetError(manvuTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                }
                else
                {
                    if (manvuTE.EditValue.ToString() == manvuTE.Tag.ToString())
                    {
                        ewErrorProvider1.SetError(manvuTE, "", ErrorType.Information);
                    }
                    else
                    {
                        ewErrorProvider1.SetError(manvuTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                    }
                }
            }
        }
    }
}
