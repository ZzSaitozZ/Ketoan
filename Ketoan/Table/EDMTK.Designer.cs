namespace Ketoan.Table
{
    partial class EDMTK
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
            this.e00DMTKTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.E00DMTKTableAdapter();
            this.colTk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Tk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_TkE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Cuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Sp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Tk_Nh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Tk_Nh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Tp_Nh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Tte_Goc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdent00 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_TkC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMTK";
            this.gridControl1.DataSource = this.ewondataset1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(537, 352);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTk,
            this.colTen_Tk,
            this.colTen_TkE,
            this.colTk_Parent,
            this.colTk_Cuoi,
            this.colTk_Sp,
            this.colTk_Dt,
            this.colTk_Km,
            this.colSo_Tk_Nh,
            this.colTen_Tk_Nh,
            this.colTen_Tp_Nh,
            this.colNgay_Begin,
            this.colNgay_End,
            this.colMa_Data,
            this.colCreate_Log,
            this.colLastModify_Log,
            this.colMa_Tte_Goc,
            this.colIdent00,
            this.colTen_TkC});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMTKTableAdapter1
            // 
            this.e00DMTKTableAdapter1.ClearBeforeFill = true;
            // 
            // colTk
            // 
            this.colTk.FieldName = "Tk";
            this.colTk.Name = "colTk";
            this.colTk.Visible = true;
            this.colTk.VisibleIndex = 0;
            // 
            // colTen_Tk
            // 
            this.colTen_Tk.FieldName = "Ten_Tk";
            this.colTen_Tk.Name = "colTen_Tk";
            this.colTen_Tk.Visible = true;
            this.colTen_Tk.VisibleIndex = 1;
            // 
            // colTen_TkE
            // 
            this.colTen_TkE.FieldName = "Ten_TkE";
            this.colTen_TkE.Name = "colTen_TkE";
            this.colTen_TkE.Visible = true;
            this.colTen_TkE.VisibleIndex = 2;
            // 
            // colTk_Parent
            // 
            this.colTk_Parent.FieldName = "Tk_Parent";
            this.colTk_Parent.Name = "colTk_Parent";
            this.colTk_Parent.Visible = true;
            this.colTk_Parent.VisibleIndex = 3;
            // 
            // colTk_Cuoi
            // 
            this.colTk_Cuoi.FieldName = "Tk_Cuoi";
            this.colTk_Cuoi.Name = "colTk_Cuoi";
            this.colTk_Cuoi.Visible = true;
            this.colTk_Cuoi.VisibleIndex = 4;
            // 
            // colTk_Sp
            // 
            this.colTk_Sp.FieldName = "Tk_Sp";
            this.colTk_Sp.Name = "colTk_Sp";
            this.colTk_Sp.Visible = true;
            this.colTk_Sp.VisibleIndex = 5;
            // 
            // colTk_Dt
            // 
            this.colTk_Dt.FieldName = "Tk_Dt";
            this.colTk_Dt.Name = "colTk_Dt";
            this.colTk_Dt.Visible = true;
            this.colTk_Dt.VisibleIndex = 6;
            // 
            // colTk_Km
            // 
            this.colTk_Km.FieldName = "Tk_Km";
            this.colTk_Km.Name = "colTk_Km";
            this.colTk_Km.Visible = true;
            this.colTk_Km.VisibleIndex = 7;
            // 
            // colSo_Tk_Nh
            // 
            this.colSo_Tk_Nh.FieldName = "So_Tk_Nh";
            this.colSo_Tk_Nh.Name = "colSo_Tk_Nh";
            this.colSo_Tk_Nh.Visible = true;
            this.colSo_Tk_Nh.VisibleIndex = 8;
            // 
            // colTen_Tk_Nh
            // 
            this.colTen_Tk_Nh.FieldName = "Ten_Tk_Nh";
            this.colTen_Tk_Nh.Name = "colTen_Tk_Nh";
            this.colTen_Tk_Nh.Visible = true;
            this.colTen_Tk_Nh.VisibleIndex = 9;
            // 
            // colTen_Tp_Nh
            // 
            this.colTen_Tp_Nh.FieldName = "Ten_Tp_Nh";
            this.colTen_Tp_Nh.Name = "colTen_Tp_Nh";
            this.colTen_Tp_Nh.Visible = true;
            this.colTen_Tp_Nh.VisibleIndex = 10;
            // 
            // colNgay_Begin
            // 
            this.colNgay_Begin.FieldName = "Ngay_Begin";
            this.colNgay_Begin.Name = "colNgay_Begin";
            this.colNgay_Begin.Visible = true;
            this.colNgay_Begin.VisibleIndex = 11;
            // 
            // colNgay_End
            // 
            this.colNgay_End.FieldName = "Ngay_End";
            this.colNgay_End.Name = "colNgay_End";
            this.colNgay_End.Visible = true;
            this.colNgay_End.VisibleIndex = 12;
            // 
            // colMa_Data
            // 
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 13;
            // 
            // colCreate_Log
            // 
            this.colCreate_Log.FieldName = "Create_Log";
            this.colCreate_Log.Name = "colCreate_Log";
            this.colCreate_Log.Visible = true;
            this.colCreate_Log.VisibleIndex = 14;
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            this.colLastModify_Log.Visible = true;
            this.colLastModify_Log.VisibleIndex = 15;
            // 
            // colMa_Tte_Goc
            // 
            this.colMa_Tte_Goc.FieldName = "Ma_Tte_Goc";
            this.colMa_Tte_Goc.Name = "colMa_Tte_Goc";
            this.colMa_Tte_Goc.Visible = true;
            this.colMa_Tte_Goc.VisibleIndex = 16;
            // 
            // colIdent00
            // 
            this.colIdent00.FieldName = "Ident00";
            this.colIdent00.Name = "colIdent00";
            this.colIdent00.Visible = true;
            this.colIdent00.VisibleIndex = 17;
            // 
            // colTen_TkC
            // 
            this.colTen_TkC.FieldName = "Ten_TkC";
            this.colTen_TkC.Name = "colTen_TkC";
            this.colTen_TkC.Visible = true;
            this.colTen_TkC.VisibleIndex = 18;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(537, 352);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private EWONDATASET ewondataset1;
        private DevExpress.XtraGrid.Columns.GridColumn colTk;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Tk;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_TkE;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Cuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Sp;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Km;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Tk_Nh;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Tk_Nh;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Tp_Nh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Begin;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_End;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Tte_Goc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdent00;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_TkC;
        private EWONDATASETTableAdapters.E00DMTKTableAdapter e00DMTKTableAdapter1;
    }
}
