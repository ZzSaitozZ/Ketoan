namespace Ketoan.Table
{
    partial class R00OBJECT
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
            this.r00OBJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r00OBJECTTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R00OBJECTTableAdapter();
            this.colObject_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObject_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObject_ID_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObject_Cmd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObject_Para = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStt_Sx = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00OBJECTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r00OBJECTBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(956, 527);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colObject_ID,
            this.colObject_Name,
            this.colObject_ID_Parent,
            this.colObject_Cmd,
            this.colObject_Para,
            this.colStt_Sx});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r00OBJECTBindingSource
            // 
            this.r00OBJECTBindingSource.DataMember = "R00OBJECT";
            this.r00OBJECTBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r00OBJECTTableAdapter
            // 
            this.r00OBJECTTableAdapter.ClearBeforeFill = true;
            // 
            // colObject_ID
            // 
            this.colObject_ID.FieldName = "Object_ID";
            this.colObject_ID.Name = "colObject_ID";
            this.colObject_ID.Visible = true;
            this.colObject_ID.VisibleIndex = 0;
            // 
            // colObject_Name
            // 
            this.colObject_Name.FieldName = "Object_Name";
            this.colObject_Name.Name = "colObject_Name";
            this.colObject_Name.Visible = true;
            this.colObject_Name.VisibleIndex = 1;
            // 
            // colObject_ID_Parent
            // 
            this.colObject_ID_Parent.FieldName = "Object_ID_Parent";
            this.colObject_ID_Parent.Name = "colObject_ID_Parent";
            this.colObject_ID_Parent.Visible = true;
            this.colObject_ID_Parent.VisibleIndex = 2;
            // 
            // colObject_Cmd
            // 
            this.colObject_Cmd.FieldName = "Object_Cmd";
            this.colObject_Cmd.Name = "colObject_Cmd";
            this.colObject_Cmd.Visible = true;
            this.colObject_Cmd.VisibleIndex = 3;
            // 
            // colObject_Para
            // 
            this.colObject_Para.FieldName = "Object_Para";
            this.colObject_Para.Name = "colObject_Para";
            this.colObject_Para.Visible = true;
            this.colObject_Para.VisibleIndex = 4;
            // 
            // colStt_Sx
            // 
            this.colStt_Sx.FieldName = "Stt_Sx";
            this.colStt_Sx.Name = "colStt_Sx";
            this.colStt_Sx.Visible = true;
            this.colStt_Sx.VisibleIndex = 5;
            // 
            // R00OBJECT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R00OBJECT";
            this.Size = new System.Drawing.Size(956, 527);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00OBJECTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r00OBJECTBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colObject_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colObject_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colObject_ID_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colObject_Cmd;
        private DevExpress.XtraGrid.Columns.GridColumn colObject_Para;
        private DevExpress.XtraGrid.Columns.GridColumn colStt_Sx;
        private R50NAMKIMDataSetTableAdapters.R00OBJECTTableAdapter r00OBJECTTableAdapter;
    }
}
