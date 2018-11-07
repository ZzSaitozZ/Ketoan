namespace Ketoan.Controls.HangTonKho.PhieuNhapThanhPham
{
    partial class FPhieuNhapThanhPham
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
            this.panelDetails = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nhantp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mavattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenvattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.malo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mathue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkNoVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkCoVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayhd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sohd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manghiepvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.madoituong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ongba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.gridControl2);
            this.panelDetails.Controls.Add(this.gridControl1);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(927, 519);
            this.panelDetails.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(0, 249);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(925, 270);
            this.gridControl2.TabIndex = 11;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nhantp,
            this.Mavattu,
            this.tenvattu,
            this.dv,
            this.tkno,
            this.malo,
            this.tkco,
            this.mathue,
            this.tienVat,
            this.tkNoVat,
            this.tkCoVat,
            this.ngayhd,
            this.sohd});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // Nhantp
            // 
            this.Nhantp.Caption = "Nhãn Tp";
            this.Nhantp.Name = "Nhantp";
            this.Nhantp.Visible = true;
            this.Nhantp.VisibleIndex = 0;
            // 
            // Mavattu
            // 
            this.Mavattu.Caption = "Mã vật tư";
            this.Mavattu.Name = "Mavattu";
            this.Mavattu.Visible = true;
            this.Mavattu.VisibleIndex = 1;
            // 
            // tenvattu
            // 
            this.tenvattu.Caption = "Tên vật tư";
            this.tenvattu.Name = "tenvattu";
            this.tenvattu.Visible = true;
            this.tenvattu.VisibleIndex = 2;
            // 
            // dv
            // 
            this.dv.Caption = "Đơn vị";
            this.dv.Name = "dv";
            this.dv.Visible = true;
            this.dv.VisibleIndex = 3;
            // 
            // tkno
            // 
            this.tkno.Caption = "tk nợ";
            this.tkno.Name = "tkno";
            this.tkno.Visible = true;
            this.tkno.VisibleIndex = 4;
            // 
            // malo
            // 
            this.malo.Caption = "Mã lô";
            this.malo.Name = "malo";
            this.malo.Visible = true;
            this.malo.VisibleIndex = 5;
            // 
            // tkco
            // 
            this.tkco.Caption = "Tk có";
            this.tkco.Name = "tkco";
            this.tkco.Visible = true;
            this.tkco.VisibleIndex = 6;
            // 
            // mathue
            // 
            this.mathue.Caption = "Mã bộ phận";
            this.mathue.Name = "mathue";
            this.mathue.Visible = true;
            this.mathue.VisibleIndex = 7;
            // 
            // tienVat
            // 
            this.tienVat.Caption = "Tiền Vat";
            this.tienVat.Name = "tienVat";
            this.tienVat.Visible = true;
            this.tienVat.VisibleIndex = 8;
            // 
            // tkNoVat
            // 
            this.tkNoVat.Caption = "Tk nợ VAT";
            this.tkNoVat.Name = "tkNoVat";
            this.tkNoVat.Visible = true;
            this.tkNoVat.VisibleIndex = 9;
            // 
            // tkCoVat
            // 
            this.tkCoVat.Caption = "Tk Có Vat";
            this.tkCoVat.Name = "tkCoVat";
            this.tkCoVat.Visible = true;
            this.tkCoVat.VisibleIndex = 10;
            // 
            // ngayhd
            // 
            this.ngayhd.Caption = "Ngày HĐ";
            this.ngayhd.Name = "ngayhd";
            this.ngayhd.Visible = true;
            this.ngayhd.VisibleIndex = 11;
            // 
            // sohd
            // 
            this.sohd.Caption = "Số HĐ";
            this.sohd.Name = "sohd";
            this.sohd.Visible = true;
            this.sohd.VisibleIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(924, 252);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mact,
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
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            // 
            // mact
            // 
            this.mact.Caption = "Mã CT";
            this.mact.Name = "mact";
            this.mact.Visible = true;
            this.mact.VisibleIndex = 0;
            // 
            // manghiepvu
            // 
            this.manghiepvu.Caption = "Mã nghiệp vụ";
            this.manghiepvu.Name = "manghiepvu";
            this.manghiepvu.Visible = true;
            this.manghiepvu.VisibleIndex = 1;
            // 
            // ngayct
            // 
            this.ngayct.Caption = "Ngày Ct";
            this.ngayct.Name = "ngayct";
            this.ngayct.Visible = true;
            this.ngayct.VisibleIndex = 2;
            // 
            // soct
            // 
            this.soct.Caption = "Số CT";
            this.soct.Name = "soct";
            this.soct.Visible = true;
            this.soct.VisibleIndex = 3;
            // 
            // DienGiai
            // 
            this.DienGiai.Caption = "Diễn Giải";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Visible = true;
            this.DienGiai.VisibleIndex = 4;
            // 
            // madoituong
            // 
            this.madoituong.Caption = "Mã đối tượng";
            this.madoituong.Name = "madoituong";
            this.madoituong.Visible = true;
            this.madoituong.VisibleIndex = 5;
            // 
            // Ongba
            // 
            this.Ongba.Caption = "Ông bà";
            this.Ongba.Name = "Ongba";
            this.Ongba.Visible = true;
            this.Ongba.VisibleIndex = 6;
            // 
            // tongtien
            // 
            this.tongtien.Caption = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.Visible = true;
            this.tongtien.VisibleIndex = 7;
            // 
            // ckDuyet
            // 
            this.ckDuyet.Caption = "Duyệt";
            this.ckDuyet.ColumnEdit = this.repositoryItemCheckEdit1;
            this.ckDuyet.Name = "ckDuyet";
            this.ckDuyet.Visible = true;
            this.ckDuyet.VisibleIndex = 8;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FPhieuNhapThanhPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 519);
            this.Controls.Add(this.panelDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPhieuNhapThanhPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPhieuNhapThanhPham";
            this.panelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Nhantp;
        private DevExpress.XtraGrid.Columns.GridColumn Mavattu;
        private DevExpress.XtraGrid.Columns.GridColumn tenvattu;
        private DevExpress.XtraGrid.Columns.GridColumn dv;
        private DevExpress.XtraGrid.Columns.GridColumn tkno;
        private DevExpress.XtraGrid.Columns.GridColumn malo;
        private DevExpress.XtraGrid.Columns.GridColumn tkco;
        private DevExpress.XtraGrid.Columns.GridColumn mathue;
        private DevExpress.XtraGrid.Columns.GridColumn tienVat;
        private DevExpress.XtraGrid.Columns.GridColumn tkNoVat;
        private DevExpress.XtraGrid.Columns.GridColumn tkCoVat;
        private DevExpress.XtraGrid.Columns.GridColumn ngayhd;
        private DevExpress.XtraGrid.Columns.GridColumn sohd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn mact;
        private DevExpress.XtraGrid.Columns.GridColumn manghiepvu;
        private DevExpress.XtraGrid.Columns.GridColumn ngayct;
        private DevExpress.XtraGrid.Columns.GridColumn soct;
        private DevExpress.XtraGrid.Columns.GridColumn DienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn madoituong;
        private DevExpress.XtraGrid.Columns.GridColumn Ongba;
        private DevExpress.XtraGrid.Columns.GridColumn tongtien;
        private DevExpress.XtraGrid.Columns.GridColumn ckDuyet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}