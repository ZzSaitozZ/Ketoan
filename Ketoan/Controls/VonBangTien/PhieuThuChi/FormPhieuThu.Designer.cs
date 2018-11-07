namespace Ketoan.Controls.VonBangTien.PhieuThuChi
{
    partial class FormPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuThu));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.e10PHVBTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ewondataset1 = new Ketoan.EWONDATASET();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Ct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Ct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Ct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOng_Ba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Giai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.e10CTVBTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTk_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_Nt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Dt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Bp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_No3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Co3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_Nt3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_Nt9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThue_GtGt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Hd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.e10PHVBTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E10PHVBTTableAdapter();
            this.e10CTVBTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E10CTVBTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e10PHVBTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e10CTVBTBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Size = new System.Drawing.Size(800, 375);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 144);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.e10PHVBTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 375);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // e10PHVBTBindingSource
            // 
            this.e10PHVBTBindingSource.DataMember = "E10PHVBT";
            this.e10PHVBTBindingSource.DataSource = this.ewondataset1;
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nvu,
            this.colMa_Ct,
            this.colNgay_Ct,
            this.colSo_Ct,
            this.colMa_Dt,
            this.colOng_Ba,
            this.colDia_Chi,
            this.colDien_Giai,
            this.colTien1,
            this.colPosted});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick_1);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colMa_Nvu
            // 
            this.colMa_Nvu.Caption = "Mã nghiệp vụ";
            this.colMa_Nvu.FieldName = "Ma_Nvu";
            this.colMa_Nvu.Name = "colMa_Nvu";
            this.colMa_Nvu.Visible = true;
            this.colMa_Nvu.VisibleIndex = 0;
            // 
            // colMa_Ct
            // 
            this.colMa_Ct.Caption = "Mã Ct";
            this.colMa_Ct.FieldName = "Ma_Ct";
            this.colMa_Ct.Name = "colMa_Ct";
            this.colMa_Ct.Visible = true;
            this.colMa_Ct.VisibleIndex = 1;
            // 
            // colNgay_Ct
            // 
            this.colNgay_Ct.Caption = "Ngày Ct";
            this.colNgay_Ct.FieldName = "Ngay_Ct";
            this.colNgay_Ct.Name = "colNgay_Ct";
            this.colNgay_Ct.Visible = true;
            this.colNgay_Ct.VisibleIndex = 2;
            // 
            // colSo_Ct
            // 
            this.colSo_Ct.Caption = "Số Ct";
            this.colSo_Ct.FieldName = "So_Ct";
            this.colSo_Ct.Name = "colSo_Ct";
            this.colSo_Ct.Visible = true;
            this.colSo_Ct.VisibleIndex = 3;
            // 
            // colMa_Dt
            // 
            this.colMa_Dt.Caption = "Mã Dt";
            this.colMa_Dt.FieldName = "Ma_Dt";
            this.colMa_Dt.Name = "colMa_Dt";
            this.colMa_Dt.Visible = true;
            this.colMa_Dt.VisibleIndex = 4;
            // 
            // colOng_Ba
            // 
            this.colOng_Ba.Caption = "Ông bà";
            this.colOng_Ba.FieldName = "Ong_Ba";
            this.colOng_Ba.Name = "colOng_Ba";
            this.colOng_Ba.Visible = true;
            this.colOng_Ba.VisibleIndex = 5;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 6;
            // 
            // colDien_Giai
            // 
            this.colDien_Giai.Caption = "Diễn giải";
            this.colDien_Giai.FieldName = "Dien_Giai";
            this.colDien_Giai.Name = "colDien_Giai";
            this.colDien_Giai.Visible = true;
            this.colDien_Giai.VisibleIndex = 7;
            // 
            // colTien1
            // 
            this.colTien1.Caption = "Tiền";
            this.colTien1.FieldName = "Tien";
            this.colTien1.Name = "colTien1";
            this.colTien1.Visible = true;
            this.colTien1.VisibleIndex = 8;
            // 
            // colPosted
            // 
            this.colPosted.Caption = "Duyệt";
            this.colPosted.FieldName = "Posted";
            this.colPosted.Name = "colPosted";
            this.colPosted.Visible = true;
            this.colPosted.VisibleIndex = 9;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.e10CTVBTBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl2.Location = new System.Drawing.Point(0, 175);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.ribbonControl1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(800, 200);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // e10CTVBTBindingSource
            // 
            this.e10CTVBTBindingSource.DataMember = "E10CTVBT";
            this.e10CTVBTBindingSource.DataSource = this.ewondataset1;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTk_No,
            this.colTk_Co,
            this.colTien_Nt,
            this.colMa_Dt1,
            this.colMa_Bp,
            this.colMa_Km,
            this.colMa_Thue,
            this.colTien3,
            this.colTk_No3,
            this.colTk_Co3,
            this.colTien_Nt3,
            this.colTien_Nt9,
            this.colThue_GtGt,
            this.colMa_Hd});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            // 
            // colTk_No
            // 
            this.colTk_No.Caption = "Tài khoản nợ";
            this.colTk_No.FieldName = "Tk_No";
            this.colTk_No.Name = "colTk_No";
            this.colTk_No.Visible = true;
            this.colTk_No.VisibleIndex = 0;
            // 
            // colTk_Co
            // 
            this.colTk_Co.Caption = "Tài khoản có";
            this.colTk_Co.FieldName = "Tk_Co";
            this.colTk_Co.Name = "colTk_Co";
            this.colTk_Co.Visible = true;
            this.colTk_Co.VisibleIndex = 1;
            // 
            // colTien_Nt
            // 
            this.colTien_Nt.Caption = "Tiền Nt";
            this.colTien_Nt.FieldName = "Tien_Nt";
            this.colTien_Nt.Name = "colTien_Nt";
            this.colTien_Nt.Visible = true;
            this.colTien_Nt.VisibleIndex = 2;
            // 
            // colMa_Dt1
            // 
            this.colMa_Dt1.Caption = "Mã DT";
            this.colMa_Dt1.FieldName = "Ma_Dt";
            this.colMa_Dt1.Name = "colMa_Dt1";
            this.colMa_Dt1.Visible = true;
            this.colMa_Dt1.VisibleIndex = 3;
            // 
            // colMa_Bp
            // 
            this.colMa_Bp.Caption = "Mã Bộ phận";
            this.colMa_Bp.FieldName = "Ma_Bp";
            this.colMa_Bp.Name = "colMa_Bp";
            this.colMa_Bp.Visible = true;
            this.colMa_Bp.VisibleIndex = 4;
            // 
            // colMa_Km
            // 
            this.colMa_Km.Caption = "Mã Km";
            this.colMa_Km.FieldName = "Ma_Km";
            this.colMa_Km.Name = "colMa_Km";
            this.colMa_Km.Visible = true;
            this.colMa_Km.VisibleIndex = 5;
            // 
            // colMa_Thue
            // 
            this.colMa_Thue.Caption = "Mã Sản Phẩm";
            this.colMa_Thue.FieldName = "Ma_Thue";
            this.colMa_Thue.Name = "colMa_Thue";
            this.colMa_Thue.Visible = true;
            this.colMa_Thue.VisibleIndex = 6;
            // 
            // colTien3
            // 
            this.colTien3.Caption = "Tiền VAT";
            this.colTien3.FieldName = "Tien3";
            this.colTien3.Name = "colTien3";
            this.colTien3.Visible = true;
            this.colTien3.VisibleIndex = 7;
            // 
            // colTk_No3
            // 
            this.colTk_No3.Caption = "Tiền nợ VAT";
            this.colTk_No3.FieldName = "Tk_No3";
            this.colTk_No3.Name = "colTk_No3";
            this.colTk_No3.Visible = true;
            this.colTk_No3.VisibleIndex = 8;
            // 
            // colTk_Co3
            // 
            this.colTk_Co3.Caption = "Tiền có VAT";
            this.colTk_Co3.FieldName = "Tk_Co3";
            this.colTk_Co3.Name = "colTk_Co3";
            this.colTk_Co3.Visible = true;
            this.colTk_Co3.VisibleIndex = 9;
            // 
            // colTien_Nt3
            // 
            this.colTien_Nt3.FieldName = "Tien_Nt3";
            this.colTien_Nt3.Name = "colTien_Nt3";
            this.colTien_Nt3.Visible = true;
            this.colTien_Nt3.VisibleIndex = 10;
            // 
            // colTien_Nt9
            // 
            this.colTien_Nt9.FieldName = "Tien_Nt9";
            this.colTien_Nt9.Name = "colTien_Nt9";
            this.colTien_Nt9.Visible = true;
            this.colTien_Nt9.VisibleIndex = 11;
            // 
            // colThue_GtGt
            // 
            this.colThue_GtGt.FieldName = "Thue_GtGt";
            this.colThue_GtGt.Name = "colThue_GtGt";
            this.colThue_GtGt.Visible = true;
            this.colThue_GtGt.VisibleIndex = 12;
            // 
            // colMa_Hd
            // 
            this.colMa_Hd.Caption = "Mã Hd";
            this.colMa_Hd.FieldName = "Ma_Hd";
            this.colMa_Hd.Name = "colMa_Hd";
            this.colMa_Hd.Visible = true;
            this.colMa_Hd.VisibleIndex = 13;
            // 
            // e10PHVBTTableAdapter
            // 
            this.e10PHVBTTableAdapter.ClearBeforeFill = true;
            // 
            // e10CTVBTTableAdapter
            // 
            this.e10CTVBTTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Name = "FormPhieuThu";
            this.Text = "FormPhieuThu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPhieuThu_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e10PHVBTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e10CTVBTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colStt;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nvu;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Ct;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Ct;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Ct;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colOng_Ba;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Giai;
        private DevExpress.XtraGrid.Columns.GridColumn colTien1;
        private DevExpress.XtraGrid.Columns.GridColumn colPosted;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_No;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Co;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_Nt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Dt1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Bp;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Km;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colTien3;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_No3;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Co3;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_Nt3;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_Nt9;
        private DevExpress.XtraGrid.Columns.GridColumn colThue_GtGt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hd;
        private EWONDATASET ewondataset1;
        private System.Windows.Forms.BindingSource e10PHVBTBindingSource;
        private EWONDATASETTableAdapters.E10PHVBTTableAdapter e10PHVBTTableAdapter;
        private System.Windows.Forms.BindingSource e10CTVBTBindingSource;
        private EWONDATASETTableAdapters.E10CTVBTTableAdapter e10CTVBTTableAdapter;
    }
}