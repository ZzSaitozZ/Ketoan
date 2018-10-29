namespace Ketoan.Controls.Danhmuc.DMTK
{
    partial class DMTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMTK));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.e00DMTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Tk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Sp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Tte_Goc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e00DMTKTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMTKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMTKBindingSource)).BeginInit();
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
            this.gridControl1.DataSource = this.e00DMTKBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // e00DMTKBindingSource
            // 
            this.e00DMTKBindingSource.DataMember = "E00DMTK";
            this.e00DMTKBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTk,
            this.colTen_Tk,
            this.colTk_Parent,
            this.colTk_Cuoi,
            this.colTk_Sp,
            this.colTk_Dt,
            this.colTk_Km,
            this.colMa_Tte_Goc,
            this.colMa_Data});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.EditFormColumnCount = 1;
            // 
            // colTk
            // 
            this.colTk.Caption = "Mã tài khoản";
            this.colTk.FieldName = "Tk";
            this.colTk.Name = "colTk";
            this.colTk.Visible = true;
            this.colTk.VisibleIndex = 0;
            this.colTk.Width = 41;
            // 
            // colTen_Tk
            // 
            this.colTen_Tk.Caption = "Tên tài khoản";
            this.colTen_Tk.FieldName = "Ten_Tk";
            this.colTen_Tk.Name = "colTen_Tk";
            this.colTen_Tk.Visible = true;
            this.colTen_Tk.VisibleIndex = 1;
            this.colTen_Tk.Width = 41;
            // 
            // colTk_Parent
            // 
            this.colTk_Parent.Caption = "Mã TK parent";
            this.colTk_Parent.FieldName = "Tk_Parent";
            this.colTk_Parent.Name = "colTk_Parent";
            this.colTk_Parent.Visible = true;
            this.colTk_Parent.VisibleIndex = 2;
            this.colTk_Parent.Width = 39;
            // 
            // colTk_Cuoi
            // 
            this.colTk_Cuoi.Caption = "Tài khoản cuối";
            this.colTk_Cuoi.FieldName = "Tk_Cuoi";
            this.colTk_Cuoi.Name = "colTk_Cuoi";
            this.colTk_Cuoi.Visible = true;
            this.colTk_Cuoi.VisibleIndex = 3;
            this.colTk_Cuoi.Width = 39;
            // 
            // colTk_Sp
            // 
            this.colTk_Sp.Caption = "TK sản phẩm";
            this.colTk_Sp.FieldName = "Tk_Sp";
            this.colTk_Sp.Name = "colTk_Sp";
            this.colTk_Sp.Visible = true;
            this.colTk_Sp.VisibleIndex = 4;
            this.colTk_Sp.Width = 39;
            // 
            // colTk_Dt
            // 
            this.colTk_Dt.Caption = "TK đối tượng";
            this.colTk_Dt.FieldName = "Tk_Dt";
            this.colTk_Dt.Name = "colTk_Dt";
            this.colTk_Dt.Visible = true;
            this.colTk_Dt.VisibleIndex = 5;
            this.colTk_Dt.Width = 39;
            // 
            // colTk_Km
            // 
            this.colTk_Km.Caption = "TK khoản mục";
            this.colTk_Km.FieldName = "Tk_Km";
            this.colTk_Km.Name = "colTk_Km";
            this.colTk_Km.Visible = true;
            this.colTk_Km.VisibleIndex = 6;
            this.colTk_Km.Width = 39;
            // 
            // colMa_Tte_Goc
            // 
            this.colMa_Tte_Goc.Caption = "Mã tiền tệ gốc";
            this.colMa_Tte_Goc.FieldName = "Ma_Tte_Goc";
            this.colMa_Tte_Goc.Name = "colMa_Tte_Goc";
            this.colMa_Tte_Goc.Visible = true;
            this.colMa_Tte_Goc.VisibleIndex = 8;
            this.colMa_Tte_Goc.Width = 39;
            // 
            // colMa_Data
            // 
            this.colMa_Data.Caption = "Mã Data";
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 7;
            this.colMa_Data.Width = 39;
            // 
            // e00DMTKTableAdapter
            // 
            this.e00DMTKTableAdapter.ClearBeforeFill = true;
            // 
            // DMTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "DMTK";
            this.Text = "DMTK";
            this.Load += new System.EventHandler(this.DMTK_Load);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMTKBindingSource;
        private EWONDATASETTableAdapters.E00DMTKTableAdapter e00DMTKTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTk;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Tk;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Sp;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Km;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Tte_Goc;
    }
}