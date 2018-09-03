namespace Ketoan.Table
{
    partial class ETHYT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTinhTien = new DevExpress.XtraEditors.SimpleButton();
            this.btnKetQua = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiPhi = new DevExpress.XtraEditors.SimpleButton();
            this.taikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mayeuto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taikhoanchiphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.masanpham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mabophan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mavattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenvattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLdodangdauky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tiendodangdauky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soluongps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tienps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.btnTinhTien);
            this.panel1.Controls.Add(this.btnKetQua);
            this.panel1.Controls.Add(this.btnChiPhi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 552);
            this.panel1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(853, 463);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.taikhoan,
            this.mayeuto,
            this.taikhoanchiphi,
            this.masanpham,
            this.mabophan,
            this.mavattu,
            this.tenvattu,
            this.dv,
            this.SLdodangdauky,
            this.Tiendodangdauky,
            this.Soluongps,
            this.Tienps});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(52, 501);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(135, 23);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền dở dang";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(193, 472);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(133, 23);
            this.btnKetQua.TabIndex = 4;
            this.btnKetQua.Text = "Kiểm tra kết quả tập hợp";
            // 
            // btnChiPhi
            // 
            this.btnChiPhi.Location = new System.Drawing.Point(52, 472);
            this.btnChiPhi.Name = "btnChiPhi";
            this.btnChiPhi.Size = new System.Drawing.Size(135, 23);
            this.btnChiPhi.TabIndex = 3;
            this.btnChiPhi.Text = "Tập hợp chi phí";
            // 
            // taikhoan
            // 
            this.taikhoan.Caption = "Tài khoản";
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Visible = true;
            this.taikhoan.VisibleIndex = 0;
            // 
            // mayeuto
            // 
            this.mayeuto.Caption = "Mã yếu tố";
            this.mayeuto.Name = "mayeuto";
            this.mayeuto.Visible = true;
            this.mayeuto.VisibleIndex = 1;
            // 
            // taikhoanchiphi
            // 
            this.taikhoanchiphi.Caption = "Tài khoản chi phí";
            this.taikhoanchiphi.Name = "taikhoanchiphi";
            this.taikhoanchiphi.Visible = true;
            this.taikhoanchiphi.VisibleIndex = 2;
            // 
            // masanpham
            // 
            this.masanpham.Caption = "Mã sản phẩm";
            this.masanpham.Name = "masanpham";
            this.masanpham.Visible = true;
            this.masanpham.VisibleIndex = 3;
            // 
            // mabophan
            // 
            this.mabophan.Caption = "Mã bộ phận";
            this.mabophan.Name = "mabophan";
            this.mabophan.Visible = true;
            this.mabophan.VisibleIndex = 4;
            // 
            // mavattu
            // 
            this.mavattu.Caption = "Mã vật tư";
            this.mavattu.Name = "mavattu";
            this.mavattu.Visible = true;
            this.mavattu.VisibleIndex = 5;
            // 
            // tenvattu
            // 
            this.tenvattu.Caption = "Tên vật tư";
            this.tenvattu.Name = "tenvattu";
            this.tenvattu.Visible = true;
            this.tenvattu.VisibleIndex = 6;
            // 
            // dv
            // 
            this.dv.Caption = "Đơn vị";
            this.dv.Name = "dv";
            this.dv.Visible = true;
            this.dv.VisibleIndex = 7;
            // 
            // SLdodangdauky
            // 
            this.SLdodangdauky.Caption = "Số lượng dở dang đầu kỳ";
            this.SLdodangdauky.Name = "SLdodangdauky";
            this.SLdodangdauky.Visible = true;
            this.SLdodangdauky.VisibleIndex = 8;
            // 
            // Tiendodangdauky
            // 
            this.Tiendodangdauky.Caption = "Tiền dở dang đầu kỳ";
            this.Tiendodangdauky.Name = "Tiendodangdauky";
            this.Tiendodangdauky.Visible = true;
            this.Tiendodangdauky.VisibleIndex = 9;
            // 
            // Soluongps
            // 
            this.Soluongps.Caption = "Số lượng ps";
            this.Soluongps.Name = "Soluongps";
            this.Soluongps.Visible = true;
            this.Soluongps.VisibleIndex = 10;
            // 
            // Tienps
            // 
            this.Tienps.Caption = "Tiền ps";
            this.Tienps.Name = "Tienps";
            this.Tienps.Visible = true;
            this.Tienps.VisibleIndex = 11;
            // 
            // ETHYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ETHYT";
            this.Size = new System.Drawing.Size(853, 552);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTinhTien;
        private DevExpress.XtraEditors.SimpleButton btnKetQua;
        private DevExpress.XtraEditors.SimpleButton btnChiPhi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn taikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn mayeuto;
        private DevExpress.XtraGrid.Columns.GridColumn taikhoanchiphi;
        private DevExpress.XtraGrid.Columns.GridColumn masanpham;
        private DevExpress.XtraGrid.Columns.GridColumn mabophan;
        private DevExpress.XtraGrid.Columns.GridColumn mavattu;
        private DevExpress.XtraGrid.Columns.GridColumn tenvattu;
        public DevExpress.XtraGrid.Columns.GridColumn dv;
        private DevExpress.XtraGrid.Columns.GridColumn SLdodangdauky;
        private DevExpress.XtraGrid.Columns.GridColumn Tiendodangdauky;
        private DevExpress.XtraGrid.Columns.GridColumn Soluongps;
        private DevExpress.XtraGrid.Columns.GridColumn Tienps;
    }
}
