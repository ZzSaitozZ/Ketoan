namespace Ketoan.Controls.Danhmuc.DMKHO
{
    partial class DMKHO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMKHO));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.e00DMKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e00DMKHOTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMKHOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKHOBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(812, 274);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(812, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMKHOBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(812, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // e00DMKHOBindingSource
            // 
            this.e00DMKHOBindingSource.DataMember = "E00DMKHO";
            this.e00DMKHOBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Kho,
            this.colTen_Kho,
            this.colStt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colMa_Kho
            // 
            this.colMa_Kho.Caption = "Mã kho";
            this.colMa_Kho.FieldName = "Ma_Kho";
            this.colMa_Kho.Name = "colMa_Kho";
            this.colMa_Kho.OptionsEditForm.VisibleIndex = 1;
            this.colMa_Kho.Visible = true;
            this.colMa_Kho.VisibleIndex = 0;
            // 
            // colTen_Kho
            // 
            this.colTen_Kho.Caption = "Tên kho";
            this.colTen_Kho.FieldName = "Ten_Kho";
            this.colTen_Kho.Name = "colTen_Kho";
            this.colTen_Kho.OptionsEditForm.ColumnSpan = 2;
            this.colTen_Kho.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Kho.OptionsEditForm.VisibleIndex = 3;
            this.colTen_Kho.Visible = true;
            this.colTen_Kho.VisibleIndex = 1;
            this.colTen_Kho.Width = 269;
            // 
            // colStt
            // 
            this.colStt.Caption = "STT";
            this.colStt.FieldName = "Stt";
            this.colStt.Name = "colStt";
            this.colStt.OptionsEditForm.UseEditorColRowSpan = false;
            this.colStt.OptionsEditForm.VisibleIndex = 2;
            this.colStt.Visible = true;
            this.colStt.VisibleIndex = 2;
            // 
            // e00DMKHOTableAdapter
            // 
            this.e00DMKHOTableAdapter.ClearBeforeFill = true;
            // 
            // DMKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "DMKHO";
            this.Text = "DMKho";
            this.Load += new System.EventHandler(this.DMKho_Load);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMKHOBindingSource;
        private EWONDATASETTableAdapters.E00DMKHOTableAdapter e00DMKHOTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colStt;
    }
}