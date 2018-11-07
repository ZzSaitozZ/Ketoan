namespace Ketoan.Controls.CpGiaThanh
{
    partial class ETGT
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.thang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.msp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tensp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slsp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dtnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLdodang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoanthanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mayeuto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkchiphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mavattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenvattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slsd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slddck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tiendodangck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loaip = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(935, 296);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.thang,
            this.taikhoan,
            this.msp,
            this.tensp,
            this.slsp,
            this.Dtnhap,
            this.Gia,
            this.Tien,
            this.SLdodang,
            this.hoanthanh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // thang
            // 
            this.thang.Caption = "Tháng";
            this.thang.Name = "thang";
            this.thang.Visible = true;
            this.thang.VisibleIndex = 6;
            // 
            // taikhoan
            // 
            this.taikhoan.Caption = "Tài khoản";
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Visible = true;
            this.taikhoan.VisibleIndex = 0;
            // 
            // msp
            // 
            this.msp.Caption = "Mã sản phẩm";
            this.msp.Name = "msp";
            this.msp.Visible = true;
            this.msp.VisibleIndex = 1;
            // 
            // tensp
            // 
            this.tensp.Caption = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.Visible = true;
            this.tensp.VisibleIndex = 2;
            // 
            // slsp
            // 
            this.slsp.Caption = "Số lượng sản phẩm";
            this.slsp.Name = "slsp";
            this.slsp.Visible = true;
            this.slsp.VisibleIndex = 3;
            // 
            // Dtnhap
            // 
            this.Dtnhap.Caption = "Diện tích nhập";
            this.Dtnhap.Name = "Dtnhap";
            this.Dtnhap.Visible = true;
            this.Dtnhap.VisibleIndex = 4;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 5;
            // 
            // Tien
            // 
            this.Tien.Caption = "Tiền";
            this.Tien.Name = "Tien";
            this.Tien.Visible = true;
            this.Tien.VisibleIndex = 7;
            // 
            // SLdodang
            // 
            this.SLdodang.Caption = "Số lượng dở dang";
            this.SLdodang.Name = "SLdodang";
            this.SLdodang.Visible = true;
            this.SLdodang.VisibleIndex = 8;
            // 
            // hoanthanh
            // 
            this.hoanthanh.Caption = "%Hoàn thành";
            this.hoanthanh.Name = "hoanthanh";
            this.hoanthanh.Visible = true;
            this.hoanthanh.VisibleIndex = 9;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.gridControl2);
            this.panel.Controls.Add(this.simpleButton3);
            this.panel.Controls.Add(this.simpleButton2);
            this.panel.Controls.Add(this.simpleButton1);
            this.panel.Controls.Add(this.gridControl1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(935, 552);
            this.panel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(705, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 104);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương pháp xác định dở dang";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Chi phí kế hoạch";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(194, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sản phẩm hoàn thành tương đương";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Chi phí nguyên vật liệu trực tiếp";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(0, 302);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(699, 289);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mayeuto,
            this.tkchiphi,
            this.mavattu,
            this.tenvattu,
            this.dv,
            this.slsd,
            this.tsd,
            this.slddck,
            this.tiendodangck,
            this.loaip});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.Name = "gridView2";
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // mayeuto
            // 
            this.mayeuto.Caption = "Mã yếu tố";
            this.mayeuto.Name = "mayeuto";
            this.mayeuto.Visible = true;
            this.mayeuto.VisibleIndex = 0;
            // 
            // tkchiphi
            // 
            this.tkchiphi.Caption = "Tài khoản chi phí";
            this.tkchiphi.Name = "tkchiphi";
            this.tkchiphi.Visible = true;
            this.tkchiphi.VisibleIndex = 1;
            // 
            // mavattu
            // 
            this.mavattu.Caption = "Mã vật tư";
            this.mavattu.Name = "mavattu";
            this.mavattu.Visible = true;
            this.mavattu.VisibleIndex = 2;
            // 
            // tenvattu
            // 
            this.tenvattu.Caption = "Tên vật tư";
            this.tenvattu.Name = "tenvattu";
            this.tenvattu.Visible = true;
            this.tenvattu.VisibleIndex = 3;
            // 
            // dv
            // 
            this.dv.Caption = "ĐV";
            this.dv.Name = "dv";
            this.dv.Visible = true;
            this.dv.VisibleIndex = 4;
            // 
            // slsd
            // 
            this.slsd.Caption = "Số lượng sử dụng";
            this.slsd.Name = "slsd";
            this.slsd.Visible = true;
            this.slsd.VisibleIndex = 5;
            // 
            // tsd
            // 
            this.tsd.Caption = "Tiền sử dụng";
            this.tsd.Name = "tsd";
            this.tsd.Visible = true;
            this.tsd.VisibleIndex = 6;
            // 
            // slddck
            // 
            this.slddck.Caption = "Số lượng dở dang ck";
            this.slddck.Name = "slddck";
            this.slddck.Visible = true;
            this.slddck.VisibleIndex = 7;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton3.Location = new System.Drawing.Point(705, 378);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(227, 36);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Kiểm tra cập nhật";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Location = new System.Drawing.Point(705, 339);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(227, 33);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Cập nhật giá thành";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Location = new System.Drawing.Point(705, 302);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(227, 31);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Tính giá thành";
            // 
            // tiendodangck
            // 
            this.tiendodangck.Caption = "Tiền dở dang chiết khấu";
            this.tiendodangck.Name = "tiendodangck";
            this.tiendodangck.Visible = true;
            this.tiendodangck.VisibleIndex = 8;
            // 
            // loaip
            // 
            this.loaip.Caption = "Loại P";
            this.loaip.Name = "loaip";
            this.loaip.Visible = true;
            this.loaip.VisibleIndex = 9;
            // 
            // ETGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "ETGT";
            this.Size = new System.Drawing.Size(935, 552);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn taikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn msp;
        private DevExpress.XtraGrid.Columns.GridColumn tensp;
        private DevExpress.XtraGrid.Columns.GridColumn slsp;
        private DevExpress.XtraGrid.Columns.GridColumn Dtnhap;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn mayeuto;
        private DevExpress.XtraGrid.Columns.GridColumn tkchiphi;
        private DevExpress.XtraGrid.Columns.GridColumn mavattu;
        private DevExpress.XtraGrid.Columns.GridColumn dv;
        private DevExpress.XtraGrid.Columns.GridColumn slsd;
        private DevExpress.XtraGrid.Columns.GridColumn tsd;
        private DevExpress.XtraGrid.Columns.GridColumn slddck;
        private DevExpress.XtraGrid.Columns.GridColumn thang;
        private DevExpress.XtraGrid.Columns.GridColumn Tien;
        private DevExpress.XtraGrid.Columns.GridColumn SLdodang;
        private DevExpress.XtraGrid.Columns.GridColumn hoanthanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraGrid.Columns.GridColumn tenvattu;
        private DevExpress.XtraGrid.Columns.GridColumn tiendodangck;
        private DevExpress.XtraGrid.Columns.GridColumn loaip;
    }
}
