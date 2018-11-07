namespace Ketoan.Table
{
    partial class EDMPLHD
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
            this.e00DMPLHDTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.E00DMPLHDTableAdapter();
            this.colIdent00 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_PL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_PL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Giai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Hd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_PL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_PL_Nt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLai_Suat_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLai_Suat_QH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKy_Han_Tt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_Goc_TT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTien_Goc_TT_Nt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMPLHD";
            this.gridControl1.DataSource = this.ewondataset1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(632, 398);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdent00,
            this.colNgay_PL,
            this.colSo_PL,
            this.colDien_Giai,
            this.colMa_Hd,
            this.colTien_PL,
            this.colTien_PL_Nt,
            this.colLai_Suat_TH,
            this.colLai_Suat_QH,
            this.colKy_Han_Tt,
            this.colTien_Goc_TT,
            this.colTien_Goc_TT_Nt,
            this.colCreate_Log,
            this.colLastModify_Log});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMPLHDTableAdapter1
            // 
            this.e00DMPLHDTableAdapter1.ClearBeforeFill = true;
            // 
            // colIdent00
            // 
            this.colIdent00.FieldName = "Ident00";
            this.colIdent00.Name = "colIdent00";
            this.colIdent00.Visible = true;
            this.colIdent00.VisibleIndex = 0;
            // 
            // colNgay_PL
            // 
            this.colNgay_PL.FieldName = "Ngay_PL";
            this.colNgay_PL.Name = "colNgay_PL";
            this.colNgay_PL.Visible = true;
            this.colNgay_PL.VisibleIndex = 1;
            // 
            // colSo_PL
            // 
            this.colSo_PL.FieldName = "So_PL";
            this.colSo_PL.Name = "colSo_PL";
            this.colSo_PL.Visible = true;
            this.colSo_PL.VisibleIndex = 2;
            // 
            // colDien_Giai
            // 
            this.colDien_Giai.FieldName = "Dien_Giai";
            this.colDien_Giai.Name = "colDien_Giai";
            this.colDien_Giai.Visible = true;
            this.colDien_Giai.VisibleIndex = 3;
            // 
            // colMa_Hd
            // 
            this.colMa_Hd.FieldName = "Ma_Hd";
            this.colMa_Hd.Name = "colMa_Hd";
            this.colMa_Hd.Visible = true;
            this.colMa_Hd.VisibleIndex = 4;
            // 
            // colTien_PL
            // 
            this.colTien_PL.FieldName = "Tien_PL";
            this.colTien_PL.Name = "colTien_PL";
            this.colTien_PL.Visible = true;
            this.colTien_PL.VisibleIndex = 5;
            // 
            // colTien_PL_Nt
            // 
            this.colTien_PL_Nt.FieldName = "Tien_PL_Nt";
            this.colTien_PL_Nt.Name = "colTien_PL_Nt";
            this.colTien_PL_Nt.Visible = true;
            this.colTien_PL_Nt.VisibleIndex = 6;
            // 
            // colLai_Suat_TH
            // 
            this.colLai_Suat_TH.FieldName = "Lai_Suat_TH";
            this.colLai_Suat_TH.Name = "colLai_Suat_TH";
            this.colLai_Suat_TH.Visible = true;
            this.colLai_Suat_TH.VisibleIndex = 7;
            // 
            // colLai_Suat_QH
            // 
            this.colLai_Suat_QH.FieldName = "Lai_Suat_QH";
            this.colLai_Suat_QH.Name = "colLai_Suat_QH";
            this.colLai_Suat_QH.Visible = true;
            this.colLai_Suat_QH.VisibleIndex = 8;
            // 
            // colKy_Han_Tt
            // 
            this.colKy_Han_Tt.FieldName = "Ky_Han_Tt";
            this.colKy_Han_Tt.Name = "colKy_Han_Tt";
            this.colKy_Han_Tt.Visible = true;
            this.colKy_Han_Tt.VisibleIndex = 9;
            // 
            // colTien_Goc_TT
            // 
            this.colTien_Goc_TT.FieldName = "Tien_Goc_TT";
            this.colTien_Goc_TT.Name = "colTien_Goc_TT";
            this.colTien_Goc_TT.Visible = true;
            this.colTien_Goc_TT.VisibleIndex = 10;
            // 
            // colTien_Goc_TT_Nt
            // 
            this.colTien_Goc_TT_Nt.FieldName = "Tien_Goc_TT_Nt";
            this.colTien_Goc_TT_Nt.Name = "colTien_Goc_TT_Nt";
            this.colTien_Goc_TT_Nt.Visible = true;
            this.colTien_Goc_TT_Nt.VisibleIndex = 11;
            // 
            // colCreate_Log
            // 
            this.colCreate_Log.FieldName = "Create_Log";
            this.colCreate_Log.Name = "colCreate_Log";
            this.colCreate_Log.Visible = true;
            this.colCreate_Log.VisibleIndex = 12;
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            this.colLastModify_Log.Visible = true;
            this.colLastModify_Log.VisibleIndex = 13;
            // 
            // DMPLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "DMPLHD";
            this.Size = new System.Drawing.Size(632, 398);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private EWONDATASET ewondataset1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdent00;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_PL;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_PL;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Giai;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hd;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_PL;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_PL_Nt;
        private DevExpress.XtraGrid.Columns.GridColumn colLai_Suat_TH;
        private DevExpress.XtraGrid.Columns.GridColumn colLai_Suat_QH;
        private DevExpress.XtraGrid.Columns.GridColumn colKy_Han_Tt;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_Goc_TT;
        private DevExpress.XtraGrid.Columns.GridColumn colTien_Goc_TT_Nt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private EWONDATASETTableAdapters.E00DMPLHDTableAdapter e00DMPLHDTableAdapter1;
    }
}
