namespace Ketoan.Controls.Hangtonkho.Baocao
{
    partial class Baocao
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
            this.mamenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.menubaocao = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ewondataset1 = new Ketoan.EWONDATASET();
      //      this.e004MBCKTableAdapter1 = new Ketoan.EWONDATASETTableAdapters.E004MBCKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.mamenu,
            this.menubaocao});
            this.treeList1.DataMember = "E004MBCK";
            this.treeList1.DataSource = this.ewondataset1;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "mamenu";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.ParentFieldName = "menucha";
            this.treeList1.Size = new System.Drawing.Size(617, 399);
            this.treeList1.TabIndex = 0;
           // this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // mamenu
            // 
            this.mamenu.Caption = "treeListColumn1";
            this.mamenu.FieldName = "mamenu";
            this.mamenu.Name = "mamenu";
            // 
            // menubaocao
            // 
            this.menubaocao.Caption = "Báo cáo hàng tồn kho";
            this.menubaocao.FieldName = "tenmenu";
            this.menubaocao.Name = "menubaocao";
            this.menubaocao.Visible = true;
            this.menubaocao.VisibleIndex = 0;
            // 
            // ewondataset1
            // 
            this.ewondataset1.DataSetName = "EWONDATASET";
            this.ewondataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e004MBCKTableAdapter1
            // 
      //      this.e004MBCKTableAdapter1.ClearBeforeFill = true;
            // 
            // Baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "Baocao";
            this.Size = new System.Drawing.Size(617, 399);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewondataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private EWONDATASET ewondataset1;
     //   private EWONDATASETTableAdapters.E004MBCKTableAdapter e004MBCKTableAdapter1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn mamenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn menubaocao;
    }
}
