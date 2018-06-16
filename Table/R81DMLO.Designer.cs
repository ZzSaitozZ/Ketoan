namespace Ketoan.Table
{
    partial class R81DMLO
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
            this.r81DMLOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r81DMLOTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R81DMLOTableAdapter();
            this.colMa_Lo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Hd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMLOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r81DMLOBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1214, 638);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Lo,
            this.colNgay_Nhap,
            this.colMa_Dt,
            this.colMa_Hd,
            this.colCreate_Log,
            this.colLastModify_Log,
            this.colMa_Data,
            this.colGhi_Chu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r81DMLOBindingSource
            // 
            this.r81DMLOBindingSource.DataMember = "R81DMLO";
            this.r81DMLOBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r81DMLOTableAdapter
            // 
            this.r81DMLOTableAdapter.ClearBeforeFill = true;
            // 
            // colMa_Lo
            // 
            this.colMa_Lo.FieldName = "Ma_Lo";
            this.colMa_Lo.Name = "colMa_Lo";
            this.colMa_Lo.Visible = true;
            this.colMa_Lo.VisibleIndex = 0;
            // 
            // colNgay_Nhap
            // 
            this.colNgay_Nhap.FieldName = "Ngay_Nhap";
            this.colNgay_Nhap.Name = "colNgay_Nhap";
            this.colNgay_Nhap.Visible = true;
            this.colNgay_Nhap.VisibleIndex = 1;
            // 
            // colMa_Dt
            // 
            this.colMa_Dt.FieldName = "Ma_Dt";
            this.colMa_Dt.Name = "colMa_Dt";
            this.colMa_Dt.Visible = true;
            this.colMa_Dt.VisibleIndex = 2;
            // 
            // colMa_Hd
            // 
            this.colMa_Hd.FieldName = "Ma_Hd";
            this.colMa_Hd.Name = "colMa_Hd";
            this.colMa_Hd.Visible = true;
            this.colMa_Hd.VisibleIndex = 3;
            // 
            // colCreate_Log
            // 
            this.colCreate_Log.FieldName = "Create_Log";
            this.colCreate_Log.Name = "colCreate_Log";
            this.colCreate_Log.Visible = true;
            this.colCreate_Log.VisibleIndex = 4;
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            this.colLastModify_Log.Visible = true;
            this.colLastModify_Log.VisibleIndex = 5;
            // 
            // colMa_Data
            // 
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 6;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 7;
            // 
            // R81DMLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R81DMLO";
            this.Size = new System.Drawing.Size(1214, 638);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMLOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r81DMLOBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Lo;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Nhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hd;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private R50NAMKIMDataSetTableAdapters.R81DMLOTableAdapter r81DMLOTableAdapter;
    }
}
