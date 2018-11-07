namespace Ketoan.Controls.BanHangPhaiThu.BaoCao
{
    partial class MenuBaoCao
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colmamenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ewondataset1 = new Ketoan.EWONDATASET();
            this.e004MBHPTTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.E004MBHPTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colid,
            this.colmamenu});
            this.treeList1.DataMember = "E004MBHPT";
            this.treeList1.DataSource = this.ewondataset1;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "tenmenu";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.ParentFieldName = "menucha";
            this.treeList1.Size = new System.Drawing.Size(517, 388);
            this.treeList1.TabIndex = 0;
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colmamenu
            // 
            this.colmamenu.Caption = "Loại báo cáo";
            this.colmamenu.FieldName = "tenmenu";
            this.colmamenu.Name = "colmamenu";
            this.colmamenu.Visible = true;
            this.colmamenu.VisibleIndex = 0;
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e004MBHPTTableAdapter1
            // 
            this.e004MBHPTTableAdapter1.ClearBeforeFill = true;
            // 
            // MenuBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "MenuBaoCao";
            this.Size = new System.Drawing.Size(517, 388);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colmamenu;
        private EWONDATASET ewondataset1;
        private EWONDATASETTableAdapters.E004MBHPTTableAdapter e004MBHPTTableAdapter1;
    }
}
