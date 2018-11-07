namespace Ketoan.Table
{
    partial class EDMNHNHAN
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
            this.ewondataset1 = new Ketoan.EWONDATASET();
            this.e00DMNHANTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.E00DMNHANTableAdapter();
            this.colNhan_TP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Lo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHe_So = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoi_Luong_CoBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_TP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMNHAN";
            this.gridControl1.DataSource = this.ewondataset1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(660, 460);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhan_TP,
            this.colNgay_Nhap,
            this.colMa_Lo,
            this.colMa_Vt,
            this.colSize,
            this.colSo_Luong,
            this.colHe_So,
            this.colKhoi_Luong_CoBB,
            this.colLoai_TP,
            this.colMa_Data,
            this.colGhi_Chu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMNHANTableAdapter1
            // 
            this.e00DMNHANTableAdapter1.ClearBeforeFill = true;
            // 
            // colNhan_TP
            // 
            this.colNhan_TP.FieldName = "Nhan_TP";
            this.colNhan_TP.Name = "colNhan_TP";
            this.colNhan_TP.Visible = true;
            this.colNhan_TP.VisibleIndex = 0;
            // 
            // colNgay_Nhap
            // 
            this.colNgay_Nhap.FieldName = "Ngay_Nhap";
            this.colNgay_Nhap.Name = "colNgay_Nhap";
            this.colNgay_Nhap.Visible = true;
            this.colNgay_Nhap.VisibleIndex = 1;
            // 
            // colMa_Lo
            // 
            this.colMa_Lo.FieldName = "Ma_Lo";
            this.colMa_Lo.Name = "colMa_Lo";
            this.colMa_Lo.Visible = true;
            this.colMa_Lo.VisibleIndex = 2;
            // 
            // colMa_Vt
            // 
            this.colMa_Vt.FieldName = "Ma_Vt";
            this.colMa_Vt.Name = "colMa_Vt";
            this.colMa_Vt.Visible = true;
            this.colMa_Vt.VisibleIndex = 3;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 4;
            // 
            // colSo_Luong
            // 
            this.colSo_Luong.FieldName = "So_Luong";
            this.colSo_Luong.Name = "colSo_Luong";
            this.colSo_Luong.Visible = true;
            this.colSo_Luong.VisibleIndex = 5;
            // 
            // colHe_So
            // 
            this.colHe_So.FieldName = "He_So";
            this.colHe_So.Name = "colHe_So";
            this.colHe_So.Visible = true;
            this.colHe_So.VisibleIndex = 6;
            // 
            // colKhoi_Luong_CoBB
            // 
            this.colKhoi_Luong_CoBB.FieldName = "Khoi_Luong_CoBB";
            this.colKhoi_Luong_CoBB.Name = "colKhoi_Luong_CoBB";
            this.colKhoi_Luong_CoBB.Visible = true;
            this.colKhoi_Luong_CoBB.VisibleIndex = 7;
            // 
            // colLoai_TP
            // 
            this.colLoai_TP.FieldName = "Loai_TP";
            this.colLoai_TP.Name = "colLoai_TP";
            this.colLoai_TP.Visible = true;
            this.colLoai_TP.VisibleIndex = 8;
            // 
            // colMa_Data
            // 
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 9;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 10;
            // 
            // DMNHNHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "DMNHNHAN";
            this.Size = new System.Drawing.Size(660, 460);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EWONDATASET ewondataset1;
        private DevExpress.XtraGrid.Columns.GridColumn colNhan_TP;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Nhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Lo;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Luong;
        private DevExpress.XtraGrid.Columns.GridColumn colHe_So;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoi_Luong_CoBB;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_TP;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private EWONDATASETTableAdapters.E00DMNHANTableAdapter e00DMNHANTableAdapter1;
    }
}
