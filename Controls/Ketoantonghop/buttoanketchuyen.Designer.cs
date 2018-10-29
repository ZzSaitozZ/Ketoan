namespace Ketoan.Controls.Ketoantonghop
{
    partial class buttoanketchuyen
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tkd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chucnang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mabophan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(647, 522);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.stt,
            this.tk,
            this.tkd,
            this.dg,
            this.value,
            this.chucnang,
            this.mabophan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // stt
            // 
            this.stt.Caption = "STT";
            this.stt.Name = "stt";
            this.stt.Visible = true;
            this.stt.VisibleIndex = 1;
            // 
            // tk
            // 
            this.tk.Caption = "Tài khoản";
            this.tk.Name = "tk";
            this.tk.Visible = true;
            this.tk.VisibleIndex = 2;
            // 
            // tkd
            // 
            this.tkd.Caption = "Tài khoản đến";
            this.tkd.Name = "tkd";
            this.tkd.Visible = true;
            this.tkd.VisibleIndex = 3;
            // 
            // dg
            // 
            this.dg.Caption = "Diễn giải";
            this.dg.Name = "dg";
            this.dg.Visible = true;
            this.dg.VisibleIndex = 4;
            // 
            // value
            // 
            this.value.AppearanceCell.Options.UseTextOptions = true;
            this.value.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.value.Caption = "1-Số PS. 2 Số dư";
            this.value.Name = "value";
            this.value.Visible = true;
            this.value.VisibleIndex = 6;
            // 
            // chucnang
            // 
            this.chucnang.AppearanceCell.Options.UseTextOptions = true;
            this.chucnang.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.chucnang.Caption = "1-Nợ.2-Có.3-Tự động.4-Kết chuyển theo tài khoản có giá trị min";
            this.chucnang.Name = "chucnang";
            this.chucnang.Visible = true;
            this.chucnang.VisibleIndex = 5;
            // 
            // mabophan
            // 
            this.mabophan.Caption = "Mã bộ phận";
            this.mabophan.Name = "mabophan";
            this.mabophan.Visible = true;
            this.mabophan.VisibleIndex = 7;
            // 
            // buttoanketchuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "buttoanketchuyen";
            this.Size = new System.Drawing.Size(647, 522);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn stt;
        private DevExpress.XtraGrid.Columns.GridColumn tk;
        private DevExpress.XtraGrid.Columns.GridColumn tkd;
        private DevExpress.XtraGrid.Columns.GridColumn dg;
        private DevExpress.XtraGrid.Columns.GridColumn value;
        private DevExpress.XtraGrid.Columns.GridColumn chucnang;
        private DevExpress.XtraGrid.Columns.GridColumn mabophan;
    }
}
