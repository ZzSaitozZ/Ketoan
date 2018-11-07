using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMDT
{
    public partial class AddEditDMDT : AddEditFrame
    {
        public AddEditDMDT(GridView gridview, bool isadd)
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

            e00DMNHDTTableAdapter.Fill(eWONDATASET.E00DMNHDT);
            ewErrorProvider1.SetIconAlignment(manhdtLUE, ErrorIconAlignment.MiddleRight);
            ewErrorProvider1.SetIconAlignment(tenTE, ErrorIconAlignment.MiddleRight);
            ewErrorProvider1.SetIconAlignment(madtTE, ErrorIconAlignment.MiddleRight);

            if (!isAdd)
            {
                madtTE.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"].ToString();
            }

            madtTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"].ToString();


            tenTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Dt"].ToString();

            manhdtLUE.Properties.ForceInitialize();
            if (!isAdd) //!isNew  is Edit
            {
                manhdtLUE.ItemIndex = manhdtLUE.Properties.GetDataSourceRowIndex("Ma_Nh_Dt", Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Dt"].ToString());

            }
            else
            {
                manhdtLUE.ItemIndex = 0;
            }

            ctyTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Cong_Ty"].ToString();
            diachiTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dia_Chi"].ToString();
            msthueTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_So_Thue"].ToString();
            tknhTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Tk_NH"].ToString();
            tennhTB.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_NH"].ToString();
            sdtTE.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Phone"].ToString();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Dt"] = madtTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Dt"] = tenTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Dt"] = manhdtLUE.EditValue;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Cong_Ty"] = ctyTB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dia_Chi"] = diachiTB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_So_Thue"] = msthueTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Tk_NH"] = tknhTE.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_NH"] = tennhTB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["So_Phone"] = sdtTE.Text;
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

        private void AddEditDMDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eWONDATASET.E00DMNHDT' table. You can move, or remove it, as needed.


        }

        private void manhdtLUE_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView s = (DataRowView)manhdtLUE.GetSelectedDataRow();
            manhdtLB.Text = s["Ma_Nh_Dt"].ToString();
        }


        private void tenTE_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenTE.Text.ToString()))
            {
                ewErrorProvider1.SetError(tenTE, "Tên đối tượng không bỏ trống", ErrorType.Information);
            }
            else
            {
                ewErrorProvider1.SetError(tenTE, "", ErrorType.Information);
            }
        }

        private void madtTE_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(madtTE.Text.ToString()))
            {
                ewErrorProvider1.SetError(madtTE, "Mã đối tượng không bỏ trống", ErrorType.Information);
            }
            else
            {
                if (Gridview.LocateByValue("Ma_Dt", madtTE.EditValue) < 0)
                {
                    ewErrorProvider1.SetError(madtTE, "", ErrorType.Information);
                }
                else
                {
                    if (isAdd)
                    {
                        ewErrorProvider1.SetError(madtTE, "Giá trị này đã có trong Danh Mục Đối Tượng", ErrorType.Information);
                    }
                    else
                    {
                        if (madtTE.EditValue.ToString() == madtTE.Tag.ToString())
                        {
                            ewErrorProvider1.SetError(madtTE, "", ErrorType.Information);
                        }
                        else
                        {
                            ewErrorProvider1.SetError(madtTE, "Giá trị này đã có trong Danh Mục Đối Tượng", ErrorType.Information);
                        }
                    }
                }
            }
        }
    }
}
