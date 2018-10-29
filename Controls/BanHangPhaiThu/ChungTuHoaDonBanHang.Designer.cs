namespace Ketoan.Controls.BanHangPhaiThu
{
    partial class ChungTuHoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChungTuHoaDonBanHang));
            this.panel = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.gridControl2);
            this.panel.Controls.Add(this.gridControl1);
            this.panel.Controls.Add(this.labelControl3);
            this.panel.Controls.Add(this.textBox5);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.textBox3);
            this.panel.Controls.Add(this.textBox4);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.btnThoat);
            this.panel.Controls.Add(this.btnLoc);
            this.panel.Controls.Add(this.btnIn);
            this.panel.Controls.Add(this.btnXem);
            this.panel.Controls.Add(this.btnXoa);
            this.panel.Controls.Add(this.btnSua);
            this.panel.Controls.Add(this.btnThem);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(953, 552);
            this.panel.TabIndex = 4;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(3, 271);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(947, 191);
            this.gridControl2.TabIndex = 32;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(950, 262);
            this.gridControl1.TabIndex = 31;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView1_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(654, 525);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Tổng SL";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(722, 522);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 29;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(654, 499);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Tiền VAT";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(654, 471);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tiền Hàng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(828, 496);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(722, 496);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(828, 468);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(722, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(512, 480);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 32);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.ImageOptions.Image")));
            this.btnLoc.Location = new System.Drawing.Point(428, 480);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(78, 32);
            this.btnLoc.TabIndex = 21;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(344, 480);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(78, 32);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(260, 480);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(78, 32);
            this.btnXem.TabIndex = 19;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(176, 480);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 32);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(92, 480);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 32);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(8, 480);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 32);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // esP_GetCTCTHDTableAdapter1
            // 
            // 
            // ChungTuHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "ChungTuHoaDonBanHang";
            this.Size = new System.Drawing.Size(1000, 600);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox textBox5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
     }
}
