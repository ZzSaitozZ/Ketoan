namespace Ketoan.Controls.DanhMuc.DMTYGIA
{
    partial class DMTYGIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMTYGIA));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.e00DMTYGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.e00DMTYGIATableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMTYGIATableAdapter();
            this.colMa_Tt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Tt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTy_gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Ap = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMTYGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 274);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMTYGIABindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // e00DMTYGIABindingSource
            // 
            this.e00DMTYGIABindingSource.DataMember = "E00DMTYGIA";
            this.e00DMTYGIABindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Tt,
            this.colTen_Tt,
            this.colNgay_Ap,
            this.colTy_gia});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 5;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // e00DMTYGIATableAdapter
            // 
            this.e00DMTYGIATableAdapter.ClearBeforeFill = true;
            // 
            // colMa_Tt
            // 
            this.colMa_Tt.Caption = "Mã tiền tệ";
            this.colMa_Tt.FieldName = "Ma_Tt";
            this.colMa_Tt.Name = "colMa_Tt";
            this.colMa_Tt.OptionsEditForm.ColumnSpan = 2;
            this.colMa_Tt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMa_Tt.Visible = true;
            this.colMa_Tt.VisibleIndex = 0;
            // 
            // colTen_Tt
            // 
            this.colTen_Tt.Caption = "Tên tiền tệ";
            this.colTen_Tt.FieldName = "Ten_Tt";
            this.colTen_Tt.Name = "colTen_Tt";
            this.colTen_Tt.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Near;
            this.colTen_Tt.OptionsEditForm.ColumnSpan = 3;
            this.colTen_Tt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Tt.Visible = true;
            this.colTen_Tt.VisibleIndex = 1;
            // 
            // colTy_gia
            // 
            this.colTy_gia.Caption = "Tỷ giá";
            this.colTy_gia.FieldName = "Ty_gia";
            this.colTy_gia.Name = "colTy_gia";
            this.colTy_gia.OptionsEditForm.ColumnSpan = 3;
            this.colTy_gia.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTy_gia.Visible = true;
            this.colTy_gia.VisibleIndex = 2;
            // 
            // colNgay_Ap
            // 
            this.colNgay_Ap.Caption = "Ngày áp";
            this.colNgay_Ap.FieldName = "Ngay_Ap";
            this.colNgay_Ap.Name = "colNgay_Ap";
            this.colNgay_Ap.OptionsEditForm.ColumnSpan = 2;
            this.colNgay_Ap.OptionsEditForm.StartNewRow = true;
            this.colNgay_Ap.OptionsEditForm.UseEditorColRowSpan = false;
            this.colNgay_Ap.Visible = true;
            this.colNgay_Ap.VisibleIndex = 3;
            // 
            // DMTYGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "DMTYGIA";
            this.Text = "DMTYGIA";
            this.Load += new System.EventHandler(this.DMTYGIA_Load);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMTYGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMTYGIABindingSource;
        private EWONDATASETTableAdapters.E00DMTYGIATableAdapter e00DMTYGIATableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Tt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Tt;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Ap;
        private DevExpress.XtraGrid.Columns.GridColumn colTy_gia;
    }
}