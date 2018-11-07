using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMKHO
{
    public partial class AddEditDMKHO : AddEditFrame
    {
        public AddEditDMKHO(GridView gridview, bool isadd)
        {
            InitializeComponent();
            if (isAdd)
            {
                Text = "Thêm mới";
            }
            else
            {
                Text = "Chỉnh sửa";
            }

            Gridview = gridview;
            isAdd = isadd;
            ewErrorProvider1.SetIconAlignment(makhoTE, ErrorIconAlignment.MiddleRight);
            //Editvalue
            makhoTE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"].ToString();
            tenkhoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_kho"].ToString();
            makhoTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"].ToString();
            sttTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"].ToString();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_kho"] = tenkhoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"] = makhoTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Stt"] = sttTE.Text;
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

        private void makhoTE_EditValueChanged(object sender, EventArgs e)
        {
            if (Gridview.LocateByValue("Ma_Kho", makhoTE.Text) < 0)
            {
                ewErrorProvider1.SetError(makhoTE, "", ErrorType.Information);
            }
            else
            {
                if (isAdd)
                {
                    ewErrorProvider1.SetError(makhoTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                }
                else
                {
                    if (makhoTE.EditValue.ToString() == makhoTE.Tag.ToString())
                    {
                        ewErrorProvider1.SetError(makhoTE, "", ErrorType.Information);
                    }
                    else
                    {
                        ewErrorProvider1.SetError(makhoTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                    }
                }
            }
        }
    }
}
