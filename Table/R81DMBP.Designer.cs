namespace Ketoan.Table
{
    partial class R81DMBP
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
            this.r81DMBPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r50NAMKIMDataSet = new Ketoan.R50NAMKIMDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Bp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Bp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Bp_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNh_Cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdent00 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Bp_DTCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Bp_LaiLo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r81DMBPTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R81DMBPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMBPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r81DMBPBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(958, 538);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // r81DMBPBindingSource
            // 
            this.r81DMBPBindingSource.DataMember = "R81DMBP";
            this.r81DMBPBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Bp,
            this.colTen_Bp,
            this.colMa_Bp_Parent,
            this.colNh_Cuoi,
            this.colNgay_Begin,
            this.colNgay_End,
            this.colMa_Data,
            this.colCreate_Log,
            this.colLastModify_Log,
            this.colIdent00,
            this.colMa_Nh_Bp_DTCP,
            this.colIs_Bp_LaiLo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollStep = 1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colMa_Bp
            // 
            this.colMa_Bp.FieldName = "Ma_Bp";
            this.colMa_Bp.Name = "colMa_Bp";
            this.colMa_Bp.Visible = true;
            this.colMa_Bp.VisibleIndex = 0;
            // 
            // colTen_Bp
            // 
            this.colTen_Bp.FieldName = "Ten_Bp";
            this.colTen_Bp.Name = "colTen_Bp";
            this.colTen_Bp.Visible = true;
            this.colTen_Bp.VisibleIndex = 1;
            // 
            // colMa_Bp_Parent
            // 
            this.colMa_Bp_Parent.FieldName = "Ma_Bp_Parent";
            this.colMa_Bp_Parent.Name = "colMa_Bp_Parent";
            this.colMa_Bp_Parent.Visible = true;
            this.colMa_Bp_Parent.VisibleIndex = 2;
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
            // colMa_Nh_Bp_DTCP
            // 
            this.colMa_Nh_Bp_DTCP.FieldName = "Ma_Nh_Bp_DTCP";
            this.colMa_Nh_Bp_DTCP.Name = "colMa_Nh_Bp_DTCP";
            this.colMa_Nh_Bp_DTCP.Visible = true;
            this.colMa_Nh_Bp_DTCP.VisibleIndex = 10;
            // 
            // colIs_Bp_LaiLo
            // 
            this.colIs_Bp_LaiLo.FieldName = "Is_Bp_LaiLo";
            this.colIs_Bp_LaiLo.Name = "colIs_Bp_LaiLo";
            this.colIs_Bp_LaiLo.Visible = true;
            this.colIs_Bp_LaiLo.VisibleIndex = 11;
            // 
            // r81DMBPTableAdapter
            // 
            this.r81DMBPTableAdapter.ClearBeforeFill = true;
            // 
            // R81DMBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R81DMBP";
            this.Size = new System.Drawing.Size(958, 538);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r81DMBPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r81DMBPBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Bp;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Bp;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Bp_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colNh_Cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Begin;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_End;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colIdent00;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Bp_DTCP;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Bp_LaiLo;
        private R50NAMKIMDataSetTableAdapters.R81DMBPTableAdapter r81DMBPTableAdapter;
    }
}
