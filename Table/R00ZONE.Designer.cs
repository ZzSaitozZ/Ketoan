namespace Ketoan.Table
{
    partial class R00ZONE
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
            this.r00ZONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r00ZONETableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R00ZONETableAdapter();
            this.colZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZone_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResize_Rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSortable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpand = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00ZONEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r00ZONEBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(829, 474);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZone,
            this.colZone_Parent,
            this.colResize_Rate,
            this.colSortable,
            this.colDescription,
            this.colExpand});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r00ZONEBindingSource
            // 
            this.r00ZONEBindingSource.DataMember = "R00ZONE";
            this.r00ZONEBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r00ZONETableAdapter
            // 
            this.r00ZONETableAdapter.ClearBeforeFill = true;
            // 
            // colZone
            // 
            this.colZone.FieldName = "Zone";
            this.colZone.Name = "colZone";
            this.colZone.Visible = true;
            this.colZone.VisibleIndex = 0;
            // 
            // colZone_Parent
            // 
            this.colZone_Parent.FieldName = "Zone_Parent";
            this.colZone_Parent.Name = "colZone_Parent";
            this.colZone_Parent.Visible = true;
            this.colZone_Parent.VisibleIndex = 1;
            // 
            // colResize_Rate
            // 
            this.colResize_Rate.FieldName = "Resize_Rate";
            this.colResize_Rate.Name = "colResize_Rate";
            this.colResize_Rate.Visible = true;
            this.colResize_Rate.VisibleIndex = 2;
            // 
            // colSortable
            // 
            this.colSortable.FieldName = "Sortable";
            this.colSortable.Name = "colSortable";
            this.colSortable.Visible = true;
            this.colSortable.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colExpand
            // 
            this.colExpand.FieldName = "Expand";
            this.colExpand.Name = "colExpand";
            this.colExpand.Visible = true;
            this.colExpand.VisibleIndex = 5;
            // 
            // R00ZONE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R00ZONE";
            this.Size = new System.Drawing.Size(829, 474);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00ZONEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r00ZONEBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colZone;
        private DevExpress.XtraGrid.Columns.GridColumn colZone_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colResize_Rate;
        private DevExpress.XtraGrid.Columns.GridColumn colSortable;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colExpand;
        private R50NAMKIMDataSetTableAdapters.R00ZONETableAdapter r00ZONETableAdapter;
    }
}
