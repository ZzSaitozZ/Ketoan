namespace Ketoan.Controls.Danhmuc.DMNV
{
    partial class DMNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMNV));
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.e00DMNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Bp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.e00DMBPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Bp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Bp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuc_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e00DMNVTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMNVTableAdapter();
            this.e00DMBPTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMBPTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMBPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 274);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMNVBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(800, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // e00DMNVBindingSource
            // 
            this.e00DMNVBindingSource.DataMember = "E00DMNV";
            this.e00DMNVBindingSource.DataSource = this.eWONDATASET;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nv,
            this.colTen_Nv,
            this.colMa_Bp,
            this.colNgay_sinh,
            this.colSo_CMND,
            this.colSo_Phone,
            this.colDia_Chi,
            this.colEmail,
            this.colChuc_vu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colMa_Nv
            // 
            this.colMa_Nv.Caption = "Mã nhân viên";
            this.colMa_Nv.FieldName = "Ma_Nv";
            this.colMa_Nv.Name = "colMa_Nv";
            this.colMa_Nv.Visible = true;
            this.colMa_Nv.VisibleIndex = 0;
            // 
            // colTen_Nv
            // 
            this.colTen_Nv.Caption = "Tên nhân viên";
            this.colTen_Nv.FieldName = "Ten_Nv";
            this.colTen_Nv.Name = "colTen_Nv";
            this.colTen_Nv.Visible = true;
            this.colTen_Nv.VisibleIndex = 1;
            // 
            // colMa_Bp
            // 
            this.colMa_Bp.Caption = "Mã bộ phận";
            this.colMa_Bp.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colMa_Bp.FieldName = "Ma_Bp";
            this.colMa_Bp.Name = "colMa_Bp";
            this.colMa_Bp.Visible = true;
            this.colMa_Bp.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.e00DMBPBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Ma_Bp";
            this.repositoryItemGridLookUpEdit1.ImmediatePopup = true;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Ma_Bp";
            // 
            // e00DMBPBindingSource
            // 
            this.e00DMBPBindingSource.DataMember = "E00DMBP";
            this.e00DMBPBindingSource.DataSource = this.eWONDATASET;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Bp1,
            this.colTen_Bp});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.repositoryItemGridLookUpEdit1View.OptionsEditForm.FormCaptionFormat = "Thêm mới";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.repositoryItemGridLookUpEdit1View_RowUpdated);
            // 
            // colMa_Bp1
            // 
            this.colMa_Bp1.Caption = "Mã bộ phận";
            this.colMa_Bp1.FieldName = "Ma_Bp";
            this.colMa_Bp1.Name = "colMa_Bp1";
            this.colMa_Bp1.Visible = true;
            this.colMa_Bp1.VisibleIndex = 0;
            // 
            // colTen_Bp
            // 
            this.colTen_Bp.Caption = "Tên bộ phận";
            this.colTen_Bp.FieldName = "Ten_Bp";
            this.colTen_Bp.Name = "colTen_Bp";
            this.colTen_Bp.Visible = true;
            this.colTen_Bp.VisibleIndex = 1;
            // 
            // colNgay_sinh
            // 
            this.colNgay_sinh.Caption = "Ngày sinh";
            this.colNgay_sinh.FieldName = "Ngay_sinh";
            this.colNgay_sinh.Name = "colNgay_sinh";
            this.colNgay_sinh.Visible = true;
            this.colNgay_sinh.VisibleIndex = 3;
            // 
            // colSo_CMND
            // 
            this.colSo_CMND.Caption = "Số CMND";
            this.colSo_CMND.FieldName = "So_CMND";
            this.colSo_CMND.Name = "colSo_CMND";
            this.colSo_CMND.Visible = true;
            this.colSo_CMND.VisibleIndex = 4;
            // 
            // colSo_Phone
            // 
            this.colSo_Phone.Caption = "Điện thoại";
            this.colSo_Phone.FieldName = "So_Phone";
            this.colSo_Phone.Name = "colSo_Phone";
            this.colSo_Phone.Visible = true;
            this.colSo_Phone.VisibleIndex = 5;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // colChuc_vu
            // 
            this.colChuc_vu.Caption = "Chức vụ";
            this.colChuc_vu.FieldName = "Chuc_vu";
            this.colChuc_vu.Name = "colChuc_vu";
            this.colChuc_vu.Visible = true;
            this.colChuc_vu.VisibleIndex = 8;
            // 
            // e00DMNVTableAdapter
            // 
            this.e00DMNVTableAdapter.ClearBeforeFill = true;
            // 
            // e00DMBPTableAdapter
            // 
            this.e00DMBPTableAdapter.ClearBeforeFill = true;
            // 
            // DMNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DMNV";
            this.Text = "DMNHVT";
            this.Load += new System.EventHandler(this.DMNV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMBPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource e00DMNVBindingSource;
        private EWONDATASETTableAdapters.E00DMNVTableAdapter e00DMNVTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nv;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nv;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Bp;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_sinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_CMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colChuc_vu;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource e00DMBPBindingSource;
        private EWONDATASETTableAdapters.E00DMBPTableAdapter e00DMBPTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Bp1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Bp;
    }
}