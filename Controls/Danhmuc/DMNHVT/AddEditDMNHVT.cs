using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;

namespace Ketoan.Controls.Danhmuc.DMNHVT
{
    public partial class AddEditDMNHVT : AddEditFrame
    {
        protected GridView Gridview;
        public AddEditDMNHVT(GridView gridview, bool isadd)
        {
            InitializeComponent();
            Gridview = gridview;
            isAdd = isadd;
            if (isAdd) this.Text = "Thêm mới";
            else this.Text = "Chỉnh sửa";


            ewErrorProvider1.SetIconAlignment(manhTE, ErrorIconAlignment.MiddleRight);

            this.manhTE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"].ToString();
            this.manhTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"].ToString();
            this.tennhTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nh_Vt"].ToString();
            this.nhparentTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt_Parent"].ToString();
            this.loaiCBE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Loai_Nh_Vt"].ToString();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"] = this.manhTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Nh_Vt"] = this.tennhTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt_Parent"] = this.nhparentTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Loai_Nh_Vt"] = this.loaiCBE.Text;
            if (isAdd) Gridview.UpdateCurrentRow();
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    ewErrorProvider1.SetError(manhTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                else
                {
                    if (manhTE.EditValue.ToString() == manhTE.Tag.ToString()) ewErrorProvider1.SetError(manhTE, "", ErrorType.Information);
                    else ewErrorProvider1.SetError(manhTE, "Giá trị này đã có trong Danh Mục Bảng Giá", ErrorType.Information);
                }
            }
        }
    }
}
