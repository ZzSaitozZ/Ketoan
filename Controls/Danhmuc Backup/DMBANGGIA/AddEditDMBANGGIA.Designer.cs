namespace Ketoan.Controls.Danhmuc.DMBANGGIA
{
    partial class AddEditDMBANGGIA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vtLB = new System.Windows.Forms.Label();
            this.e00DMVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMVTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMVTTableAdapter();
            this.giaTE = new DevExpress.XtraEditors.TextEdit();
            this.mavtLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtLUE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Size = new System.Drawing.Size(505, 45);
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(410, 0);
            this.denyBtn.TabIndex = 4;
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mavtLUE);
            this.panel2.Controls.Add(this.giaTE);
            this.panel2.Controls.Add(this.vtLB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Size = new System.Drawing.Size(505, 88);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.vtLB, 0);
            this.panel2.Controls.SetChildIndex(this.giaTE, 0);
            this.panel2.Controls.SetChildIndex(this.mavtLUE, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(315, 0);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vật tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá";
            // 
            // vtLB
            // 
            this.vtLB.AutoSize = true;
            this.vtLB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vtLB.Location = new System.Drawing.Point(271, 17);
            this.vtLB.Name = "vtLB";
            this.vtLB.Size = new System.Drawing.Size(66, 13);
            this.vtLB.TabIndex = 4;
            this.vtLB.Text = "[Tên vật tư]";
            // 
            // e00DMVTBindingSource
            // 
            this.e00DMVTBindingSource.DataMember = "E00DMVT";
            this.e00DMVTBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMVTTableAdapter
            // 
            this.e00DMVTTableAdapter.ClearBeforeFill = true;
            // 
            // giaTE
            // 
            this.giaTE.EditValue = "1000";
            this.giaTE.Location = new System.Drawing.Point(115, 40);
            this.giaTE.Name = "giaTE";
            this.giaTE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.giaTE.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.giaTE.Properties.Mask.EditMask = "[0-9]+";
            this.giaTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.giaTE.Properties.Mask.PlaceHolder = '0';
            this.giaTE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.giaTE.Size = new System.Drawing.Size(100, 20);
            this.giaTE.TabIndex = 2;
            this.giaTE.EditValueChanged += new System.EventHandler(this.giaTE_EditValueChanged);
            // 
            // mavtLUE
            // 
            this.mavtLUE.Location = new System.Drawing.Point(115, 14);
            this.mavtLUE.Name = "mavtLUE";
            this.mavtLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mavtLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_Vt", "Mã vật tư", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_Vt", "Tên vật tư", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.mavtLUE.Properties.DataSource = this.e00DMVTBindingSource;
            this.mavtLUE.Properties.DisplayMember = "Ten_Vt";
            this.mavtLUE.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.mavtLUE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.mavtLUE.Properties.ValueMember = "Ma_Vt";
            this.mavtLUE.Size = new System.Drawing.Size(150, 20);
            this.mavtLUE.TabIndex = 1;
            this.mavtLUE.EditValueChanged += new System.EventHandler(this.mavtLUE_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(221, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đồng";
            // 
            // AddEditDMBANGGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 195);
            this.Name = "AddEditDMBANGGIA";
            this.RightToLeftLayout = true;
            this.Text = "AddEditDMBANGGIA";
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtLUE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vtLB;
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMVTBindingSource;
        private EWONDATASETTableAdapters.E00DMVTTableAdapter e00DMVTTableAdapter;
        private DevExpress.XtraEditors.TextEdit giaTE;
        private DevExpress.XtraEditors.LookUpEdit mavtLUE;
        private System.Windows.Forms.Label label3;
    }
}