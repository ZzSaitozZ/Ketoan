namespace Ketoan.Table
{
    partial class R00MODULE
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
            this.colMenu_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu_Parent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu_NameE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShow_On_Main = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObject_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedia_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu_NameO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r50NAMKIMDataSet = new Ketoan.R50NAMKIMDataSet();
            this.r00MODULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r00MODULETableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R00MODULETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00MODULEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r00MODULEBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(873, 486);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenu_ID,
            this.colMenu_Parent,
            this.colMenu_Name,
            this.colMenu_NameE,
            this.colStt,
            this.colShow_On_Main,
            this.colObject_ID,
            this.colMedia_ID,
            this.colMenu_NameO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMenu_ID
            // 
            this.colMenu_ID.FieldName = "Menu_ID";
            this.colMenu_ID.Name = "colMenu_ID";
            this.colMenu_ID.Visible = true;
            this.colMenu_ID.VisibleIndex = 0;
            // 
            // colMenu_Parent
            // 
            this.colMenu_Parent.FieldName = "Menu_Parent";
            this.colMenu_Parent.Name = "colMenu_Parent";
            this.colMenu_Parent.Visible = true;
            this.colMenu_Parent.VisibleIndex = 1;
            // 
            // colMenu_Name
            // 
            this.colMenu_Name.FieldName = "Menu_Name";
            this.colMenu_Name.Name = "colMenu_Name";
            this.colMenu_Name.Visible = true;
            this.colMenu_Name.VisibleIndex = 2;
            // 
            // colMenu_NameE
            // 
            this.colMenu_NameE.FieldName = "Menu_NameE";
            this.colMenu_NameE.Name = "colMenu_NameE";
            this.colMenu_NameE.Visible = true;
            this.colMenu_NameE.VisibleIndex = 3;
            // 
            // colStt
            // 
            this.colStt.FieldName = "Stt";
            this.colStt.Name = "colStt";
            this.colStt.Visible = true;
            this.colStt.VisibleIndex = 4;
            // 
            // colShow_On_Main
            // 
            this.colShow_On_Main.FieldName = "Show_On_Main";
            this.colShow_On_Main.Name = "colShow_On_Main";
            this.colShow_On_Main.Visible = true;
            this.colShow_On_Main.VisibleIndex = 5;
            // 
            // colObject_ID
            // 
            this.colObject_ID.FieldName = "Object_ID";
            this.colObject_ID.Name = "colObject_ID";
            this.colObject_ID.Visible = true;
            this.colObject_ID.VisibleIndex = 6;
            // 
            // colMedia_ID
            // 
            this.colMedia_ID.FieldName = "Media_ID";
            this.colMedia_ID.Name = "colMedia_ID";
            this.colMedia_ID.Visible = true;
            this.colMedia_ID.VisibleIndex = 7;
            // 
            // colMenu_NameO
            // 
            this.colMenu_NameO.FieldName = "Menu_NameO";
            this.colMenu_NameO.Name = "colMenu_NameO";
            this.colMenu_NameO.Visible = true;
            this.colMenu_NameO.VisibleIndex = 8;
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r00MODULEBindingSource
            // 
            this.r00MODULEBindingSource.DataMember = "R00MODULE";
            this.r00MODULEBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r00MODULETableAdapter
            // 
            this.r00MODULETableAdapter.ClearBeforeFill = true;
            // 
            // R00MODULE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R00MODULE";
            this.Size = new System.Drawing.Size(873, 486);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00MODULEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu_Parent;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu_NameE;
        private DevExpress.XtraGrid.Columns.GridColumn colStt;
        private DevExpress.XtraGrid.Columns.GridColumn colShow_On_Main;
        private DevExpress.XtraGrid.Columns.GridColumn colObject_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedia_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu_NameO;
        private System.Windows.Forms.BindingSource r00MODULEBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private R50NAMKIMDataSetTableAdapters.R00MODULETableAdapter r00MODULETableAdapter;
    }
}
