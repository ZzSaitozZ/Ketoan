namespace Ketoan.Controls.Hangtonkho.Phieuxuatban
{
    partial class Phieuxuatban
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Mavattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenvattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Makho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.So_Luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manghiepvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.madoituong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ongba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
     //       this.filterPhieuXBTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.FilterPhieuXBTableAdapter();
     //       this.filterChiTietPhieuXBTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.FilterChiTietPhieuXBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 531);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gridControl2
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl2.Location = new System.Drawing.Point(-3, 276);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1172, 255);
            this.gridControl2.TabIndex = 11;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Mavattu,
            this.tenvattu,
            this.dv,
            this.tkno,
            this.tkco,
            this.Makho,
            this.So_Luong,
            this.Gia,
            this.Tien});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // Mavattu
            // 
            this.Mavattu.Caption = "Mã vật tư";
            this.Mavattu.FieldName = "Ma_Vt";
            this.Mavattu.Name = "Mavattu";
            this.Mavattu.Visible = true;
            this.Mavattu.VisibleIndex = 0;
            // 
            // tenvattu
            // 
            this.tenvattu.Caption = "Tên vật tư";
            this.tenvattu.FieldName = "Ten_Vt";
            this.tenvattu.Name = "tenvattu";
            this.tenvattu.Visible = true;
            this.tenvattu.VisibleIndex = 1;
            // 
            // dv
            // 
            this.dv.Caption = "Đơn vị";
            this.dv.FieldName = "Dvt";
            this.dv.Name = "dv";
            this.dv.Visible = true;
            this.dv.VisibleIndex = 2;
            // 
            // tkno
            // 
            this.tkno.Caption = "tk nợ";
            this.tkno.FieldName = "Tk_No";
            this.tkno.Name = "tkno";
            this.tkno.Visible = true;
            this.tkno.VisibleIndex = 3;
            // 
            // tkco
            // 
            this.tkco.Caption = "Tk có";
            this.tkco.FieldName = "Tk_Co";
            this.tkco.Name = "tkco";
            this.tkco.Visible = true;
            this.tkco.VisibleIndex = 4;
            // 
            // Makho
            // 
            this.Makho.Caption = "Mã Kho";
            this.Makho.FieldName = "makho";
            this.Makho.Name = "Makho";
            this.Makho.Visible = true;
            this.Makho.VisibleIndex = 8;
            // 
            // So_Luong
            // 
            this.So_Luong.Caption = "Số lượng";
            this.So_Luong.FieldName = "So_Luong";
            this.So_Luong.Name = "So_Luong";
            this.So_Luong.Visible = true;
            this.So_Luong.VisibleIndex = 5;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá Nt";
            this.Gia.FieldName = "Gia";
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 6;
            // 
            // Tien
            // 
            this.Tien.Caption = "Tiền NT";
            this.Tien.FieldName = "Tien";
            this.Tien.Name = "Tien";
            this.Tien.Visible = true;
            this.Tien.VisibleIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-3, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1172, 279);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stt,
            this.manghiepvu,
            this.ngayct,
            this.soct,
            this.DienGiai,
            this.madoituong,
            this.Ongba,
            this.tongtien,
            this.ckDuyet});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(845, 294, 210, 172);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // Stt
            // 
            this.Stt.Caption = "STT";
            this.Stt.FieldName = "Stt";
            this.Stt.Name = "Stt";
            // 
            // manghiepvu
            // 
            this.manghiepvu.Caption = "Mã nghiệp vụ";
            this.manghiepvu.FieldName = "Ma_Ct";
            this.manghiepvu.Name = "manghiepvu";
            this.manghiepvu.Visible = true;
            this.manghiepvu.VisibleIndex = 0;
            // 
            // ngayct
            // 
            this.ngayct.Caption = "Ngày Ct";
            this.ngayct.FieldName = "Ngay_Ct";
            this.ngayct.Name = "ngayct";
            this.ngayct.Visible = true;
            this.ngayct.VisibleIndex = 1;
            // 
            // soct
            // 
            this.soct.Caption = "Số CT";
            this.soct.FieldName = "So_Ct";
            this.soct.Name = "soct";
            this.soct.Visible = true;
            this.soct.VisibleIndex = 2;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn Giải";
            this.DienGiai.FieldName = "Dien_Giai";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 3;
            // 
            // madoituong
            // 
            this.madoituong.Caption = "Mã đối tượng";
            this.madoituong.FieldName = "Ma_DT";
            this.madoituong.Name = "madoituong";
            this.madoituong.Visible = true;
            this.madoituong.VisibleIndex = 4;
            // 
            // Ongba
            // 
            this.Ongba.Caption = "Ông bà";
            this.Ongba.FieldName = "Ten_Dt";
            this.Ongba.Name = "Ongba";
            this.Ongba.Visible = true;
            this.Ongba.VisibleIndex = 5;
            // 
            // tongtien
            // 
            this.tongtien.Caption = "Tổng tiền";
            this.tongtien.FieldName = "Thanh_Tien_GV";
            this.tongtien.Name = "tongtien";
            this.tongtien.Visible = true;
            this.tongtien.VisibleIndex = 6;
            // 
            // ckDuyet
            // 
            this.ckDuyet.Caption = "Duyệt";
            this.ckDuyet.ColumnEdit = this.repositoryItemCheckEdit1;
            this.ckDuyet.FieldName = "Xuat_HD";
            this.ckDuyet.Name = "ckDuyet";
            this.ckDuyet.Visible = true;
            this.ckDuyet.VisibleIndex = 7;
            // 
            // filterPhieuXBTableAdapter1
            // 
        //    this.filterPhieuXBTableAdapter1.ClearBeforeFill = true;
            // 
            // filterChiTietPhieuXBTableAdapter1
            // 
       //     this.filterChiTietPhieuXBTableAdapter1.ClearBeforeFill = true;
            // 
            // Phieuxuatban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Phieuxuatban";
            this.Size = new System.Drawing.Size(1169, 531);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Mavattu;
        private DevExpress.XtraGrid.Columns.GridColumn tenvattu;
        private DevExpress.XtraGrid.Columns.GridColumn dv;
        private DevExpress.XtraGrid.Columns.GridColumn tkno;
        private DevExpress.XtraGrid.Columns.GridColumn tkco;
        private DevExpress.XtraGrid.Columns.GridColumn So_Luong;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraGrid.Columns.GridColumn Tien;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn manghiepvu;
        private DevExpress.XtraGrid.Columns.GridColumn ngayct;
        private DevExpress.XtraGrid.Columns.GridColumn soct;
        private DevExpress.XtraGrid.Columns.GridColumn DienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn madoituong;
        private DevExpress.XtraGrid.Columns.GridColumn Ongba;
        private DevExpress.XtraGrid.Columns.GridColumn tongtien;
        private DevExpress.XtraGrid.Columns.GridColumn ckDuyet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Stt;
    //    private EWONDATASETTableAdapters.FilterPhieuXBTableAdapter filterPhieuXBTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn Makho;
    //    private EWONDATASETTableAdapters.FilterChiTietPhieuXBTableAdapter filterChiTietPhieuXBTableAdapter1;
    }
}
