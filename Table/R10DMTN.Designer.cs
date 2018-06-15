namespace Ketoan.Table
{
    partial class R10DMTN
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
            this.r10DMTNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r10DMTNTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R10DMTNTableAdapter();
            this.colMa_Tn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Tn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Tn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCong_Thuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Display1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Display2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Display3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDvt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Input = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTk_Co = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Km = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r10DMTNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r10DMTNBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(923, 501);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Tn,
            this.colTen_Tn,
            this.colLoai_Tn,
            this.colCong_Thuc,
            this.colGhi_Chu,
            this.colStt,
            this.colDisplay,
            this.colIs_Display1,
            this.colIs_Display2,
            this.colIs_Display3,
            this.colDvt,
            this.colIs_Input,
            this.colIs_Active,
            this.colBold,
            this.colColor,
            this.colTk_No,
            this.colTk_Co,
            this.colMa_Km});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r10DMTNBindingSource
            // 
            this.r10DMTNBindingSource.DataMember = "R10DMTN";
            this.r10DMTNBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r10DMTNTableAdapter
            // 
            this.r10DMTNTableAdapter.ClearBeforeFill = true;
            // 
            // colMa_Tn
            // 
            this.colMa_Tn.FieldName = "Ma_Tn";
            this.colMa_Tn.Name = "colMa_Tn";
            this.colMa_Tn.Visible = true;
            this.colMa_Tn.VisibleIndex = 0;
            // 
            // colTen_Tn
            // 
            this.colTen_Tn.FieldName = "Ten_Tn";
            this.colTen_Tn.Name = "colTen_Tn";
            this.colTen_Tn.Visible = true;
            this.colTen_Tn.VisibleIndex = 1;
            // 
            // colLoai_Tn
            // 
            this.colLoai_Tn.FieldName = "Loai_Tn";
            this.colLoai_Tn.Name = "colLoai_Tn";
            this.colLoai_Tn.Visible = true;
            this.colLoai_Tn.VisibleIndex = 2;
            // 
            // colCong_Thuc
            // 
            this.colCong_Thuc.FieldName = "Cong_Thuc";
            this.colCong_Thuc.Name = "colCong_Thuc";
            this.colCong_Thuc.Visible = true;
            this.colCong_Thuc.VisibleIndex = 3;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 4;
            // 
            // colStt
            // 
            this.colStt.FieldName = "Stt";
            this.colStt.Name = "colStt";
            this.colStt.Visible = true;
            this.colStt.VisibleIndex = 5;
            // 
            // colDisplay
            // 
            this.colDisplay.FieldName = "Display";
            this.colDisplay.Name = "colDisplay";
            this.colDisplay.Visible = true;
            this.colDisplay.VisibleIndex = 6;
            // 
            // colIs_Display1
            // 
            this.colIs_Display1.FieldName = "Is_Display1";
            this.colIs_Display1.Name = "colIs_Display1";
            this.colIs_Display1.Visible = true;
            this.colIs_Display1.VisibleIndex = 7;
            // 
            // colIs_Display2
            // 
            this.colIs_Display2.FieldName = "Is_Display2";
            this.colIs_Display2.Name = "colIs_Display2";
            this.colIs_Display2.Visible = true;
            this.colIs_Display2.VisibleIndex = 8;
            // 
            // colIs_Display3
            // 
            this.colIs_Display3.FieldName = "Is_Display3";
            this.colIs_Display3.Name = "colIs_Display3";
            this.colIs_Display3.Visible = true;
            this.colIs_Display3.VisibleIndex = 9;
            // 
            // colDvt
            // 
            this.colDvt.FieldName = "Dvt";
            this.colDvt.Name = "colDvt";
            this.colDvt.Visible = true;
            this.colDvt.VisibleIndex = 10;
            // 
            // colIs_Input
            // 
            this.colIs_Input.FieldName = "Is_Input";
            this.colIs_Input.Name = "colIs_Input";
            this.colIs_Input.Visible = true;
            this.colIs_Input.VisibleIndex = 11;
            // 
            // colIs_Active
            // 
            this.colIs_Active.FieldName = "Is_Active";
            this.colIs_Active.Name = "colIs_Active";
            this.colIs_Active.Visible = true;
            this.colIs_Active.VisibleIndex = 12;
            // 
            // colBold
            // 
            this.colBold.FieldName = "Bold";
            this.colBold.Name = "colBold";
            this.colBold.Visible = true;
            this.colBold.VisibleIndex = 13;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 14;
            // 
            // colTk_No
            // 
            this.colTk_No.FieldName = "Tk_No";
            this.colTk_No.Name = "colTk_No";
            this.colTk_No.Visible = true;
            this.colTk_No.VisibleIndex = 15;
            // 
            // colTk_Co
            // 
            this.colTk_Co.FieldName = "Tk_Co";
            this.colTk_Co.Name = "colTk_Co";
            this.colTk_Co.Visible = true;
            this.colTk_Co.VisibleIndex = 16;
            // 
            // colMa_Km
            // 
            this.colMa_Km.FieldName = "Ma_Km";
            this.colMa_Km.Name = "colMa_Km";
            this.colMa_Km.Visible = true;
            this.colMa_Km.VisibleIndex = 17;
            // 
            // R10DMTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R10DMTN";
            this.Size = new System.Drawing.Size(923, 501);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r10DMTNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r10DMTNBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Tn;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Tn;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Tn;
        private DevExpress.XtraGrid.Columns.GridColumn colCong_Thuc;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraGrid.Columns.GridColumn colStt;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplay;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Display1;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Display2;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Display3;
        private DevExpress.XtraGrid.Columns.GridColumn colDvt;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Input;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Active;
        private DevExpress.XtraGrid.Columns.GridColumn colBold;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_No;
        private DevExpress.XtraGrid.Columns.GridColumn colTk_Co;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Km;
        private R50NAMKIMDataSetTableAdapters.R10DMTNTableAdapter r10DMTNTableAdapter;
    }
}
