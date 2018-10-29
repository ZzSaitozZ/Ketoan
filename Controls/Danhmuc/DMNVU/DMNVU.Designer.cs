namespace Ketoan.Controls.Danhmuc.DMNVU
{
    partial class DMNVU
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMNVU));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.e00DMNVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Ct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Ct_Rule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_No_Rule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Co_Rule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e00DMNVUTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMNVUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNVUBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Size = new System.Drawing.Size(930, 312);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(930, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e00DMNVUBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(930, 312);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // e00DMNVUBindingSource
            // 
            this.e00DMNVUBindingSource.DataMember = "E00DMNVU";
            this.e00DMNVUBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nvu,
            this.colTen_Nvu,
            this.colMa_Ct,
            this.colMa_Ct_Rule,
            this.colTk_No,
            this.colTk_No_Rule,
            this.colTk_Co,
            this.colTk_Co_Rule});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.EditFormColumnCount = 2;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMa_Ct, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gridView1_EditFormShowing);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colMa_Nvu
            // 
            this.colMa_Nvu.Caption = "Mã nghiệp vụ";
            this.colMa_Nvu.FieldName = "Ma_Nvu";
            this.colMa_Nvu.Name = "colMa_Nvu";
            this.colMa_Nvu.OptionsEditForm.VisibleIndex = 1;
            this.colMa_Nvu.Visible = true;
            this.colMa_Nvu.VisibleIndex = 0;
            // 
            // colTen_Nvu
            // 
            this.colTen_Nvu.Caption = "Tên nghiệp vụ";
            this.colTen_Nvu.FieldName = "Ten_Nvu";
            this.colTen_Nvu.Name = "colTen_Nvu";
            this.colTen_Nvu.OptionsEditForm.ColumnSpan = 2;
            this.colTen_Nvu.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTen_Nvu.OptionsEditForm.VisibleIndex = 2;
            this.colTen_Nvu.Visible = true;
            this.colTen_Nvu.VisibleIndex = 1;
            // 
            // colMa_Ct
            // 
            this.colMa_Ct.Caption = "Mã chứng từ";
            this.colMa_Ct.FieldName = "Ma_Ct";
            this.colMa_Ct.Name = "colMa_Ct";
            this.colMa_Ct.OptionsEditForm.VisibleIndex = 3;
            this.colMa_Ct.Visible = true;
            this.colMa_Ct.VisibleIndex = 2;
            // 
            // colMa_Ct_Rule
            // 
            this.colMa_Ct_Rule.Caption = "Mã chứng từ rule";
            this.colMa_Ct_Rule.FieldName = "Ma_Ct_Rule";
            this.colMa_Ct_Rule.Name = "colMa_Ct_Rule";
            this.colMa_Ct_Rule.OptionsEditForm.VisibleIndex = 4;
            this.colMa_Ct_Rule.Visible = true;
            this.colMa_Ct_Rule.VisibleIndex = 2;
            // 
            // colTk_No
            // 
            this.colTk_No.Caption = "Tài khoản nợ";
            this.colTk_No.FieldName = "Tk_No";
            this.colTk_No.Name = "colTk_No";
            this.colTk_No.OptionsEditForm.VisibleIndex = 5;
            this.colTk_No.Visible = true;
            this.colTk_No.VisibleIndex = 3;
            // 
            // colTk_No_Rule
            // 
            this.colTk_No_Rule.Caption = "Tài khoản nợ rule";
            this.colTk_No_Rule.FieldName = "Tk_No_Rule";
            this.colTk_No_Rule.Name = "colTk_No_Rule";
            this.colTk_No_Rule.OptionsEditForm.VisibleIndex = 6;
            this.colTk_No_Rule.Visible = true;
            this.colTk_No_Rule.VisibleIndex = 4;
            // 
            // colTk_Co
            // 
            this.colTk_Co.Caption = "Tài khoản có";
            this.colTk_Co.FieldName = "Tk_Co";
            this.colTk_Co.Name = "colTk_Co";
            this.colTk_Co.OptionsEditForm.VisibleIndex = 7;
            this.colTk_Co.Visible = true;
            this.colTk_Co.VisibleIndex = 5;
            // 
            // colTk_Co_Rule
            // 
            this.colTk_Co_Rule.Caption = "Tài khoản có rule";
            this.colTk_Co_Rule.FieldName = "Tk_Co_Rule";
            this.colTk_Co_Rule.Name = "colTk_Co_Rule";
            this.colTk_Co_Rule.OptionsEditForm.VisibleIndex = 8;
            this.colTk_Co_Rule.Visible = true;
            this.colTk_Co_Rule.VisibleIndex = 6;
            // 
            // e00DMNVUTableAdapter
            // 
            this.e00DMNVUTableAdapter.ClearBeforeFill = true;
            // 
            // DMNVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 488);
            this.Controls.Add(this.gridControl1);
            this.Name = "DMNVU";
            this.Text = "DMNVU";
            this.Load += new System.EventHandler(this.DMNVU_Load);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource e00DMNVUBindingSource;
        private EWONDATASET eWONDATASET;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nvu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nvu;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Ct;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Ct_Rule;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_No;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_No_Rule;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Co;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Co_Rule;
        private EWONDATASETTableAdapters.E00DMNVUTableAdapter e00DMNVUTableAdapter;
    }
}
