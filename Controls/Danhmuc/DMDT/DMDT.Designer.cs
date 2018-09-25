namespace Ketoan.Controls.Danhmuc.DMDT
{
    partial class DMDT
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
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMDTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMDTTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nh_Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCong_Ty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_So_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Tk_NH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_NH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
      
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMDTTableAdapter
            // 
            this.e00DMDTTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "E00DMDT";
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
            this.colMa_Dt,
            this.colTen_Dt,
            this.colMa_Nh_Dt,
            this.colCong_Ty,
            this.colSo_Phone,
            this.colDia_Chi,
            this.colMa_So_Thue,
            this.colSo_Tk_NH,
            this.colTen_NH});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMa_Dt
            // 
            this.colMa_Dt.Caption = "Mã đối tượng";
            this.colMa_Dt.FieldName = "Ma_Dt";
            this.colMa_Dt.Name = "colMa_Dt";
            this.colMa_Dt.Visible = true;
            this.colMa_Dt.VisibleIndex = 0;
            // 
            // colTen_Dt
            // 
            this.colTen_Dt.Caption = "Tên đối tượng";
            this.colTen_Dt.FieldName = "Ten_Dt";
            this.colTen_Dt.Name = "colTen_Dt";
            this.colTen_Dt.Visible = true;
            this.colTen_Dt.VisibleIndex = 1;
            // 
            // colMa_Nh_Dt
            // 
            this.colMa_Nh_Dt.Caption = "Mã nhóm đối tượng";
            this.colMa_Nh_Dt.FieldName = "Ma_Nh_Dt";
            this.colMa_Nh_Dt.Name = "colMa_Nh_Dt";
            this.colMa_Nh_Dt.Visible = true;
            this.colMa_Nh_Dt.VisibleIndex = 2;
            // 
            // colCong_Ty
            // 
            this.colCong_Ty.Caption = "Công ty";
            this.colCong_Ty.FieldName = "Cong_Ty";
            this.colCong_Ty.Name = "colCong_Ty";
            this.colCong_Ty.Visible = true;
            this.colCong_Ty.VisibleIndex = 3;
            // 
            // colSo_Phone
            // 
            this.colSo_Phone.Caption = "Số điện thoại";
            this.colSo_Phone.FieldName = "So_Phone";
            this.colSo_Phone.Name = "colSo_Phone";
            this.colSo_Phone.Visible = true;
            this.colSo_Phone.VisibleIndex = 5;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 4;
            // 
            // colMa_So_Thue
            // 
            this.colMa_So_Thue.Caption = "Mã số thuế";
            this.colMa_So_Thue.FieldName = "Ma_So_Thue";
            this.colMa_So_Thue.Name = "colMa_So_Thue";
            this.colMa_So_Thue.Visible = true;
            this.colMa_So_Thue.VisibleIndex = 6;
            // 
            // colSo_Tk_NH
            // 
            this.colSo_Tk_NH.Caption = "Tài khoản ngân hàng";
            this.colSo_Tk_NH.FieldName = "So_Tk_NH";
            this.colSo_Tk_NH.Name = "colSo_Tk_NH";
            this.colSo_Tk_NH.Visible = true;
            this.colSo_Tk_NH.VisibleIndex = 7;
            // 
            // colTen_NH
            // 
            this.colTen_NH.Caption = "Tên ngân hàng";
            this.colTen_NH.FieldName = "Ten_NH";
            this.colTen_NH.Name = "colTen_NH";
            this.colTen_NH.Visible = true;
            this.colTen_NH.VisibleIndex = 8;
            // 
            // DMDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 262);
            this.Name = "DMDT";
            this.Text = "DMDT";
            this.Load += new System.EventHandler(this.DMDT_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EWONDATASET eWONDATASET;
        private EWONDATASETTableAdapters.E00DMDTTableAdapter e00DMDTTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nh_Dt;
        private DevExpress.XtraGrid.Columns.GridColumn colCong_Ty;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_So_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Tk_NH;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_NH;
    }
}