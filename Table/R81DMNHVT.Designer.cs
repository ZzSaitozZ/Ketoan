﻿namespace Ketoan.Table
{
    partial class R81DMNHVT
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.r50NAMKIMDataSet = new Ketoan.R50NAMKIMDataSet();
            this.r81DMNHVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r81DMNHVTTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R81DMNHVTTableAdapter();
            this.colMa_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Vt_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNh_Cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Nh_Vt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMNHVTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r81DMNHVTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(845, 484);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nh_Vt,
            this.colTen_Nh_Vt,
            this.colMa_Nh_Vt_Parent,
            this.colNh_Cuoi,
            this.colLoai_Nh_Vt,
            this.colNgay_Begin,
            this.colNgay_End,
            this.colMa_Data,
            this.colCreate_Log,
            this.colLastModify_Log});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r81DMNHVTBindingSource
            // 
            this.r81DMNHVTBindingSource.DataMember = "R81DMNHVT";
            this.r81DMNHVTBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r81DMNHVTTableAdapter
            // 
            this.r81DMNHVTTableAdapter.ClearBeforeFill = true;
            // 
            // colMa_Nh_Vt
            // 
            this.colMa_Nh_Vt.FieldName = "Ma_Nh_Vt";
            this.colMa_Nh_Vt.Name = "colMa_Nh_Vt";
            this.colMa_Nh_Vt.Visible = true;
            this.colMa_Nh_Vt.VisibleIndex = 0;
            // 
            // colTen_Nh_Vt
            // 
            this.colTen_Nh_Vt.FieldName = "Ten_Nh_Vt";
            this.colTen_Nh_Vt.Name = "colTen_Nh_Vt";
            this.colTen_Nh_Vt.Visible = true;
            this.colTen_Nh_Vt.VisibleIndex = 1;
            // 
            // colMa_Nh_Vt_Parent
            // 
            this.colMa_Nh_Vt_Parent.FieldName = "Ma_Nh_Vt_Parent";
            this.colMa_Nh_Vt_Parent.Name = "colMa_Nh_Vt_Parent";
            this.colMa_Nh_Vt_Parent.Visible = true;
            this.colMa_Nh_Vt_Parent.VisibleIndex = 2;
            // 
            // colNh_Cuoi
            // 
            this.colNh_Cuoi.FieldName = "Nh_Cuoi";
            this.colNh_Cuoi.Name = "colNh_Cuoi";
            this.colNh_Cuoi.Visible = true;
            this.colNh_Cuoi.VisibleIndex = 3;
            // 
            // colLoai_Nh_Vt
            // 
            this.colLoai_Nh_Vt.FieldName = "Loai_Nh_Vt";
            this.colLoai_Nh_Vt.Name = "colLoai_Nh_Vt";
            this.colLoai_Nh_Vt.Visible = true;
            this.colLoai_Nh_Vt.VisibleIndex = 4;
            // 
            // colNgay_Begin
            // 
            this.colNgay_Begin.FieldName = "Ngay_Begin";
            this.colNgay_Begin.Name = "colNgay_Begin";
            this.colNgay_Begin.Visible = true;
            this.colNgay_Begin.VisibleIndex = 5;
            // 
            // colNgay_End
            // 
            this.colNgay_End.FieldName = "Ngay_End";
            this.colNgay_End.Name = "colNgay_End";
            this.colNgay_End.Visible = true;
            this.colNgay_End.VisibleIndex = 6;
            // 
            // colMa_Data
            // 
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 7;
            // 
            // colCreate_Log
            // 
            this.colCreate_Log.FieldName = "Create_Log";
            this.colCreate_Log.Name = "colCreate_Log";
            this.colCreate_Log.Visible = true;
            this.colCreate_Log.VisibleIndex = 8;
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            this.colLastModify_Log.Visible = true;
            this.colLastModify_Log.VisibleIndex = 9;
            // 
            // R81DMNHVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R81DMNHVT";
            this.Size = new System.Drawing.Size(845, 484);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMNHVTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r81DMNHVTBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Vt_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colNh_Cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Nh_Vt;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Begin;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_End;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private R50NAMKIMDataSetTableAdapters.R81DMNHVTTableAdapter r81DMNHVTTableAdapter;
    }
}
