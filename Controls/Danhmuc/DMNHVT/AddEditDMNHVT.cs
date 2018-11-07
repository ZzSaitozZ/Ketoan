using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMNHVT
{
    public partial class AddEditDMNHVT : AddEditFrame
    {
        protected GridView Gridview;
        public AddEditDMNHVT(GridView gridview, bool isadd)
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

            ewErrorProvider1.SetIconAlignment(manhTE, ErrorIconAlignment.MiddleRight);

            manhTE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"].ToString();
            manhTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"].ToString();
            tennhTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nh_Vt"].ToString();
            nhparentTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt_Parent"].ToString();
            loaiCBE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Loai_Nh_Vt"].ToString();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"] = manhTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nh_Vt"] = tennhTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt_Parent"] = nhparentTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Loai_Nh_Vt"] = loaiCBE.Text;
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

        private void manhTE_EditValueChanged(object sender, EventArgs e)
        {
            if (Gridview.LocateByValue("Ma_Nh_Vt", manhTE.Text) < 0)
            {
                ewErrorProvider1.SetError(manhTE, "", ErrorType.Information);
            }
            else
            {
                if (isAdd)
                {
                    ewErrorProvider1.SetError(manhTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                }
                else
                {
                    if (manhTE.EditValue.ToString() == manhTE.Tag.ToString())
                    {
                        ewErrorProvider1.SetError(manhTE, "", ErrorType.Information);
                    }
                    else
                    {
                        ewErrorProvider1.SetError(manhTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                    }
                }
            }
        }
    }
}
