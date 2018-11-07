namespace Ketoan.Controls.DanhMuc.DMNHVT
{
    partial class DMNHVT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMNHVT));
            this.e00DMNHVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMNHVTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMNHVTTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Vt_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNh_Cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Size = new System.Drawing.Size(806, 274);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(806, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // e00DMNHVTBindingSource
            // 
            this.e00DMNHVTBindingSource.DataMember = "E00DMNHVT";
            this.e00DMNHVTBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMNHVTTableAdapter
            // 
            this.e00DMNHVTTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMNHVTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(806, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nh_Vt,
            this.colTen_Nh_Vt,
            this.colMa_Nh_Vt_Parent,
            this.colLoai_Nh_Vt,
            this.colNh_Cuoi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colMa_Nh_Vt
            // 
            this.colMa_Nh_Vt.Caption = "Mã nhóm VT";
            this.colMa_Nh_Vt.FieldName = "Ma_Nh_Vt";
            this.colMa_Nh_Vt.Name = "colMa_Nh_Vt";
            this.colMa_Nh_Vt.OptionsEditForm.VisibleIndex = 1;
            this.colMa_Nh_Vt.Visible = true;
            this.colMa_Nh_Vt.VisibleIndex = 0;
            // 
            // colTen_Nh_Vt
            // 
            this.colTen_Nh_Vt.Caption = "Tên nhóm VT";
            this.colTen_Nh_Vt.FieldName = "Ten_Nh_Vt";
            this.colTen_Nh_Vt.Name = "colTen_Nh_Vt";
            this.colTen_Nh_Vt.OptionsEditForm.ColumnSpan = 2;
            this.colTen_Nh_Vt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Nh_Vt.OptionsEditForm.VisibleIndex = 3;
            this.colTen_Nh_Vt.Visible = true;
            this.colTen_Nh_Vt.VisibleIndex = 1;
            // 
            // colMa_Nh_Vt_Parent
            // 
            this.colMa_Nh_Vt_Parent.Caption = "Mã Nh VT parent";
            this.colMa_Nh_Vt_Parent.FieldName = "Ma_Nh_Vt_Parent";
            this.colMa_Nh_Vt_Parent.Name = "colMa_Nh_Vt_Parent";
            this.colMa_Nh_Vt_Parent.OptionsEditForm.VisibleIndex = 2;
            this.colMa_Nh_Vt_Parent.Visible = true;
            this.colMa_Nh_Vt_Parent.VisibleIndex = 2;
            // 
            // colLoai_Nh_Vt
            // 
            this.colLoai_Nh_Vt.Caption = "Loại nhóm VT";
            this.colLoai_Nh_Vt.FieldName = "Loai_Nh_Vt";
            this.colLoai_Nh_Vt.Name = "colLoai_Nh_Vt";
            this.colLoai_Nh_Vt.OptionsEditForm.VisibleIndex = 4;
            this.colLoai_Nh_Vt.Visible = true;
            this.colLoai_Nh_Vt.VisibleIndex = 3;
            // 
            // colNh_Cuoi
            // 
            this.colNh_Cuoi.Caption = "Nhóm cuối";
            this.colNh_Cuoi.FieldName = "Nh_Cuoi";
            this.colNh_Cuoi.Name = "colNh_Cuoi";
            this.colNh_Cuoi.OptionsEditForm.VisibleIndex = 5;
            this.colNh_Cuoi.Visible = true;
            this.colNh_Cuoi.VisibleIndex = 4;
            // 
            // DMNHVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Name = "DMNHVT";
            this.Text = "DMNHVT";
            this.Load += new System.EventHandler(this.DMNHVT_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMNHVTBindingSource;
        private EWONDATASETTableAdapters.E00DMNHVTTableAdapter e00DMNHVTTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colNh_Cuoi;
    }
}