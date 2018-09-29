namespace Ketoan.Controls.Danhmuc.DMDT
{
    partial class AddEditDMDT
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
            this.tenLB = new System.Windows.Forms.Label();
            this.manhomdtLB = new System.Windows.Forms.Label();
            this.ctyTB = new System.Windows.Forms.TextBox();
            this.ctyLB = new System.Windows.Forms.Label();
            this.diachiTB = new System.Windows.Forms.TextBox();
            this.diachiLB = new System.Windows.Forms.Label();
            this.sdtLB = new System.Windows.Forms.Label();
            this.msthueLB = new System.Windows.Forms.Label();
            this.tknhLB = new System.Windows.Forms.Label();
            this.tennhTB = new System.Windows.Forms.TextBox();
            this.tennhLB = new System.Windows.Forms.Label();
            this.manhdtLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manhdtLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.e00DMNHDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eWONDATASET = new Ketoan.EWONDATASET();
            this.e00DMNHDTTableAdapter = new Ketoan.EWONDATASETTableAdapters.E00DMNHDTTableAdapter();
            this.tenTE = new DevExpress.XtraEditors.TextEdit();
            this.madtTE = new DevExpress.XtraEditors.TextEdit();
            this.sdtTE = new DevExpress.XtraEditors.TextEdit();
            this.tknhTE = new DevExpress.XtraEditors.TextEdit();
            this.msthueTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manhdtLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.madtTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknhTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msthueTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Size = new System.Drawing.Size(519, 55);
            // 
            // denyBtn
            // 
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.manhdtLUE);
            this.panel2.Controls.Add(this.ctyTB);
            this.panel2.Controls.Add(this.msthueTE);
            this.panel2.Controls.Add(this.tknhTE);
            this.panel2.Controls.Add(this.diachiTB);
            this.panel2.Controls.Add(this.sdtTE);
            this.panel2.Controls.Add(this.tenTE);
            this.panel2.Controls.Add(this.madtTE);
            this.panel2.Controls.Add(this.manhdtLB);
            this.panel2.Controls.Add(this.ctyLB);
            this.panel2.Controls.Add(this.diachiLB);
            this.panel2.Controls.Add(this.manhomdtLB);
            this.panel2.Controls.Add(this.msthueLB);
            this.panel2.Controls.Add(this.sdtLB);
            this.panel2.Controls.Add(this.tenLB);
            this.panel2.Controls.Add(this.tennhLB);
            this.panel2.Controls.Add(this.tknhLB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tennhTB);
            this.panel2.Size = new System.Drawing.Size(519, 274);
            this.panel2.Controls.SetChildIndex(this.tennhTB, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.tknhLB, 0);
            this.panel2.Controls.SetChildIndex(this.tennhLB, 0);
            this.panel2.Controls.SetChildIndex(this.tenLB, 0);
            this.panel2.Controls.SetChildIndex(this.sdtLB, 0);
            this.panel2.Controls.SetChildIndex(this.msthueLB, 0);
            this.panel2.Controls.SetChildIndex(this.manhomdtLB, 0);
            this.panel2.Controls.SetChildIndex(this.diachiLB, 0);
            this.panel2.Controls.SetChildIndex(this.ctyLB, 0);
            this.panel2.Controls.SetChildIndex(this.manhdtLB, 0);
            this.panel2.Controls.SetChildIndex(this.madtTE, 0);
            this.panel2.Controls.SetChildIndex(this.tenTE, 0);
            this.panel2.Controls.SetChildIndex(this.sdtTE, 0);
            this.panel2.Controls.SetChildIndex(this.diachiTB, 0);
            this.panel2.Controls.SetChildIndex(this.tknhTE, 0);
            this.panel2.Controls.SetChildIndex(this.msthueTE, 0);
            this.panel2.Controls.SetChildIndex(this.ctyTB, 0);
            this.panel2.Controls.SetChildIndex(this.manhdtLUE, 0);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // tenLB
            // 
            this.tenLB.AutoSize = true;
            this.tenLB.Location = new System.Drawing.Point(100, 43);
            this.tenLB.Name = "tenLB";
            this.tenLB.Size = new System.Drawing.Size(31, 13);
            this.tenLB.TabIndex = 2;
            this.tenLB.Text = "Tên*";
            // 
            // manhomdtLB
            // 
            this.manhomdtLB.AutoSize = true;
            this.manhomdtLB.Location = new System.Drawing.Point(26, 69);
            this.manhomdtLB.Name = "manhomdtLB";
            this.manhomdtLB.Size = new System.Drawing.Size(105, 13);
            this.manhomdtLB.TabIndex = 4;
            this.manhomdtLB.Text = "Mã nhóm đối tượng*";
            // 
            // ctyTB
            // 
            this.ctyTB.Location = new System.Drawing.Point(137, 169);
            this.ctyTB.MaxLength = 200;
            this.ctyTB.Name = "ctyTB";
            this.ctyTB.Size = new System.Drawing.Size(352, 21);
            this.ctyTB.TabIndex = 7;
            // 
            // ctyLB
            // 
            this.ctyLB.AutoSize = true;
            this.ctyLB.Location = new System.Drawing.Point(86, 172);
            this.ctyLB.Name = "ctyLB";
            this.ctyLB.Size = new System.Drawing.Size(45, 13);
            this.ctyLB.TabIndex = 6;
            this.ctyLB.Text = "Công ty";
            // 
            // diachiTB
            // 
            this.diachiTB.Location = new System.Drawing.Point(137, 142);
            this.diachiTB.MaxLength = 200;
            this.diachiTB.Name = "diachiTB";
            this.diachiTB.Size = new System.Drawing.Size(352, 21);
            this.diachiTB.TabIndex = 6;
            // 
            // diachiLB
            // 
            this.diachiLB.AutoSize = true;
            this.diachiLB.Location = new System.Drawing.Point(92, 145);
            this.diachiLB.Name = "diachiLB";
            this.diachiLB.Size = new System.Drawing.Size(39, 13);
            this.diachiLB.TabIndex = 8;
            this.diachiLB.Text = "Địa chỉ";
            // 
            // sdtLB
            // 
            this.sdtLB.AutoSize = true;
            this.sdtLB.Location = new System.Drawing.Point(62, 118);
            this.sdtLB.Name = "sdtLB";
            this.sdtLB.Size = new System.Drawing.Size(69, 13);
            this.sdtLB.TabIndex = 10;
            this.sdtLB.Text = "Số điện thoại";
            // 
            // msthueLB
            // 
            this.msthueLB.AutoSize = true;
            this.msthueLB.Location = new System.Drawing.Point(71, 199);
            this.msthueLB.Name = "msthueLB";
            this.msthueLB.Size = new System.Drawing.Size(60, 13);
            this.msthueLB.TabIndex = 12;
            this.msthueLB.Text = "Mã số thuế";
            // 
            // tknhLB
            // 
            this.tknhLB.AutoSize = true;
            this.tknhLB.Location = new System.Drawing.Point(24, 225);
            this.tknhLB.Name = "tknhLB";
            this.tknhLB.Size = new System.Drawing.Size(107, 13);
            this.tknhLB.TabIndex = 14;
            this.tknhLB.Text = "Tài khoản ngân hàng";
            // 
            // tennhTB
            // 
            this.tennhTB.Location = new System.Drawing.Point(137, 248);
            this.tennhTB.MaxLength = 100;
            this.tennhTB.Name = "tennhTB";
            this.tennhTB.Size = new System.Drawing.Size(352, 21);
            this.tennhTB.TabIndex = 10;
            // 
            // tennhLB
            // 
            this.tennhLB.AutoSize = true;
            this.tennhLB.Location = new System.Drawing.Point(52, 251);
            this.tennhLB.Name = "tennhLB";
            this.tennhLB.Size = new System.Drawing.Size(79, 13);
            this.tennhLB.TabIndex = 16;
            this.tennhLB.Text = "Tên ngân hàng";
            // 
            // manhdtLB
            // 
            this.manhdtLB.AutoSize = true;
            this.manhdtLB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.manhdtLB.Location = new System.Drawing.Point(137, 69);
            this.manhdtLB.Name = "manhdtLB";
            this.manhdtLB.Size = new System.Drawing.Size(134, 13);
            this.manhdtLB.TabIndex = 18;
            this.manhdtLB.Text = "Mã nhóm đối tượng chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã đối tượng*";
            // 
            // manhdtLUE
            // 
            this.manhdtLUE.Location = new System.Drawing.Point(137, 89);
            this.manhdtLUE.Name = "manhdtLUE";
            this.manhdtLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.manhdtLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_Nh_Dt", "Ma_Nh_Dt", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_Nh_Dt", "Ten_Nh_Dt", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.manhdtLUE.Properties.DataSource = this.e00DMNHDTBindingSource;
            this.manhdtLUE.Properties.DisplayMember = "Ten_Nh_Dt";
            this.manhdtLUE.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.manhdtLUE.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.manhdtLUE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.manhdtLUE.Properties.ValueMember = "Ma_Nh_Dt";
            this.manhdtLUE.Size = new System.Drawing.Size(196, 20);
            this.manhdtLUE.TabIndex = 3;
            this.manhdtLUE.EditValueChanged += new System.EventHandler(this.manhdtLUE_EditValueChanged);
            // 
            // e00DMNHDTBindingSource
            // 
            this.e00DMNHDTBindingSource.DataMember = "E00DMNHDT";
            this.e00DMNHDTBindingSource.DataSource = this.eWONDATASET;
            // 
            // eWONDATASET
            // 
            this.eWONDATASET.DataSetName = "EWONDATASET";
            this.eWONDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e00DMNHDTTableAdapter
            // 
            this.e00DMNHDTTableAdapter.ClearBeforeFill = true;
            // 
            // tenTE
            // 
            this.tenTE.EditValue = "EWON";
            this.tenTE.Location = new System.Drawing.Point(137, 40);
            this.tenTE.Name = "tenTE";
            this.tenTE.Properties.MaxLength = 100;
            this.tenTE.Size = new System.Drawing.Size(352, 20);
            this.tenTE.TabIndex = 2;
            this.tenTE.EditValueChanged += new System.EventHandler(this.tenTE_EditValueChanged);
            // 
            // madtTE
            // 
            this.madtTE.EditValue = "EWON";
            this.madtTE.Location = new System.Drawing.Point(137, 14);
            this.madtTE.Name = "madtTE";
            this.madtTE.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.madtTE.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.madtTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.madtTE.Size = new System.Drawing.Size(94, 20);
            this.madtTE.TabIndex = 1;
            this.madtTE.EditValueChanged += new System.EventHandler(this.madtTE_EditValueChanged);
            // 
            // sdtTE
            // 
            this.sdtTE.Location = new System.Drawing.Point(137, 115);
            this.sdtTE.Name = "sdtTE";
            this.sdtTE.Properties.Mask.EditMask = "[0-9]{1,11}";
            this.sdtTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.sdtTE.Size = new System.Drawing.Size(134, 20);
            this.sdtTE.TabIndex = 4;
            // 
            // tknhTE
            // 
            this.tknhTE.Location = new System.Drawing.Point(137, 222);
            this.tknhTE.Name = "tknhTE";
            this.tknhTE.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tknhTE.Properties.Mask.EditMask = "[0-9A-Z]{1,50}";
            this.tknhTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tknhTE.Size = new System.Drawing.Size(237, 20);
            this.tknhTE.TabIndex = 9;
            // 
            // msthueTE
            // 
            this.msthueTE.Location = new System.Drawing.Point(137, 196);
            this.msthueTE.Name = "msthueTE";
            this.msthueTE.Properties.Mask.EditMask = "[0-9]{1,13}";
            this.msthueTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.msthueTE.Size = new System.Drawing.Size(237, 20);
            this.msthueTE.TabIndex = 8;
            // 
            // AddEditDMDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 381);
            this.Name = "AddEditDMDT";
            this.Text = "AddEditDMDT";
            this.Load += new System.EventHandler(this.AddEditDMDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manhdtLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e00DMNHDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWONDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.madtTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdtTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknhTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msthueTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox diachiTB;
        private System.Windows.Forms.Label diachiLB;
        private System.Windows.Forms.TextBox ctyTB;
        private System.Windows.Forms.Label ctyLB;
        private System.Windows.Forms.Label manhomdtLB;
        private System.Windows.Forms.Label tenLB;
        private System.Windows.Forms.TextBox tennhTB;
        private System.Windows.Forms.Label tennhLB;
        private System.Windows.Forms.Label tknhLB;
        private System.Windows.Forms.Label msthueLB;
        private System.Windows.Forms.Label sdtLB;
        private System.Windows.Forms.Label manhdtLB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit manhdtLUE;
        private EWONDATASET eWONDATASET;
        private System.Windows.Forms.BindingSource e00DMNHDTBindingSource;
        private EWONDATASETTableAdapters.E00DMNHDTTableAdapter e00DMNHDTTableAdapter;
        private DevExpress.XtraEditors.TextEdit tenTE;
        private DevExpress.XtraEditors.TextEdit msthueTE;
        private DevExpress.XtraEditors.TextEdit tknhTE;
        private DevExpress.XtraEditors.TextEdit sdtTE;
        private DevExpress.XtraEditors.TextEdit madtTE;
    }
}