namespace Ketoan.Controls.Danhmuc.DMKV
{
    partial class DMKV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMKV));
            this.e00DMKVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMKVTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMKVTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Kv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKVBindingSource)).BeginInit();
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
            // e00DMKVBindingSource
            // 
            this.e00DMKVBindingSource.DataMember = "E00DMKV";
            this.e00DMKVBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMKVTableAdapter
            // 
            this.e00DMKVTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMKVBindingSource;
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
            this.colMa_Kv,
            this.colTen_Kv,
            this.colMa_Data});
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
            // colMa_Kv
            // 
            this.colMa_Kv.Caption = "Mã khu vực";
            this.colMa_Kv.FieldName = "Ma_Kv";
            this.colMa_Kv.Name = "colMa_Kv";
            this.colMa_Kv.OptionsEditForm.VisibleIndex = 1;
            this.colMa_Kv.Visible = true;
            this.colMa_Kv.VisibleIndex = 0;
            // 
            // colTen_Kv
            // 
            this.colTen_Kv.Caption = "Tên khu vực";
            this.colTen_Kv.FieldName = "Ten_Kv";
            this.colTen_Kv.Name = "colTen_Kv";
            this.colTen_Kv.OptionsEditForm.ColumnSpan = 2;
            this.colTen_Kv.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Kv.OptionsEditForm.VisibleIndex = 3;
            this.colTen_Kv.Visible = true;
            this.colTen_Kv.VisibleIndex = 1;
            // 
            // colMa_Data
            // 
            this.colMa_Data.Caption = "Mã Data";
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.OptionsEditForm.VisibleIndex = 2;
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 2;
            // 
            // DMKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Name = "DMKV";
            this.Text = "DMKV";
            this.Load += new System.EventHandler(this.DMKV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMKVBindingSource;
        private EWONDATASETTableAdapters.E00DMKVTableAdapter e00DMKVTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kv;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kv;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
    }
}