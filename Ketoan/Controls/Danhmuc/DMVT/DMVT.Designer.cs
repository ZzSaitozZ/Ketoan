namespace Ketoan.Controls.DanhMuc.DMVT
{
    partial class DMVT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMVT));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.e00DMVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DMNHVT = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.e00DMNHVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nh_Vt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DMKHO = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.e00DMKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Kho1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e00DMVTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMVTTableAdapter();
            this.e00DMNHVTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMNHVTTableAdapter();
            this.e00DMKHOTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMKHOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMNHVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(806, 274);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(806, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMVTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DMNHVT,
            this.DMKHO});
            this.gridControl1.Size = new System.Drawing.Size(806, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // e00DMVTBindingSource
            // 
            this.e00DMVTBindingSource.DataMember = "E00DMVT";
            this.e00DMVTBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Vt,
            this.colTen_Vt,
            this.colMa_Nh_Vt,
            this.colMa_Kho,
            this.colDvt,
            this.colTk,
            this.colGhi_Chu});
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
            // colMa_Vt
            // 
            this.colMa_Vt.Caption = "Mã vật tư";
            this.colMa_Vt.FieldName = "Ma_Vt";
            this.colMa_Vt.Name = "colMa_Vt";
            this.colMa_Vt.Visible = true;
            this.colMa_Vt.VisibleIndex = 0;
            // 
            // colTen_Vt
            // 
            this.colTen_Vt.Caption = "Tên vật tư";
            this.colTen_Vt.FieldName = "Ten_Vt";
            this.colTen_Vt.Name = "colTen_Vt";
            this.colTen_Vt.Visible = true;
            this.colTen_Vt.VisibleIndex = 1;
            // 
            // colMa_Nh_Vt
            // 
            this.colMa_Nh_Vt.Caption = "Mã nhóm vật tư";
            this.colMa_Nh_Vt.ColumnEdit = this.DMNHVT;
            this.colMa_Nh_Vt.FieldName = "Ma_Nh_Vt";
            this.colMa_Nh_Vt.Name = "colMa_Nh_Vt";
            this.colMa_Nh_Vt.Visible = true;
            this.colMa_Nh_Vt.VisibleIndex = 2;
            // 
            // DMNHVT
            // 
            this.DMNHVT.AutoHeight = false;
            this.DMNHVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DMNHVT.DataSource = this.e00DMNHVTBindingSource;
            this.DMNHVT.DisplayMember = "Ma_Nh_Vt";
            this.DMNHVT.ImmediatePopup = true;
            this.DMNHVT.Name = "DMNHVT";
            this.DMNHVT.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.DMNHVT.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.DMNHVT.ValueMember = "Ma_Nh_Vt";
            // 
            // e00DMNHVTBindingSource
            // 
            this.e00DMNHVTBindingSource.DataMember = "E00DMNHVT";
            this.e00DMNHVTBindingSource.DataSource = this.eWONDATASET;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nh_Vt1,
            this.colTen_Nh_Vt,
            this.colLoai_Nh_Vt});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.repositoryItemGridLookUpEdit1View.OptionsEditForm.FormCaptionFormat = "Thêm mới";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.repositoryItemGridLookUpEdit1View_RowUpdated);
            // 
            // colMa_Nh_Vt1
            // 
            this.colMa_Nh_Vt1.Caption = "Mã nhóm VT";
            this.colMa_Nh_Vt1.FieldName = "Ma_Nh_Vt";
            this.colMa_Nh_Vt1.Name = "colMa_Nh_Vt1";
            this.colMa_Nh_Vt1.Visible = true;
            this.colMa_Nh_Vt1.VisibleIndex = 0;
            // 
            // colTen_Nh_Vt
            // 
            this.colTen_Nh_Vt.Caption = "Tên nhóm VT";
            this.colTen_Nh_Vt.FieldName = "Ten_Nh_Vt";
            this.colTen_Nh_Vt.Name = "colTen_Nh_Vt";
            this.colTen_Nh_Vt.Visible = true;
            this.colTen_Nh_Vt.VisibleIndex = 1;
            // 
            // colLoai_Nh_Vt
            // 
            this.colLoai_Nh_Vt.Caption = "Loại nhóm VT";
            this.colLoai_Nh_Vt.FieldName = "Loai_Nh_Vt";
            this.colLoai_Nh_Vt.Name = "colLoai_Nh_Vt";
            this.colLoai_Nh_Vt.Visible = true;
            this.colLoai_Nh_Vt.VisibleIndex = 2;
            // 
            // colMa_Kho
            // 
            this.colMa_Kho.Caption = "Mã kho";
            this.colMa_Kho.ColumnEdit = this.DMKHO;
            this.colMa_Kho.FieldName = "Ma_Kho";
            this.colMa_Kho.Name = "colMa_Kho";
            this.colMa_Kho.Visible = true;
            this.colMa_Kho.VisibleIndex = 3;
            // 
            // DMKHO
            // 
            this.DMKHO.AutoHeight = false;
            this.DMKHO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DMKHO.DataSource = this.e00DMKHOBindingSource;
            this.DMKHO.DisplayMember = "Ma_Kho";
            this.DMKHO.ImmediatePopup = true;
            this.DMKHO.Name = "DMKHO";
            this.DMKHO.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.DMKHO.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.DMKHO.ValueMember = "Ma_Kho";
            // 
            // e00DMKHOBindingSource
            // 
            this.e00DMKHOBindingSource.DataMember = "E00DMKHO";
            this.e00DMKHOBindingSource.DataSource = this.eWONDATASET;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Kho1,
            this.colTen_Kho,
            this.colMa_Data});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.repositoryItemGridLookUpEdit2View.OptionsEditForm.FormCaptionFormat = "Thêm mới";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit2View.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.repositoryItemGridLookUpEdit2View_RowUpdated);
            // 
            // colMa_Kho1
            // 
            this.colMa_Kho1.Caption = "Mã kho";
            this.colMa_Kho1.FieldName = "Ma_Kho";
            this.colMa_Kho1.Name = "colMa_Kho1";
            this.colMa_Kho1.Visible = true;
            this.colMa_Kho1.VisibleIndex = 0;
            // 
            // colTen_Kho
            // 
            this.colTen_Kho.Caption = "Tên kho";
            this.colTen_Kho.FieldName = "Ten_Kho";
            this.colTen_Kho.Name = "colTen_Kho";
            this.colTen_Kho.Visible = true;
            this.colTen_Kho.VisibleIndex = 1;
            // 
            // colMa_Data
            // 
            this.colMa_Data.Caption = "Mã data";
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 2;
            // 
            // colDvt
            // 
            this.colDvt.Caption = "Đơn vị tính";
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 4;
            // 
            // colTk
            // 
            this.colTk.Caption = "Tài khoản";
            this.colTk.FieldName = "Tk";
            this.colTk.Name = "colTk";
            this.colTk.Visible = true;
            this.colTk.VisibleIndex = 5;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.Caption = "Ghi chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 6;
            // 
            // e00DMVTTableAdapter
            // 
            this.e00DMVTTableAdapter.ClearBeforeFill = true;
            // 
            // e00DMNHVTTableAdapter
            // 
            this.e00DMNHVTTableAdapter.ClearBeforeFill = true;
            // 
            // e00DMKHOTableAdapter
            // 
            this.e00DMKHOTableAdapter.ClearBeforeFill = true;
            // 
            // DMVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "DMVT";
            this.Text = "DMVT";
            this.Load += new System.EventHandler(this.DMVT_Load);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMNHVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMVTBindingSource;
        private EWONDATASETTableAdapters.E00DMVTTableAdapter e00DMVTTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colTk;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit DMNHVT;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit DMKHO;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource e00DMNHVTBindingSource;
        private EWONDATASETTableAdapters.E00DMNHVTTableAdapter e00DMNHVTTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Nh_Vt;
        private System.Windows.Forms.BindingSource e00DMKHOBindingSource;
        private EWONDATASETTableAdapters.E00DMKHOTableAdapter e00DMKHOTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
    }
}