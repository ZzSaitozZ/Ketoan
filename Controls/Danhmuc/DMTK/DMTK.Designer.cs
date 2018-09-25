namespace Ketoan.Controls.Danhmuc.DMTK
{
    partial class DMTK
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colTk = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTen_Tk = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTen_TkE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTk_Cuoi = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTk_Parent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTk_Dt = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTk_Sp = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTk_Km = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSo_Tk_Nh = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTen_Tk_Nh = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTen_Tp_Nh = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNgay_Begin = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNgay_End = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMa_Data = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreate_Log = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLastModify_Log = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMa_Tte_Goc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdent00 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTen_TkC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e00DMTKTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMTKTableAdapter();
            this.editNhomVT1 = new Ketoan.DM.NhomVT.EditNhomVT();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMTKBindingSource)).BeginInit();
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
            this.panel2.Controls.Add(this.editNhomVT1);
            this.panel2.Controls.Add(this.treeList1);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTk,
            this.colTen_Tk,
            this.colTen_TkE,
            this.colTk_Cuoi,
            this.colTk_Parent,
            this.colTk_Dt,
            this.colTk_Sp,
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
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataMember = "E00DMTK";
            this.treeList1.DataSource = this.eWONDATASET;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "Tk";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "Tk_Parent";
            this.treeList1.Size = new System.Drawing.Size(664, 213);
            this.treeList1.TabIndex = 0;
            // 
            // colTk
            // 
            this.colTk.Caption = "Tài khoản";
            this.colTk.FieldName = "Tk";
            this.colTk.Name = "colTk";
            this.colTk.Visible = true;
            this.colTk.VisibleIndex = 0;
            // 
            // colTen_Tk
            // 
            this.colTen_Tk.Caption = "Tên tài khoản";
            this.colTen_Tk.FieldName = "Ten_Tk";
            this.colTen_Tk.Name = "colTen_Tk";
            this.colTen_Tk.Visible = true;
            this.colTen_Tk.VisibleIndex = 1;
            // 
            // colTen_TkE
            // 
            this.colTen_TkE.Caption = "Tên tk tiếng anh";
            this.colTen_TkE.FieldName = "Ten_TkE";
            this.colTen_TkE.Name = "colTen_TkE";
            this.colTen_TkE.Visible = true;
            this.colTen_TkE.VisibleIndex = 2;
            // 
            // colTk_Cuoi
            // 
            this.colTk_Cuoi.FieldName = "Tk_Cuoi";
            this.colTk_Cuoi.Name = "colTk_Cuoi";
            // 
            // colTk_Parent
            // 
            this.colTk_Parent.Caption = "Tài khoản cha";
            this.colTk_Parent.FieldName = "Tk_Parent";
            this.colTk_Parent.Name = "colTk_Parent";
            this.colTk_Parent.Visible = true;
            this.colTk_Parent.VisibleIndex = 3;
            // 
            // colTk_Dt
            // 
            this.colTk_Dt.Caption = "Tk đối tượng";
            this.colTk_Dt.FieldName = "Tk_Dt";
            this.colTk_Dt.Name = "colTk_Dt";
            this.colTk_Dt.Visible = true;
            this.colTk_Dt.VisibleIndex = 5;
            // 
            // colTk_Sp
            // 
            this.colTk_Sp.Caption = "Tk sản phẩm";
            this.colTk_Sp.FieldName = "Tk_Sp";
            this.colTk_Sp.Name = "colTk_Sp";
            this.colTk_Sp.Visible = true;
            this.colTk_Sp.VisibleIndex = 4;
            // 
            // colTk_Km
            // 
            this.colTk_Km.Caption = "Tk khoản mục";
            this.colTk_Km.FieldName = "Tk_Km";
            this.colTk_Km.Name = "colTk_Km";
            this.colTk_Km.Visible = true;
            this.colTk_Km.VisibleIndex = 6;
            // 
            // colSo_Tk_Nh
            // 
            this.colSo_Tk_Nh.FieldName = "So_Tk_Nh";
            this.colSo_Tk_Nh.Name = "colSo_Tk_Nh";
            // 
            // colTen_Tk_Nh
            // 
            this.colTen_Tk_Nh.FieldName = "Ten_Tk_Nh";
            this.colTen_Tk_Nh.Name = "colTen_Tk_Nh";
            // 
            // colTen_Tp_Nh
            // 
            this.colTen_Tp_Nh.FieldName = "Ten_Tp_Nh";
            this.colTen_Tp_Nh.Name = "colTen_Tp_Nh";
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
            this.colMa_Data.VisibleIndex = 7;
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
            // colMa_Tte_Goc
            // 
            this.colMa_Tte_Goc.Caption = "Mã tiền tệ gốc";
            this.colMa_Tte_Goc.FieldName = "Ma_Tte_Goc";
            this.colMa_Tte_Goc.Name = "colMa_Tte_Goc";
            this.colMa_Tte_Goc.Visible = true;
            this.colMa_Tte_Goc.VisibleIndex = 8;
            // 
            // colIdent00
            // 
            this.colIdent00.FieldName = "Ident00";
            this.colIdent00.Name = "colIdent00";
            // 
            // colTen_TkC
            // 
            this.colTen_TkC.FieldName = "Ten_TkC";
            this.colTen_TkC.Name = "colTen_TkC";
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMTKBindingSource
            // 
            this.e00DMTKBindingSource.DataMember = "E00DMTK";
            this.e00DMTKBindingSource.DataSource = this.eWONDATASET;
            // 
            // e00DMTKTableAdapter
            // 
            this.e00DMTKTableAdapter.ClearBeforeFill = true;
            // 
            // editNhomVT1
            // 
            this.editNhomVT1.Location = new System.Drawing.Point(464, 160);
            this.editNhomVT1.Name = "editNhomVT1";
            this.editNhomVT1.Size = new System.Drawing.Size(150, 150);
            this.editNhomVT1.TabIndex = 1;
            // 
            // DMTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 262);
            this.Name = "DMTK";
            this.Text = "DMTK";
            this.Load += new System.EventHandler(this.DMTK_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMTKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMTKBindingSource;
        private EWONDATASETTableAdapters.E00DMTKTableAdapter e00DMTKTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTen_Tk;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTen_TkE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTk_Cuoi;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTk_Sp;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTk_Dt;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTk_Km;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSo_Tk_Nh;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTen_Tk_Nh;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTen_Tp_Nh;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNgay_Begin;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNgay_End;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMa_Data;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreate_Log;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLastModify_Log;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMa_Tte_Goc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdent00;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTen_TkC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTk;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTk_Parent;
        private DM.NhomVT.EditNhomVT editNhomVT1;
    }
}