namespace Ketoan.Table
{
    partial class R81DMNHDT
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
            this.r81DMNHDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r81DMNHDTTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R81DMNHDTTableAdapter();
            this.colMa_Nh_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nh_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Dt_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNh_Cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Nh_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMNHDTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r81DMNHDTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(875, 492);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nh_Dt,
            this.colTen_Nh_Dt,
            this.colMa_Nh_Dt_Parent,
            this.colNh_Cuoi,
            this.colNgay_Begin,
            this.colNgay_End,
            this.colMa_Data,
            this.colLoai_Nh_Dt,
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
            // r81DMNHDTBindingSource
            // 
            this.r81DMNHDTBindingSource.DataMember = "R81DMNHDT";
            this.r81DMNHDTBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r81DMNHDTTableAdapter
            // 
            this.r81DMNHDTTableAdapter.ClearBeforeFill = true;
            // 
            // colMa_Nh_Dt
            // 
            this.colMa_Nh_Dt.FieldName = "Ma_Nh_Dt";
            this.colMa_Nh_Dt.Name = "colMa_Nh_Dt";
            this.colMa_Nh_Dt.Visible = true;
            this.colMa_Nh_Dt.VisibleIndex = 0;
            // 
            // colTen_Nh_Dt
            // 
            this.colTen_Nh_Dt.FieldName = "Ten_Nh_Dt";
            this.colTen_Nh_Dt.Name = "colTen_Nh_Dt";
            this.colTen_Nh_Dt.Visible = true;
            this.colTen_Nh_Dt.VisibleIndex = 1;
            // 
            // colMa_Nh_Dt_Parent
            // 
            this.colMa_Nh_Dt_Parent.FieldName = "Ma_Nh_Dt_Parent";
            this.colMa_Nh_Dt_Parent.Name = "colMa_Nh_Dt_Parent";
            this.colMa_Nh_Dt_Parent.Visible = true;
            this.colMa_Nh_Dt_Parent.VisibleIndex = 2;
            // 
            // colNh_Cuoi
            // 
            this.colNh_Cuoi.FieldName = "Nh_Cuoi";
            this.colNh_Cuoi.Name = "colNh_Cuoi";
            this.colNh_Cuoi.Visible = true;
            this.colNh_Cuoi.VisibleIndex = 3;
            // 
            // colNgay_Begin
            // 
            this.colNgay_Begin.FieldName = "Ngay_Begin";
            this.colNgay_Begin.Name = "colNgay_Begin";
            this.colNgay_Begin.Visible = true;
            this.colNgay_Begin.VisibleIndex = 4;
            // 
            // colNgay_End
            // 
            this.colNgay_End.FieldName = "Ngay_End";
            this.colNgay_End.Name = "colNgay_End";
            this.colNgay_End.Visible = true;
            this.colNgay_End.VisibleIndex = 5;
            // 
            // colMa_Data
            // 
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 6;
            // 
            // colLoai_Nh_Dt
            // 
            this.colLoai_Nh_Dt.FieldName = "Loai_Nh_Dt";
            this.colLoai_Nh_Dt.Name = "colLoai_Nh_Dt";
            this.colLoai_Nh_Dt.Visible = true;
            this.colLoai_Nh_Dt.VisibleIndex = 7;
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
            // R81DMNHDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R81DMNHDT";
            this.Size = new System.Drawing.Size(875, 492);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMNHDTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r81DMNHDTBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nh_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Dt_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colNh_Cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Begin;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_End;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Nh_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private R50NAMKIMDataSetTableAdapters.R81DMNHDTTableAdapter r81DMNHDTTableAdapter;
    }
}
