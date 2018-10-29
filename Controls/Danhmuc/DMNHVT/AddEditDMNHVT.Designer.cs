namespace Ketoan.Controls.Danhmuc.DMNHVT
{
    partial class AddEditDMNHVT
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
            this.manhomdtLB = new System.Windows.Forms.Label();
            this.sdtLB = new System.Windows.Forms.Label();
            this.tenLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhparentTE = new DevExpress.XtraEditors.TextEdit();
            this.manhTE = new DevExpress.XtraEditors.TextEdit();
            this.Chuthich = new System.Windows.Forms.Label();
            this.loaiCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tennhTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhparentTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manhTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennhTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Size = new System.Drawing.Size(687, 59);
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(592, 0);
            this.denyBtn.Size = new System.Drawing.Size(95, 59);
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tennhTE);
            this.panel2.Controls.Add(this.Chuthich);
            this.panel2.Controls.Add(this.manhTE);
            this.panel2.Controls.Add(this.nhparentTE);
            this.panel2.Controls.Add(this.manhomdtLB);
            this.panel2.Controls.Add(this.sdtLB);
            this.panel2.Controls.Add(this.tenLB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.loaiCBE);
            this.panel2.Size = new System.Drawing.Size(687, 122);
            this.panel2.Controls.SetChildIndex(this.loaiCBE, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.tenLB, 0);
            this.panel2.Controls.SetChildIndex(this.sdtLB, 0);
            this.panel2.Controls.SetChildIndex(this.manhomdtLB, 0);
            this.panel2.Controls.SetChildIndex(this.nhparentTE, 0);
            this.panel2.Controls.SetChildIndex(this.manhTE, 0);
            this.panel2.Controls.SetChildIndex(this.Chuthich, 0);
            this.panel2.Controls.SetChildIndex(this.tennhTE, 0);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(497, 0);
            this.acceptBtn.Size = new System.Drawing.Size(95, 59);
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // manhomdtLB
            // 
            this.manhomdtLB.AutoSize = true;
            this.manhomdtLB.Location = new System.Drawing.Point(77, 69);
            this.manhomdtLB.Name = "manhomdtLB";
            this.manhomdtLB.Size = new System.Drawing.Size(54, 13);
            this.manhomdtLB.TabIndex = 21;
            this.manhomdtLB.Text = "Nhóm cha";
            // 
            // sdtLB
            // 
            this.sdtLB.AutoSize = true;
            this.sdtLB.Location = new System.Drawing.Point(76, 95);
            this.sdtLB.Name = "sdtLB";
            this.sdtLB.Size = new System.Drawing.Size(55, 13);
            this.sdtLB.TabIndex = 22;
            this.sdtLB.Text = "Loại nhóm";
            // 
            // tenLB
            // 
            this.tenLB.AutoSize = true;
            this.tenLB.Location = new System.Drawing.Point(77, 43);
            this.tenLB.Name = "tenLB";
            this.tenLB.Size = new System.Drawing.Size(54, 13);
            this.tenLB.TabIndex = 20;
            this.tenLB.Text = "Tên nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã  nhóm";
            // 
            // nhparentTE
            // 
            this.nhparentTE.EditValue = "";
            this.nhparentTE.Location = new System.Drawing.Point(137, 66);
            this.nhparentTE.Name = "nhparentTE";
            this.nhparentTE.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.nhparentTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.nhparentTE.Size = new System.Drawing.Size(94, 20);
            this.nhparentTE.TabIndex = 25;
            // 
            // manhTE
            // 
            this.manhTE.EditValue = "";
            this.manhTE.Location = new System.Drawing.Point(137, 14);
            this.manhTE.Name = "manhTE";
            this.manhTE.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.manhTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.manhTE.Size = new System.Drawing.Size(94, 20);
            this.manhTE.TabIndex = 27;
            this.manhTE.EditValueChanged += new System.EventHandler(this.manhTE_EditValueChanged);
            // 
            // Chuthich
            // 
            this.Chuthich.AutoSize = true;
            this.Chuthich.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Chuthich.Location = new System.Drawing.Point(203, 95);
            this.Chuthich.Name = "Chuthich";
            this.Chuthich.Size = new System.Drawing.Size(443, 13);
            this.Chuthich.TabIndex = 28;
            this.Chuthich.Text = "VT- Nhóm vật tư, SP- Nhóm sản phẩm, TS- Tài sản, CC- Công cụ dụng cụ, CH- Nhóm ch" +
    "ung";
            // 
            // loaiCBE
            // 
            this.loaiCBE.EditValue = "";
            this.loaiCBE.Location = new System.Drawing.Point(137, 92);
            this.loaiCBE.Name = "loaiCBE";
            this.loaiCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loaiCBE.Properties.Items.AddRange(new object[] {
            "VT",
            "SP",
            "TS",
            "CC",
            "CH"});
            this.loaiCBE.Size = new System.Drawing.Size(60, 20);
            this.loaiCBE.TabIndex = 24;
            // 
            // tennhTE
            // 
            this.tennhTE.Location = new System.Drawing.Point(138, 41);
            this.tennhTE.Name = "tennhTE";
            this.tennhTE.Size = new System.Drawing.Size(334, 20);
            this.tennhTE.TabIndex = 29;
            // 
            // AddEditDMNHVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 243);
            this.Name = "AddEditDMNHVT";
            this.Text = "AddEditDMNHVT";
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhparentTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manhTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennhTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manhomdtLB;
        private System.Windows.Forms.Label sdtLB;
        private System.Windows.Forms.Label tenLB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit manhTE;
        private DevExpress.XtraEditors.TextEdit nhparentTE;
        private System.Windows.Forms.Label Chuthich;
        private DevExpress.XtraEditors.ComboBoxEdit loaiCBE;
        private DevExpress.XtraEditors.TextEdit tennhTE;
    }
}