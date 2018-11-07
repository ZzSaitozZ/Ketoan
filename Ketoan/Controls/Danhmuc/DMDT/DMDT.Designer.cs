﻿namespace Ketoan.Controls.DanhMuc.DMDT
{
    partial class DMDT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMDT));
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMDTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMDTTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.e00DMNHDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nh_Dt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nh_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCong_Ty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_So_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Tk_NH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_NH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e00DMNHDTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMNHDTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.ImageOptions.Image")));
            this.addBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addBtn.ImageOptions.LargeImage")));
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.Image")));
            this.editBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editBtn.ImageOptions.LargeImage")));
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.LargeImage")));
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // printBtn
            // 
            this.printBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.ImageOptions.Image")));
            this.printBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("printBtn.ImageOptions.LargeImage")));
            // 
            // helpBtn
            // 
            this.helpBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("helpBtn.ImageOptions.Image")));
            this.helpBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("helpBtn.ImageOptions.LargeImage")));
            // 
            // settingBtn
            // 
            this.settingBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("settingBtn.ImageOptions.Image")));
            this.settingBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("settingBtn.ImageOptions.LargeImage")));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Size = new System.Drawing.Size(819, 346);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(819, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMDTTableAdapter
            // 
            this.e00DMDTTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMDT";
            this.gridControl1.DataSource = this.eWONDATASET;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(819, 346);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Dt,
            this.colTen_Dt,
            this.colMa_Nh_Dt,
            this.colCong_Ty,
            this.colSo_Phone,
            this.colDia_Chi,
            this.colMa_So_Thue,
            this.colSo_Tk_NH,
            this.colTen_NH});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colMa_Dt
            // 
            this.colMa_Dt.Caption = "Mã đối tượng";
            this.colMa_Dt.FieldName = "Ma_Dt";
            this.colMa_Dt.Name = "colMa_Dt";
            this.colMa_Dt.OptionsEditForm.VisibleIndex = 1;
            this.colMa_Dt.Visible = true;
            this.colMa_Dt.VisibleIndex = 0;
            // 
            // colTen_Dt
            // 
            this.colTen_Dt.Caption = "Tên đối tượng";
            this.colTen_Dt.FieldName = "Ten_Dt";
            this.colTen_Dt.Name = "colTen_Dt";
            this.colTen_Dt.OptionsEditForm.ColumnSpan = 2;
            this.colTen_Dt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Dt.OptionsEditForm.VisibleIndex = 3;
            this.colTen_Dt.Visible = true;
            this.colTen_Dt.VisibleIndex = 1;
            // 
            // colMa_Nh_Dt
            // 
            this.colMa_Nh_Dt.Caption = "Mã nhóm đối tượng";
            this.colMa_Nh_Dt.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colMa_Nh_Dt.FieldName = "Ma_Nh_Dt";
            this.colMa_Nh_Dt.Name = "colMa_Nh_Dt";
            this.colMa_Nh_Dt.OptionsEditForm.VisibleIndex = 2;
            this.colMa_Nh_Dt.Visible = true;
            this.colMa_Nh_Dt.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AccessibleDescription = "";
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.e00DMNHDTBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Ma_Nh_Dt";
            this.repositoryItemGridLookUpEdit1.ImmediatePopup = true;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView2;
            this.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Ma_Nh_Dt";
            // 
            // e00DMNHDTBindingSource
            // 
            this.e00DMNHDTBindingSource.DataMember = "E00DMNHDT";
            this.e00DMNHDTBindingSource.DataSource = this.eWONDATASET;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nh_Dt1,
            this.colTen_Nh_Dt});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView2.OptionsEditForm.FormCaptionFormat = "Thêm mới";
            this.gridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colMa_Nh_Dt1
            // 
            this.colMa_Nh_Dt1.Caption = "Mã nhóm ĐT";
            this.colMa_Nh_Dt1.FieldName = "Ma_Nh_Dt";
            this.colMa_Nh_Dt1.Name = "colMa_Nh_Dt1";
            this.colMa_Nh_Dt1.Visible = true;
            this.colMa_Nh_Dt1.VisibleIndex = 0;
            // 
            // colTen_Nh_Dt
            // 
            this.colTen_Nh_Dt.Caption = "Tên nhóm ĐT";
            this.colTen_Nh_Dt.FieldName = "Ten_Nh_Dt";
            this.colTen_Nh_Dt.Name = "colTen_Nh_Dt";
            this.colTen_Nh_Dt.OptionsEditForm.ColumnSpan = 2;
            this.colTen_Nh_Dt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Nh_Dt.Visible = true;
            this.colTen_Nh_Dt.VisibleIndex = 1;
            // 
            // colCong_Ty
            // 
            this.colCong_Ty.Caption = "Công ty";
            this.colCong_Ty.FieldName = "Cong_Ty";
            this.colCong_Ty.Name = "colCong_Ty";
            this.colCong_Ty.OptionsEditForm.ColumnSpan = 2;
            this.colCong_Ty.OptionsEditForm.UseEditorColRowSpan = false;
            this.colCong_Ty.OptionsEditForm.VisibleIndex = 4;
            this.colCong_Ty.Visible = true;
            this.colCong_Ty.VisibleIndex = 3;
            // 
            // colSo_Phone
            // 
            this.colSo_Phone.Caption = "Số điện thoại";
            this.colSo_Phone.FieldName = "So_Phone";
            this.colSo_Phone.Name = "colSo_Phone";
            this.colSo_Phone.OptionsEditForm.ColumnSpan = 2;
            this.colSo_Phone.OptionsEditForm.UseEditorColRowSpan = false;
            this.colSo_Phone.OptionsEditForm.VisibleIndex = 5;
            this.colSo_Phone.Visible = true;
            this.colSo_Phone.VisibleIndex = 5;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.OptionsEditForm.ColumnSpan = 2;
            this.colDia_Chi.OptionsEditForm.UseEditorColRowSpan = false;
            this.colDia_Chi.OptionsEditForm.VisibleIndex = 6;
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 4;
            // 
            // colMa_So_Thue
            // 
            this.colMa_So_Thue.Caption = "Mã số thuế";
            this.colMa_So_Thue.FieldName = "Ma_So_Thue";
            this.colMa_So_Thue.Name = "colMa_So_Thue";
            this.colMa_So_Thue.OptionsEditForm.ColumnSpan = 2;
            this.colMa_So_Thue.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMa_So_Thue.OptionsEditForm.VisibleIndex = 7;
            this.colMa_So_Thue.Visible = true;
            this.colMa_So_Thue.VisibleIndex = 6;
            // 
            // colSo_Tk_NH
            // 
            this.colSo_Tk_NH.Caption = "Tài khoản ngân hàng";
            this.colSo_Tk_NH.FieldName = "So_Tk_NH";
            this.colSo_Tk_NH.Name = "colSo_Tk_NH";
            this.colSo_Tk_NH.OptionsEditForm.ColumnSpan = 2;
            this.colSo_Tk_NH.OptionsEditForm.UseEditorColRowSpan = false;
            this.colSo_Tk_NH.OptionsEditForm.VisibleIndex = 8;
            this.colSo_Tk_NH.Visible = true;
            this.colSo_Tk_NH.VisibleIndex = 7;
            // 
            // colTen_NH
            // 
            this.colTen_NH.Caption = "Tên ngân hàng";
            this.colTen_NH.FieldName = "Ten_NH";
            this.colTen_NH.Name = "colTen_NH";
            this.colTen_NH.OptionsEditForm.ColumnSpan = 2;
            this.colTen_NH.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_NH.OptionsEditForm.VisibleIndex = 9;
            this.colTen_NH.Visible = true;
            this.colTen_NH.VisibleIndex = 8;
            // 
            // e00DMNHDTTableAdapter
            // 
            this.e00DMNHDTTableAdapter.ClearBeforeFill = true;
            // 
            // DMDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 522);
            this.Name = "DMDT";
            this.Text = "Danh Mục Đối Tượng";
            this.Load += new System.EventHandler(this.DMDT_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private EWONDATASETTableAdapters.E00DMDTTableAdapter e00DMDTTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colCong_Ty;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_So_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Tk_NH;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_NH;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource e00DMNHDTBindingSource;
        private EWONDATASETTableAdapters.E00DMNHDTTableAdapter e00DMNHDTTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Dt1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nh_Dt;
    }
}