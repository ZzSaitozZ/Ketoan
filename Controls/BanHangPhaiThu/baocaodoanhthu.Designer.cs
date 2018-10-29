﻿namespace Ketoan.Controls.BanHangPhaiThu
{
    partial class baocaodoanhthu
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
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.baocaobanhangTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.baocaobanhangTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgay_HD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanh_Tien_GB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_VAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_Phucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_Giam_Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_VAT_Giam_Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baocaobanhangTableAdapter1
            // 
            this.baocaobanhangTableAdapter1.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(812, 236);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgay_HD,
            this.colMa_Vt,
            this.colTen_Vt,
            this.colDvt,
            this.colSo_Luong,
            this.colThanh_Tien_GB,
            this.colTien_VAT,
            this.colTien_Phucvu,
            this.colTien_Giam_Gia,
            this.colTien_VAT_Giam_Gia,
            this.colTongtien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colNgay_HD
            // 
            this.colNgay_HD.FieldName = "Ngay_HD";
            this.colNgay_HD.Name = "colNgay_HD";
            this.colNgay_HD.Visible = true;
            this.colNgay_HD.VisibleIndex = 0;
            this.colNgay_HD.Width = 72;
            // 
            // colMa_Vt
            // 
            this.colMa_Vt.FieldName = "Ma_Vt";
            this.colMa_Vt.Name = "colMa_Vt";
            this.colMa_Vt.Visible = true;
            this.colMa_Vt.VisibleIndex = 1;
            this.colMa_Vt.Width = 72;
            // 
            // colTen_Vt
            // 
            this.colTen_Vt.FieldName = "Ten_Vt";
            this.colTen_Vt.Name = "colTen_Vt";
            this.colTen_Vt.Visible = true;
            this.colTen_Vt.VisibleIndex = 2;
            this.colTen_Vt.Width = 72;
            // 
            // colDvt
            // 
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 3;
            this.colDvt.Width = 72;
            // 
            // colSo_Luong
            // 
            this.colSo_Luong.FieldName = "So_Luong";
            this.colSo_Luong.Name = "colSo_Luong";
            this.colSo_Luong.Visible = true;
            this.colSo_Luong.VisibleIndex = 4;
            this.colSo_Luong.Width = 72;
            // 
            // colThanh_Tien_GB
            // 
            this.colThanh_Tien_GB.FieldName = "Thanh_Tien_GB";
            this.colThanh_Tien_GB.Name = "colThanh_Tien_GB";
            this.colThanh_Tien_GB.Visible = true;
            this.colThanh_Tien_GB.VisibleIndex = 5;
            this.colThanh_Tien_GB.Width = 72;
            // 
            // colTien_VAT
            // 
            this.colTien_VAT.FieldName = "Tien_VAT";
            this.colTien_VAT.Name = "colTien_VAT";
            this.colTien_VAT.Visible = true;
            this.colTien_VAT.VisibleIndex = 6;
            this.colTien_VAT.Width = 72;
            // 
            // colTien_Phucvu
            // 
            this.colTien_Phucvu.FieldName = "Tien_Phucvu";
            this.colTien_Phucvu.Name = "colTien_Phucvu";
            this.colTien_Phucvu.Visible = true;
            this.colTien_Phucvu.VisibleIndex = 7;
            this.colTien_Phucvu.Width = 72;
            // 
            // colTien_Giam_Gia
            // 
            this.colTien_Giam_Gia.FieldName = "Tien_Giam_Gia";
            this.colTien_Giam_Gia.Name = "colTien_Giam_Gia";
            this.colTien_Giam_Gia.Visible = true;
            this.colTien_Giam_Gia.VisibleIndex = 8;
            this.colTien_Giam_Gia.Width = 84;
            // 
            // colTien_VAT_Giam_Gia
            // 
            this.colTien_VAT_Giam_Gia.FieldName = "Tien_VAT_Giam_Gia";
            this.colTien_VAT_Giam_Gia.Name = "colTien_VAT_Giam_Gia";
            this.colTien_VAT_Giam_Gia.Visible = true;
            this.colTien_VAT_Giam_Gia.VisibleIndex = 9;
            this.colTien_VAT_Giam_Gia.Width = 78;
            // 
            // colTongtien
            // 
            this.colTongtien.FieldName = "Tongtien";
            this.colTongtien.Name = "colTongtien";
            this.colTongtien.Visible = true;
            this.colTongtien.VisibleIndex = 10;
            this.colTongtien.Width = 56;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(658, 270);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 33);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // baocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridControl1);
            this.Name = "baocaodoanhthu";
            this.Size = new System.Drawing.Size(812, 510);
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private EWONDATASETTableAdapters.CTHOADONTableAdapter cTHOADONTableAdapter;
        private EWONDATASETTableAdapters.CTHOADONTableAdapter cTHOADONTableAdapter1;
        private EWONDATASETTableAdapters.baocaobanhangTableAdapter baocaobanhangTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_HD;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Luong;
        private DevExpress.XtraGrid.Columns.GridColumn colThanh_Tien_GB;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_VAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_Phucvu;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_Giam_Gia;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_VAT_Giam_Gia;
        private DevExpress.XtraGrid.Columns.GridColumn colTongtien;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}
