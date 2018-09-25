namespace Ketoan.Controls.Danhmuc.DMKho
{
    partial class DMKho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e00DMKHOTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMKHOTableAdapter();
            this.tableAdapterManager = new Ketoan.EWONDATASETTableAdapters.TableAdapterManager();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Begin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdent00 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMKHOBindingSource
            // 
            this.e00DMKHOBindingSource.DataMember = "E00DMKHO";
            this.e00DMKHOBindingSource.DataSource = this.eWONDATASET;
            // 
            // e00DMKHOTableAdapter
            // 
            this.e00DMKHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.E001PNXTableAdapter = null;
            this.tableAdapterManager.E003KHOTableAdapter = null;
            this.tableAdapterManager.E00DMBANGGIATableAdapter = null;
            this.tableAdapterManager.E00DMBPTableAdapter = null;
            this.tableAdapterManager.E00DMDTTableAdapter = null;
            this.tableAdapterManager.E00DMHDTableAdapter = null;
            this.tableAdapterManager.E00DMJOBTableAdapter = null;
            this.tableAdapterManager.E00DMKHOTableAdapter = this.e00DMKHOTableAdapter;
            this.tableAdapterManager.E00DMKMTableAdapter = null;
            this.tableAdapterManager.E00DMKVTableAdapter = null;
            this.tableAdapterManager.E00DMLOTableAdapter = null;
            this.tableAdapterManager.E00DMNHANTableAdapter = null;
            this.tableAdapterManager.E00DMNHDTTableAdapter = null;
            this.tableAdapterManager.E00DMNHHDTableAdapter = null;
            this.tableAdapterManager.E00DMNHVTTableAdapter = null;
            this.tableAdapterManager.E00DMNVTableAdapter = null;
            this.tableAdapterManager.E00DMNVUTableAdapter = null;
            this.tableAdapterManager.E00DMPLHDTableAdapter = null;
            this.tableAdapterManager.E00DMTHUETableAdapter = null;
            this.tableAdapterManager.E00DMTKTableAdapter = null;
            this.tableAdapterManager.E00DMTNTableAdapter = null;
            this.tableAdapterManager.E00DMTYPETableAdapter = null;
            this.tableAdapterManager.E00DMVTTableAdapter = null;
            this.tableAdapterManager.E00DMYTTableAdapter = null;
            this.tableAdapterManager.E01CTNMTableAdapter = null;
            this.tableAdapterManager.E01CTNXTableAdapter = null;
            this.tableAdapterManager.E02CTHDTableAdapter = null;
            this.tableAdapterManager.E02CTTPTableAdapter = null;
            this.tableAdapterManager.E02CTXBTableAdapter = null;
            this.tableAdapterManager.E02CTXKNLTableAdapter = null;
            this.tableAdapterManager.E02HOADONTableAdapter = null;
            this.tableAdapterManager.E03DINHMUCTableAdapter = null;
            this.tableAdapterManager.EBARCODETableAdapter = null;
            this.tableAdapterManager.ECTTSTableAdapter = null;
            this.tableAdapterManager.EMEMBERTableAdapter = null;
            this.tableAdapterManager.EMENUTableAdapter = null;
            this.tableAdapterManager.EMODULETableAdapter = null;
            this.tableAdapterManager.EOBJECTTableAdapter = null;
            this.tableAdapterManager.EREPORTTableAdapter = null;
            this.tableAdapterManager.EZONETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ketoan.EWONDATASETTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMKHO";
            this.gridControl1.DataSource = this.eWONDATASET;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(664, 213);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Kho,
            this.colTen_Kho,
            this.colNgay_Begin,
            this.colNgay_End,
            this.colMa_Data,
            this.colCreate_Log,
            this.colLastModify_Log,
            this.colStt,
            this.colIdent00});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMa_Kho
            // 
            this.colMa_Kho.Caption = "Mã kho";
            this.colMa_Kho.FieldName = "Ma_Kho";
            this.colMa_Kho.Name = "colMa_Kho";
            this.colMa_Kho.Visible = true;
            this.colMa_Kho.VisibleIndex = 0;
            // 
            // colTen_Kho
            // 
            this.colTen_Kho.Caption = "Tên kho";
            this.colTen_Kho.FieldName = "Ten_Kho";
            this.colTen_Kho.Name = "colTen_Kho";
            this.colTen_Kho.Visible = true;
            this.colTen_Kho.VisibleIndex = 1;
            // 
            // colNgay_Begin
            // 
            this.colNgay_Begin.FieldName = "Ngay_Begin";
            this.colNgay_Begin.Name = "colNgay_Begin";
            // 
            // colNgay_End
            // 
            this.colNgay_End.FieldName = "Ngay_End";
            this.colNgay_End.Name = "colNgay_End";
            // 
            // colMa_Data
            // 
            this.colMa_Data.Caption = "Mã data";
            this.colMa_Data.FieldName = "Ma_Data";
            this.colMa_Data.Name = "colMa_Data";
            this.colMa_Data.Visible = true;
            this.colMa_Data.VisibleIndex = 2;
            // 
            // colCreate_Log
            // 
            this.colCreate_Log.FieldName = "Create_Log";
            this.colCreate_Log.Name = "colCreate_Log";
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            // 
            // colStt
            // 
            this.colStt.Caption = "STT";
            this.colStt.FieldName = "Stt";
            this.colStt.Name = "colStt";
            this.colStt.Visible = true;
            this.colStt.VisibleIndex = 3;
            // 
            // colIdent00
            // 
            this.colIdent00.FieldName = "Ident00";
            this.colIdent00.Name = "colIdent00";
            // 
            // DMKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 262);
            this.Name = "DMKho";
            this.Text = "DMKho";
            this.Load += new System.EventHandler(this.DMKho_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMKHOBindingSource;
        private EWONDATASETTableAdapters.E00DMKHOTableAdapter e00DMKHOTableAdapter;
        private EWONDATASETTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Begin;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_End;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Data;
        private DevExpress.XtraGrid.Columns.GridColumn colCreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colStt;
        private DevExpress.XtraGrid.Columns.GridColumn colIdent00;
    }
}