namespace Ketoan.Controls.CpGiaThanh
{
    partial class ECPGT
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
            this.taikhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taikhoanchiphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mavattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenvattu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soluongps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tienps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tkhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mayeuto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkchiphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.masanpham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tensanpham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tyle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loaip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(699, 296);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.taikhoan,
            this.taikhoanchiphi,
            this.mavattu,
            this.tenvattu,
            this.Soluongps,
            this.Tienps});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // taikhoan
            // 
            this.taikhoan.Caption = "Tài khoản";
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Visible = true;
            this.taikhoan.VisibleIndex = 0;
            // 
            // taikhoanchiphi
            // 
            this.taikhoanchiphi.Caption = "Tài khoản chi phí";
            this.taikhoanchiphi.Name = "taikhoanchiphi";
            this.taikhoanchiphi.Visible = true;
            this.taikhoanchiphi.VisibleIndex = 1;
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
            // Soluongps
            // 
            this.Soluongps.Caption = "Số lượng ps";
            this.Soluongps.Name = "Soluongps";
            this.Soluongps.Visible = true;
            this.Soluongps.VisibleIndex = 4;
            // 
            // Tienps
            // 
            this.Tienps.Caption = "Tiền ps";
            this.Tienps.Name = "Tienps";
            this.Tienps.Visible = true;
            this.Tienps.VisibleIndex = 5;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.gridControl2);
            this.panel.Controls.Add(this.simpleButton7);
            this.panel.Controls.Add(this.simpleButton6);
            this.panel.Controls.Add(this.simpleButton5);
            this.panel.Controls.Add(this.simpleButton4);
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
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(0, 302);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(932, 289);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.AutoFillColumn = this.loaip;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tkhoan,
            this.mayeuto,
            this.tkchiphi,
            this.masanpham,
            this.tensanpham,
            this.slps,
            this.tps,
            this.tyle,
            this.loaip});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.Name = "gridView2";
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // tkhoan
            // 
            this.tkhoan.Caption = "Tài khoản";
            this.tkhoan.Name = "tkhoan";
            this.tkhoan.Visible = true;
            this.tkhoan.VisibleIndex = 0;
            // 
            // mayeuto
            // 
            this.mayeuto.Caption = "Mã yếu tố";
            this.mayeuto.Name = "mayeuto";
            this.mayeuto.Visible = true;
            this.mayeuto.VisibleIndex = 2;
            // 
            // tkchiphi
            // 
            this.tkchiphi.Caption = "Tài khoản chi phí";
            this.tkchiphi.Name = "tkchiphi";
            this.tkchiphi.Visible = true;
            this.tkchiphi.VisibleIndex = 1;
            // 
            // masanpham
            // 
            this.masanpham.Caption = "Mã sản phẩm";
            this.masanpham.Name = "masanpham";
            this.masanpham.Visible = true;
            this.masanpham.VisibleIndex = 6;
            // 
            // tensanpham
            // 
            this.tensanpham.Caption = "Tên sản phẩm";
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.Visible = true;
            this.tensanpham.VisibleIndex = 7;
            // 
            // slps
            // 
            this.slps.Caption = "Số lượng ps";
            this.slps.Name = "slps";
            this.slps.Visible = true;
            this.slps.VisibleIndex = 4;
            // 
            // tps
            // 
            this.tps.Caption = "Tiền ps";
            this.tps.Name = "tps";
            this.tps.Visible = true;
            this.tps.VisibleIndex = 5;
            // 
            // tyle
            // 
            this.tyle.Caption = "Tỷ lệ";
            this.tyle.Name = "tyle";
            this.tyle.Visible = true;
            this.tyle.VisibleIndex = 3;
            // 
            // loaip
            // 
            this.loaip.Caption = "Loại P";
            this.loaip.Name = "loaip";
            this.loaip.Visible = true;
            this.loaip.VisibleIndex = 8;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Options.UseTextOptions = true;
            this.simpleButton7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton7.Location = new System.Drawing.Point(705, 243);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(227, 37);
            this.simpleButton7.TabIndex = 13;
            this.simpleButton7.Text = "7.Kiểm tra sản phẩm chưa có định mức";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Options.UseTextOptions = true;
            this.simpleButton6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton6.Location = new System.Drawing.Point(705, 203);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(227, 34);
            this.simpleButton6.TabIndex = 12;
            this.simpleButton6.Text = "6.Kiểm tra định mức";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Options.UseTextOptions = true;
            this.simpleButton5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton5.Location = new System.Drawing.Point(705, 162);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(227, 35);
            this.simpleButton5.TabIndex = 11;
            this.simpleButton5.Text = "5.Kiểm tra kết quả phân bổ";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Options.UseTextOptions = true;
            this.simpleButton4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton4.Location = new System.Drawing.Point(705, 121);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(227, 35);
            this.simpleButton4.TabIndex = 10;
            this.simpleButton4.Text = "4.Phân bổ chi phí theo phương pháp hệ số";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton3.Location = new System.Drawing.Point(705, 79);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(227, 36);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "3.Phân bổ chi phí theo phương pháp định mức";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton2.Location = new System.Drawing.Point(705, 40);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(227, 33);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "2.Phân bổ chi phí theo phương pháp tỷ lệ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton1.Location = new System.Drawing.Point(705, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(227, 31);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "1.Kết chuyển chi phi trực tiếp";
            // 
            // ECPGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "ECPGT";
            this.Size = new System.Drawing.Size(935, 552);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn taikhoan;
        private DevExpress.XtraGrid.Columns.GridColumn taikhoanchiphi;
        private DevExpress.XtraGrid.Columns.GridColumn mavattu;
        private DevExpress.XtraGrid.Columns.GridColumn tenvattu;
        private DevExpress.XtraGrid.Columns.GridColumn Soluongps;
        private DevExpress.XtraGrid.Columns.GridColumn Tienps;
        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn tkhoan;
        private DevExpress.XtraGrid.Columns.GridColumn mayeuto;
        private DevExpress.XtraGrid.Columns.GridColumn tkchiphi;
        private DevExpress.XtraGrid.Columns.GridColumn masanpham;
        private DevExpress.XtraGrid.Columns.GridColumn tensanpham;
        private DevExpress.XtraGrid.Columns.GridColumn slps;
        private DevExpress.XtraGrid.Columns.GridColumn tps;
        private DevExpress.XtraGrid.Columns.GridColumn tyle;
        private DevExpress.XtraGrid.Columns.GridColumn loaip;
    }
}
