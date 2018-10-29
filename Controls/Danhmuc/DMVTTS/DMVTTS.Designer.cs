namespace Ketoan.Controls.Danhmuc.DMVTTS
{
    partial class DMVTTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMVTTS));
            this.e00DMVTTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMVTTSTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMVTTSTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DMNHVT = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.e00DMNHVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nh_Vt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Vt_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_The = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam_Sx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNuoc_Sx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCong_Suat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTK_VT_TS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e00DMNHVTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMNHVTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMVTTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMNHVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHVTBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(806, 274);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(806, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // e00DMVTTSBindingSource
            // 
            this.e00DMVTTSBindingSource.DataMember = "E00DMVTTS";
            this.e00DMVTTSBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMVTTSTableAdapter
            // 
            this.e00DMVTTSTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMVTTSBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DMNHVT});
            this.gridControl1.Size = new System.Drawing.Size(806, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Vt,
            this.colTen_Vt,
            this.colDvt,
            this.colMa_Nh_Vt,
            this.colSo_The,
            this.colNam_Sx,
            this.colNuoc_Sx,
            this.colCong_Suat,
            this.colTK_VT_TS,
            this.colGhi_Chu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 4;
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
            this.colMa_Vt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMa_Vt.OptionsEditForm.VisibleIndex = 1;
            this.colMa_Vt.Visible = true;
            this.colMa_Vt.VisibleIndex = 0;
            // 
            // colTen_Vt
            // 
            this.colTen_Vt.Caption = "Tên vật tư";
            this.colTen_Vt.FieldName = "Ten_Vt";
            this.colTen_Vt.Name = "colTen_Vt";
            this.colTen_Vt.OptionsEditForm.ColumnSpan = 4;
            this.colTen_Vt.OptionsEditForm.StartNewRow = true;
            this.colTen_Vt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Vt.OptionsEditForm.VisibleIndex = 3;
            this.colTen_Vt.Visible = true;
            this.colTen_Vt.VisibleIndex = 1;
            // 
            // colDvt
            // 
            this.colDvt.Caption = "Đơn vị tính";
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.OptionsEditForm.VisibleIndex = 4;
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 2;
            // 
            // colMa_Nh_Vt
            // 
            this.colMa_Nh_Vt.Caption = "Mã nhóm VT";
            this.colMa_Nh_Vt.ColumnEdit = this.DMNHVT;
            this.colMa_Nh_Vt.FieldName = "Ma_Nh_Vt";
            this.colMa_Nh_Vt.Name = "colMa_Nh_Vt";
            this.colMa_Nh_Vt.OptionsEditForm.VisibleIndex = 2;
            this.colMa_Nh_Vt.Visible = true;
            this.colMa_Nh_Vt.VisibleIndex = 3;
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
            this.colMa_Nh_Vt_Parent,
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
            // colMa_Nh_Vt_Parent
            // 
            this.colMa_Nh_Vt_Parent.Caption = "Mã nhóm Vt cha";
            this.colMa_Nh_Vt_Parent.FieldName = "Ma_Nh_Vt_Parent";
            this.colMa_Nh_Vt_Parent.Name = "colMa_Nh_Vt_Parent";
            this.colMa_Nh_Vt_Parent.Visible = true;
            this.colMa_Nh_Vt_Parent.VisibleIndex = 2;
            // 
            // colLoai_Nh_Vt
            // 
            this.colLoai_Nh_Vt.Caption = "Loại nhóm VT";
            this.colLoai_Nh_Vt.FieldName = "Loai_Nh_Vt";
            this.colLoai_Nh_Vt.Name = "colLoai_Nh_Vt";
            this.colLoai_Nh_Vt.Visible = true;
            this.colLoai_Nh_Vt.VisibleIndex = 3;
            // 
            // colSo_The
            // 
            this.colSo_The.Caption = "Số thẻ";
            this.colSo_The.FieldName = "So_The";
            this.colSo_The.Name = "colSo_The";
            this.colSo_The.OptionsEditForm.StartNewRow = true;
            this.colSo_The.OptionsEditForm.VisibleIndex = 5;
            this.colSo_The.Visible = true;
            this.colSo_The.VisibleIndex = 4;
            // 
            // colNam_Sx
            // 
            this.colNam_Sx.Caption = "Năm sản xuất";
            this.colNam_Sx.FieldName = "Nam_Sx";
            this.colNam_Sx.Name = "colNam_Sx";
            this.colNam_Sx.OptionsEditForm.VisibleIndex = 6;
            this.colNam_Sx.Visible = true;
            this.colNam_Sx.VisibleIndex = 5;
            // 
            // colNuoc_Sx
            // 
            this.colNuoc_Sx.Caption = "Nước sản xuất";
            this.colNuoc_Sx.FieldName = "Nuoc_Sx";
            this.colNuoc_Sx.Name = "colNuoc_Sx";
            this.colNuoc_Sx.OptionsEditForm.ColumnSpan = 2;
            this.colNuoc_Sx.OptionsEditForm.VisibleIndex = 8;
            this.colNuoc_Sx.Visible = true;
            this.colNuoc_Sx.VisibleIndex = 6;
            // 
            // colCong_Suat
            // 
            this.colCong_Suat.Caption = "Công suất";
            this.colCong_Suat.FieldName = "Cong_Suat";
            this.colCong_Suat.Name = "colCong_Suat";
            this.colCong_Suat.OptionsEditForm.ColumnSpan = 2;
            this.colCong_Suat.OptionsEditForm.StartNewRow = true;
            this.colCong_Suat.OptionsEditForm.VisibleIndex = 7;
            this.colCong_Suat.Visible = true;
            this.colCong_Suat.VisibleIndex = 7;
            // 
            // colTK_VT_TS
            // 
            this.colTK_VT_TS.Caption = "Tài khoản VTTS";
            this.colTK_VT_TS.FieldName = "TK_VT_TS";
            this.colTK_VT_TS.Name = "colTK_VT_TS";
            this.colTK_VT_TS.OptionsEditForm.ColumnSpan = 2;
            this.colTK_VT_TS.OptionsEditForm.StartNewRow = true;
            this.colTK_VT_TS.OptionsEditForm.VisibleIndex = 9;
            this.colTK_VT_TS.Visible = true;
            this.colTK_VT_TS.VisibleIndex = 8;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.Caption = "Ghi chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.OptionsEditForm.ColumnSpan = 4;
            this.colGhi_Chu.OptionsEditForm.UseEditorColRowSpan = false;
            this.colGhi_Chu.OptionsEditForm.VisibleIndex = 10;
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 9;
            // 
            // e00DMNHVTTableAdapter
            // 
            this.e00DMNHVTTableAdapter.ClearBeforeFill = true;
            // 
            // DMVTTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Name = "DMVTTS";
            this.Text = "DMVTTS";
            this.Load += new System.EventHandler(this.DMVTTS_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMVTTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMNHVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMVTTSBindingSource;
        private EWONDATASETTableAdapters.E00DMVTTSTableAdapter e00DMVTTSTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_The;
        private DevExpress.XtraGrid.Columns.GridColumn colNam_Sx;
        private DevExpress.XtraGrid.Columns.GridColumn colNuoc_Sx;
        private DevExpress.XtraGrid.Columns.GridColumn colCong_Suat;
        private DevExpress.XtraGrid.Columns.GridColumn colTK_VT_TS;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit DMNHVT;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource e00DMNHVTBindingSource;
        private EWONDATASETTableAdapters.E00DMNHVTTableAdapter e00DMNHVTTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Nh_Vt;
    }
}