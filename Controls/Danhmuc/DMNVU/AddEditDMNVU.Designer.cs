namespace Ketoan.Controls.Danhmuc.DMNVU
{
    partial class AddEditDMNVU 
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.manvuTE = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tennvuTE = new DevExpress.XtraEditors.TextEdit();
            this.mactTE = new DevExpress.XtraEditors.TextEdit();
            this.mactruleTE = new DevExpress.XtraEditors.TextEdit();
            this.tknoTE = new DevExpress.XtraEditors.TextEdit();
            this.tknoruleTE = new DevExpress.XtraEditors.TextEdit();
            this.tkcoTE = new DevExpress.XtraEditors.TextEdit();
            this.tkcoruleTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manvuTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennvuTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mactTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mactruleTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknoruleTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkcoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkcoruleTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Size = new System.Drawing.Size(465, 45);
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(370, 0);
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tkcoruleTE);
            this.panel2.Controls.Add(this.tkcoTE);
            this.panel2.Controls.Add(this.tknoruleTE);
            this.panel2.Controls.Add(this.tknoTE);
            this.panel2.Controls.Add(this.mactruleTE);
            this.panel2.Controls.Add(this.mactTE);
            this.panel2.Controls.Add(this.tennvuTE);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.manvuTE);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Size = new System.Drawing.Size(465, 226);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.manvuTE, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.label6, 0);
            this.panel2.Controls.SetChildIndex(this.label8, 0);
            this.panel2.Controls.SetChildIndex(this.tennvuTE, 0);
            this.panel2.Controls.SetChildIndex(this.mactTE, 0);
            this.panel2.Controls.SetChildIndex(this.mactruleTE, 0);
            this.panel2.Controls.SetChildIndex(this.tknoTE, 0);
            this.panel2.Controls.SetChildIndex(this.tknoruleTE, 0);
            this.panel2.Controls.SetChildIndex(this.tkcoTE, 0);
            this.panel2.Controls.SetChildIndex(this.tkcoruleTE, 0);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(275, 0);
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nghiệp vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nghiệp vụ";
            // 
            // manvuTE
            // 
            this.manvuTE.EditValue = "";
            this.manvuTE.Location = new System.Drawing.Point(132, 14);
            this.manvuTE.Name = "manvuTE";
            this.manvuTE.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.manvuTE.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.manvuTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.manvuTE.Size = new System.Drawing.Size(100, 20);
            this.manvuTE.TabIndex = 2;
            this.manvuTE.EditValueChanged += new System.EventHandler(this.manvuTE_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã chứng từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã chứng từ rule";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tài khoản nợ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tài khoản nợ rule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tài khoản có";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tài khoản có rule";
            // 
            // tennvuTE
            // 
            this.tennvuTE.Location = new System.Drawing.Point(132, 40);
            this.tennvuTE.Name = "tennvuTE";
            this.tennvuTE.Size = new System.Drawing.Size(300, 20);
            this.tennvuTE.TabIndex = 3;
            // 
            // mactTE
            // 
            this.mactTE.Location = new System.Drawing.Point(132, 66);
            this.mactTE.Name = "mactTE";
            this.mactTE.Size = new System.Drawing.Size(100, 20);
            this.mactTE.TabIndex = 3;
            // 
            // mactruleTE
            // 
            this.mactruleTE.Location = new System.Drawing.Point(132, 92);
            this.mactruleTE.Name = "mactruleTE";
            this.mactruleTE.Size = new System.Drawing.Size(100, 20);
            this.mactruleTE.TabIndex = 3;
            // 
            // tknoTE
            // 
            this.tknoTE.Location = new System.Drawing.Point(132, 118);
            this.tknoTE.Name = "tknoTE";
            this.tknoTE.Size = new System.Drawing.Size(200, 20);
            this.tknoTE.TabIndex = 3;
            // 
            // tknoruleTE
            // 
            this.tknoruleTE.Location = new System.Drawing.Point(132, 144);
            this.tknoruleTE.Name = "tknoruleTE";
            this.tknoruleTE.Size = new System.Drawing.Size(100, 20);
            this.tknoruleTE.TabIndex = 3;
            // 
            // tkcoTE
            // 
            this.tkcoTE.Location = new System.Drawing.Point(131, 170);
            this.tkcoTE.Name = "tkcoTE";
            this.tkcoTE.Size = new System.Drawing.Size(200, 20);
            this.tkcoTE.TabIndex = 3;
            // 
            // tkcoruleTE
            // 
            this.tkcoruleTE.Location = new System.Drawing.Point(131, 196);
            this.tkcoruleTE.Name = "tkcoruleTE";
            this.tkcoruleTE.Size = new System.Drawing.Size(100, 20);
            this.tkcoruleTE.TabIndex = 3;
            // 
            // AddEditDMNVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 333);
            this.Name = "AddEditDMNVU";
            this.Text = "AddEditDMNVU";
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manvuTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennvuTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mactTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mactruleTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tknoruleTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkcoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkcoruleTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit manvuTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit tkcoruleTE;
        private DevExpress.XtraEditors.TextEdit tkcoTE;
        private DevExpress.XtraEditors.TextEdit tknoruleTE;
        private DevExpress.XtraEditors.TextEdit tknoTE;
        private DevExpress.XtraEditors.TextEdit mactruleTE;
        private DevExpress.XtraEditors.TextEdit mactTE;
        private DevExpress.XtraEditors.TextEdit tennvuTE;
    }
}