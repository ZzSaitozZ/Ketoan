namespace Ketoan.Table
{
    partial class R00MEMBER
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
            this.r00MEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r00MEMBERTableAdapter = new Ketoan.R50NAMKIMDataSetTableAdapters.R00MEMBERTableAdapter();
            this.colMember_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMember_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMember_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Admin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMember_ID_Allow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckPass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Dt_CbNv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_DvCs_Default = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeb_Login = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModify_Log = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00MEMBERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.r00MEMBERBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(933, 513);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMember_ID,
            this.colMember_Name,
            this.colPassword,
            this.colMember_Type,
            this.colIs_Admin,
            this.colLocked,
            this.colMember_ID_Allow,
            this.colCheckPass,
            this.colMa_Dt_CbNv,
            this.colMa_DvCs_Default,
            this.colWeb_Login,
            this.colcreate_Log,
            this.colLastModify_Log});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // r50NAMKIMDataSet
            // 
            this.r50NAMKIMDataSet.DataSetName = "R50NAMKIMDataSet";
            this.r50NAMKIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // r00MEMBERBindingSource
            // 
            this.r00MEMBERBindingSource.DataMember = "R00MEMBER";
            this.r00MEMBERBindingSource.DataSource = this.r50NAMKIMDataSet;
            // 
            // r00MEMBERTableAdapter
            // 
            this.r00MEMBERTableAdapter.ClearBeforeFill = true;
            // 
            // colMember_ID
            // 
            this.colMember_ID.FieldName = "Member_ID";
            this.colMember_ID.Name = "colMember_ID";
            this.colMember_ID.Visible = true;
            this.colMember_ID.VisibleIndex = 0;
            // 
            // colMember_Name
            // 
            this.colMember_Name.FieldName = "Member_Name";
            this.colMember_Name.Name = "colMember_Name";
            this.colMember_Name.Visible = true;
            this.colMember_Name.VisibleIndex = 1;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            // 
            // colMember_Type
            // 
            this.colMember_Type.FieldName = "Member_Type";
            this.colMember_Type.Name = "colMember_Type";
            this.colMember_Type.Visible = true;
            this.colMember_Type.VisibleIndex = 3;
            // 
            // colIs_Admin
            // 
            this.colIs_Admin.FieldName = "Is_Admin";
            this.colIs_Admin.Name = "colIs_Admin";
            this.colIs_Admin.Visible = true;
            this.colIs_Admin.VisibleIndex = 4;
            // 
            // colLocked
            // 
            this.colLocked.FieldName = "Locked";
            this.colLocked.Name = "colLocked";
            this.colLocked.Visible = true;
            this.colLocked.VisibleIndex = 5;
            // 
            // colMember_ID_Allow
            // 
            this.colMember_ID_Allow.FieldName = "Member_ID_Allow";
            this.colMember_ID_Allow.Name = "colMember_ID_Allow";
            this.colMember_ID_Allow.Visible = true;
            this.colMember_ID_Allow.VisibleIndex = 6;
            // 
            // colCheckPass
            // 
            this.colCheckPass.FieldName = "CheckPass";
            this.colCheckPass.Name = "colCheckPass";
            this.colCheckPass.Visible = true;
            this.colCheckPass.VisibleIndex = 7;
            // 
            // colMa_Dt_CbNv
            // 
            this.colMa_Dt_CbNv.FieldName = "Ma_Dt_CbNv";
            this.colMa_Dt_CbNv.Name = "colMa_Dt_CbNv";
            this.colMa_Dt_CbNv.Visible = true;
            this.colMa_Dt_CbNv.VisibleIndex = 8;
            // 
            // colMa_DvCs_Default
            // 
            this.colMa_DvCs_Default.FieldName = "Ma_DvCs_Default";
            this.colMa_DvCs_Default.Name = "colMa_DvCs_Default";
            this.colMa_DvCs_Default.Visible = true;
            this.colMa_DvCs_Default.VisibleIndex = 9;
            // 
            // colWeb_Login
            // 
            this.colWeb_Login.FieldName = "Web_Login";
            this.colWeb_Login.Name = "colWeb_Login";
            this.colWeb_Login.Visible = true;
            this.colWeb_Login.VisibleIndex = 10;
            // 
            // colcreate_Log
            // 
            this.colcreate_Log.FieldName = "create_Log";
            this.colcreate_Log.Name = "colcreate_Log";
            this.colcreate_Log.Visible = true;
            this.colcreate_Log.VisibleIndex = 11;
            // 
            // colLastModify_Log
            // 
            this.colLastModify_Log.FieldName = "LastModify_Log";
            this.colLastModify_Log.Name = "colLastModify_Log";
            this.colLastModify_Log.Visible = true;
            this.colLastModify_Log.VisibleIndex = 12;
            // 
            // R00MEMBER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "R00MEMBER";
            this.Size = new System.Drawing.Size(933, 513);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r50NAMKIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r00MEMBERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource r00MEMBERBindingSource;
        private R50NAMKIMDataSet r50NAMKIMDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colMember_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMember_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colMember_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Admin;
        private DevExpress.XtraGrid.Columns.GridColumn colLocked;
        private DevExpress.XtraGrid.Columns.GridColumn colMember_ID_Allow;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckPass;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Dt_CbNv;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_DvCs_Default;
        private DevExpress.XtraGrid.Columns.GridColumn colWeb_Login;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_Log;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModify_Log;
        private R50NAMKIMDataSetTableAdapters.R00MEMBERTableAdapter r00MEMBERTableAdapter;
    }
}
