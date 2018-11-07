namespace Ketoan.Table
{
    partial class EDMTHUE
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
            this.e00DMTHUETableAdapter1 = new Ketoan.EWONDATASETTableAdapters.E00DMTHUETableAdapter();
            this.colMa_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThue_Suat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhan_Loai_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdent00 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMTHUE";
            this.gridControl1.DataSource = this.ewondataset1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(707, 414);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Thue,
            this.colTen_Thue,
            this.colThue_Suat,
            this.colLoai_Thue,
            this.colTk,
            this.colPhan_Loai_Thue,
            this.colCreate_Log,
            this.colLastModify_Log,
            this.colNgay_Begin,
            this.colNgay_End,
            this.colMa_Data,
            this.colIdent00});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMTHUETableAdapter1
            // 
            this.e00DMTHUETableAdapter1.ClearBeforeFill = true;
            // 
            // colMa_Thue
            // 
            this.colMa_Thue.FieldName = "Ma_Thue";
            this.colMa_Thue.Name = "colMa_Thue";
            this.colMa_Thue.Visible = true;
            this.colMa_Thue.VisibleIndex = 0;
            // 
            // colTen_Thue
            // 
            this.colTen_Thue.FieldName = "Ten_Thue";
            this.colTen_Thue.Name = "colTen_Thue";
            this.colTen_Thue.Visible = true;
            this.colTen_Thue.VisibleIndex = 1;
            // 
            // colThue_Suat
            // 
            this.colThue_Suat.FieldName = "Thue_Suat";
            this.colThue_Suat.Name = "colThue_Suat";
            this.colThue_Suat.Visible = true;
            this.colThue_Suat.VisibleIndex = 2;
            // 
            // colLoai_Thue
            // 
            this.colLoai_Thue.FieldName = "Loai_Thue";
            this.colLoai_Thue.Name = "colLoai_Thue";
            this.colLoai_Thue.Visible = true;
            this.colLoai_Thue.VisibleIndex = 3;
            // 
            // colTk
            // 
            this.colTk.FieldName = "Tk";
            this.colTk.Name = "colTk";
            this.colTk.Visible = true;
            this.colTk.VisibleIndex = 4;
            // 
            // colPhan_Loai_Thue
            // 
            this.colPhan_Loai_Thue.FieldName = "Phan_Loai_Thue";
            this.colPhan_Loai_Thue.Name = "colPhan_Loai_Thue";
            this.colPhan_Loai_Thue.Visible = true;
            this.colPhan_Loai_Thue.VisibleIndex = 5;
            // 
            // colCreate_Log
            // 
            this.colCreate_Log.FieldName = "Create_Log";
            this.colCreate_Log.Name = "colCreate_Log";
            this.colCreate_Log.Visible = true;
            this.colCreate_Log.VisibleIndex = 6;
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            this.colLastModify_Log.Visible = true;
            this.colLastModify_Log.VisibleIndex = 7;
            // 
            // colNgay_Begin
            // 
            this.colNgay_Begin.FieldName = "Ngay_Begin";
            this.colNgay_Begin.Name = "colNgay_Begin";
            this.colNgay_Begin.Visible = true;
            this.colNgay_Begin.VisibleIndex = 8;
            // 
            // colNgay_End
            // 
            this.colNgay_End.FieldName = "Ngay_End";
            this.colNgay_End.Name = "colNgay_End";
            this.colNgay_End.Visible = true;
            this.colNgay_End.VisibleIndex = 9;
            // 
            // colMa_Data
            // 
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 10;
            // 
            // colIdent00
            // 
            this.colIdent00.FieldName = "Ident00";
            this.colIdent00.Name = "colIdent00";
            this.colIdent00.Visible = true;
            this.colIdent00.VisibleIndex = 11;
            // 
            // EDMTHUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "EDMTHUE";
            this.Size = new System.Drawing.Size(707, 414);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EWONDATASET ewondataset1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colThue_Suat;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colTk;
        private DevExpress.XtraGrid.Columns.GridColumn colPhan_Loai_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Begin;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_End;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colIdent00;
        private EWONDATASETTableAdapters.E00DMTHUETableAdapter e00DMTHUETableAdapter1;
    }
}
