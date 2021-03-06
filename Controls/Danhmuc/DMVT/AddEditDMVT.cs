﻿using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc.DMVT
{
    public partial class AddEditDMVT : AddEditFrame
    {
        public AddEditDMVT(GridView gridview, bool isadd)
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

            e00DMNHVTTableAdapter2.Fill(ewondataset2.E00DMNHVT);
            e00DMKHOTableAdapter1.Fill(ewondataset1.E00DMKHO);
            ewErrorProvider1.SetIconAlignment(txtManhomVT, ErrorIconAlignment.MiddleRight);
            ewErrorProvider1.SetIconAlignment(txtTenVT, ErrorIconAlignment.MiddleRight);
            ewErrorProvider1.SetIconAlignment(txtMaVT, ErrorIconAlignment.MiddleRight);
            ewErrorProvider1.SetIconAlignment(txtMaKho, ErrorIconAlignment.MiddleRight);

            if (!isAdd)
            {
                txtMaVT.Tag = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Vt"].ToString();
            }

            txtMaVT.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Vt"].ToString();


            txtTenVT.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Vt"].ToString();

            txtManhomVT.Properties.ForceInitialize();
            if (!isAdd) //!isNew  is Edit
            {
                txtManhomVT.ItemIndex = txtManhomVT.Properties.GetDataSourceRowIndex("Ma_Nh_Vt", Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"].ToString());

            }
            else
            {
                txtManhomVT.ItemIndex = 0;
            }

            txtMaKho.Properties.ForceInitialize();
            if (!isAdd) //!isNew  is Edit
            {
                txtMaKho.ItemIndex = txtMaKho.Properties.GetDataSourceRowIndex("Ma_Kho", Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"].ToString());

            }
            else
            {
                txtMaKho.ItemIndex = 0;
            }
            //this.txtMaKho.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"].ToString();
            txtDonVi.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dvt"].ToString();
            txtTkVT.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk"].ToString();
            //this.txtBdate.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ngay_Begin"].ToString();
            //this.txtEdate.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ngay_End"].ToString();
            txtCreateLog.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Create_Log"].ToString();
            txtLstModify.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["LastModify_Log"].ToString();
            txtGhichu.Text = Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ghi_Chu"].ToString();


            // This line of code is generated by Data Source Configuration Wizard

        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Vt"] = txtMaVT.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ten_Vt"] = txtTenVT.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Nh_Vt"] = manhdtLB.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ma_Kho"] = txtDmaKho.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Dvt"] = txtDonVi.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Tk"] = txtTkVT.Text;
            //this.Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ngay_Begin"] = this.txtBdate.Text;
            //this.Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ngay_End"] = this.txtEdate.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Create_Log"] = txtCreateLog.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["LastModify_Log"] = txtLstModify.Text;
            Gridview.GetDataRow(Gridview.FocusedRowHandle)["Ghi_Chu"] = txtGhichu.Text;
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

        private void madtTE_EditValueChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaVT.Text.ToString()))
            {
                ewErrorProvider1.SetError(txtMaVT, "Mã đối tượng không bỏ trống", ErrorType.Information);
            }
            else
            {
                if (Gridview.LocateByValue("Ma_Vt", txtMaVT.EditValue) < 0)
                {
                    ewErrorProvider1.SetError(txtMaVT, "", ErrorType.Information);
                }
                else
                {
                    if (isAdd)
                    {
                        ewErrorProvider1.SetError(txtMaVT, "Giá trị này đã có trong Danh Mục Đối Tượng", ErrorType.Information);
                    }
                    else
                    {
                        if (txtMaVT.EditValue.ToString() == txtMaVT.Tag.ToString())
                        {
                            ewErrorProvider1.SetError(txtMaVT, "", ErrorType.Information);
                        }
                        else
                        {
                            ewErrorProvider1.SetError(txtMaVT, "Giá trị này đã có trong Danh Mục Đối Tượng", ErrorType.Information);
                        }
                    }
                }
            }
        }

        private void ledtMaNVT_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView s = (DataRowView)txtManhomVT.GetSelectedDataRow();
            manhdtLB.Text = s["Ma_Nh_Vt"].ToString();
        }

        private void txtTenVT_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenVT.Text.ToString()))
            {
                ewErrorProvider1.SetError(txtTenVT, "Tên đối tượng không bỏ trống", ErrorType.Information);
            }
            else
            {
                ewErrorProvider1.SetError(txtTenVT, "", ErrorType.Information);
            }
        }

        private void txtMaKho_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView s = (DataRowView)txtMaKho.GetSelectedDataRow();
            txtDmaKho.Text = s["Ma_Kho"].ToString();
        }
    }
}
