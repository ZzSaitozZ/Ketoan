namespace Ketoan.Table
{
    partial class EDMYT
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
            this.e00DMYTTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.E00DMYTTableAdapter();
            this.colMa_Yt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Yt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_List = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Du_List = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNot_Tk_Du_List = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Cp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Nvl = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMYT";
            this.gridControl1.DataSource = this.ewondataset1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(618, 402);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Yt,
            this.colTen_Yt,
            this.colTk_List,
            this.colTk_Du_List,
            this.colNot_Tk_Du_List,
            this.colMa_Km,
            this.colTk_Cp,
            this.colIs_Nvl});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMYTTableAdapter1
            // 
            this.e00DMYTTableAdapter1.ClearBeforeFill = true;
            // 
            // colMa_Yt
            // 
            this.colMa_Yt.FieldName = "Ma_Yt";
            this.colMa_Yt.Name = "colMa_Yt";
            this.colMa_Yt.Visible = true;
            this.colMa_Yt.VisibleIndex = 0;
            // 
            // colTen_Yt
            // 
            this.colTen_Yt.FieldName = "Ten_Yt";
            this.colTen_Yt.Name = "colTen_Yt";
            this.colTen_Yt.Visible = true;
            this.colTen_Yt.VisibleIndex = 1;
            // 
            // colTk_List
            // 
            this.colTk_List.FieldName = "Tk_List";
            this.colTk_List.Name = "colTk_List";
            this.colTk_List.Visible = true;
            this.colTk_List.VisibleIndex = 2;
            // 
            // colTk_Du_List
            // 
            this.colTk_Du_List.FieldName = "Tk_Du_List";
            this.colTk_Du_List.Name = "colTk_Du_List";
            this.colTk_Du_List.Visible = true;
            this.colTk_Du_List.VisibleIndex = 3;
            // 
            // colNot_Tk_Du_List
            // 
            this.colNot_Tk_Du_List.FieldName = "Not_Tk_Du_List";
            this.colNot_Tk_Du_List.Name = "colNot_Tk_Du_List";
            this.colNot_Tk_Du_List.Visible = true;
            this.colNot_Tk_Du_List.VisibleIndex = 4;
            // 
            // colMa_Km
            // 
            this.colMa_Km.FieldName = "Ma_Km";
            this.colMa_Km.Name = "colMa_Km";
            this.colMa_Km.Visible = true;
            this.colMa_Km.VisibleIndex = 5;
            // 
            // colTk_Cp
            // 
            this.colTk_Cp.FieldName = "Tk_Cp";
            this.colTk_Cp.Name = "colTk_Cp";
            this.colTk_Cp.Visible = true;
            this.colTk_Cp.VisibleIndex = 6;
            // 
            // colIs_Nvl
            // 
            this.colIs_Nvl.FieldName = "Is_Nvl";
            this.colIs_Nvl.Name = "colIs_Nvl";
            this.colIs_Nvl.Visible = true;
            this.colIs_Nvl.VisibleIndex = 7;
            // 
            // EDMYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "EDMYT";
            this.Size = new System.Drawing.Size(618, 402);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private EWONDATASET ewondataset1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Yt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Yt;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_List;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Du_List;
        private DevExpress.XtraGrid.Columns.GridColumn colNot_Tk_Du_List;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Km;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Cp;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Nvl;
        private EWONDATASETTableAdapters.E00DMYTTableAdapter e00DMYTTableAdapter1;
    }
}
