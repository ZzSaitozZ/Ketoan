namespace Ketoan.Table
{
    partial class R81DMNHHD
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
            this.r81DMNHHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r81DMNHHDTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R81DMNHHDTableAdapter();
            this.colMa_Nh_Hd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nh_Hd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Hd_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNh_Cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdent00 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMNHHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r81DMNHHDBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(903, 491);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nh_Hd,
            this.colTen_Nh_Hd,
            this.colMa_Nh_Hd_Parent,
            this.colNh_Cuoi,
            this.colNgay_Begin,
            this.colNgay_End,
            this.colMa_Data,
            this.colCreate_Log,
            this.colLastModify_Log,
            this.colIdent00});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r81DMNHHDBindingSource
            // 
            this.r81DMNHHDBindingSource.DataMember = "R81DMNHHD";
            this.r81DMNHHDBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r81DMNHHDTableAdapter
            // 
            this.r81DMNHHDTableAdapter.ClearBeforeFill = true;
            // 
            // colMa_Nh_Hd
            // 
            this.colMa_Nh_Hd.FieldName = "Ma_Nh_Hd";
            this.colMa_Nh_Hd.Name = "colMa_Nh_Hd";
            this.colMa_Nh_Hd.Visible = true;
            this.colMa_Nh_Hd.VisibleIndex = 0;
            // 
            // colTen_Nh_Hd
            // 
            this.colTen_Nh_Hd.FieldName = "Ten_Nh_Hd";
            this.colTen_Nh_Hd.Name = "colTen_Nh_Hd";
            this.colTen_Nh_Hd.Visible = true;
            this.colTen_Nh_Hd.VisibleIndex = 1;
            // 
            // colMa_Nh_Hd_Parent
            // 
            this.colMa_Nh_Hd_Parent.FieldName = "Ma_Nh_Hd_Parent";
            this.colMa_Nh_Hd_Parent.Name = "colMa_Nh_Hd_Parent";
            this.colMa_Nh_Hd_Parent.Visible = true;
            this.colMa_Nh_Hd_Parent.VisibleIndex = 2;
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
            // colCreate_Log
            // 
            this.colCreate_Log.FieldName = "Create_Log";
            this.colCreate_Log.Name = "colCreate_Log";
            this.colCreate_Log.Visible = true;
            this.colCreate_Log.VisibleIndex = 7;
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            this.colLastModify_Log.Visible = true;
            this.colLastModify_Log.VisibleIndex = 8;
            // 
            // colIdent00
            // 
            this.colIdent00.FieldName = "Ident00";
            this.colIdent00.Name = "colIdent00";
            this.colIdent00.Visible = true;
            this.colIdent00.VisibleIndex = 9;
            // 
            // R81DMNHHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R81DMNHHD";
            this.Size = new System.Drawing.Size(903, 491);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMNHHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r81DMNHHDBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Hd;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nh_Hd;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Hd_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colNh_Cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Begin;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_End;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colIdent00;
        private R50NAMKIMDataSetTableAdapters.R81DMNHHDTableAdapter r81DMNHHDTableAdapter;
    }
}
