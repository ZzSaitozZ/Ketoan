namespace Ketoan.Controls.Danhmuc.DMKHO
{
    partial class AddEditDMKHO
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
            this.tenLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.makhoTE = new DevExpress.XtraEditors.TextEdit();
            this.sttTE = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Chuthich = new System.Windows.Forms.Label();
            this.tenkhoTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makhoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenkhoTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Size = new System.Drawing.Size(525, 45);
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(430, 0);
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tenkhoTE);
            this.panel2.Controls.Add(this.Chuthich);
            this.panel2.Controls.Add(this.sttTE);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.makhoTE);
            this.panel2.Controls.Add(this.tenLB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Size = new System.Drawing.Size(525, 93);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.tenLB, 0);
            this.panel2.Controls.SetChildIndex(this.makhoTE, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.sttTE, 0);
            this.panel2.Controls.SetChildIndex(this.Chuthich, 0);
            this.panel2.Controls.SetChildIndex(this.tenkhoTE, 0);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(335, 0);
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // tenLB
            // 
            this.tenLB.AutoSize = true;
            this.tenLB.Location = new System.Drawing.Point(86, 43);
            this.tenLB.Name = "tenLB";
            this.tenLB.Size = new System.Drawing.Size(45, 13);
            this.tenLB.TabIndex = 20;
            this.tenLB.Text = "Tên kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã kho";
            // 
            // makhoTE
            // 
            this.makhoTE.EditValue = "";
            this.makhoTE.Location = new System.Drawing.Point(137, 14);
            this.makhoTE.Name = "makhoTE";
            this.makhoTE.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.makhoTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.makhoTE.Size = new System.Drawing.Size(164, 20);
            this.makhoTE.TabIndex = 23;
            this.makhoTE.EditValueChanged += new System.EventHandler(this.makhoTE_EditValueChanged);
            // 
            // sttTE
            // 
            this.sttTE.EditValue = "";
            this.sttTE.Location = new System.Drawing.Point(137, 66);
            this.sttTE.Name = "sttTE";
            this.sttTE.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sttTE.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.sttTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.sttTE.Size = new System.Drawing.Size(100, 20);
            this.sttTE.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Số thứ tự";
            // 
            // Chuthich
            // 
            this.Chuthich.AutoSize = true;
            this.Chuthich.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Chuthich.Location = new System.Drawing.Point(243, 69);
            this.Chuthich.Name = "Chuthich";
            this.Chuthich.Size = new System.Drawing.Size(168, 13);
            this.Chuthich.TabIndex = 19;
            this.Chuthich.Text = "(Phục vụ tạo STT khi tính giá vốn)";
            // 
            // tenkhoTE
            // 
            this.tenkhoTE.Location = new System.Drawing.Point(137, 40);
            this.tenkhoTE.Name = "tenkhoTE";
            this.tenkhoTE.Size = new System.Drawing.Size(274, 20);
            this.tenkhoTE.TabIndex = 27;
            // 
            // AddEditDMKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 200);
            this.Name = "AddEditDMKHO";
            this.Text = "AddEditDMKho";
            ((System.ComponentModel.ISupportInitialize)(this.ewErrorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makhoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sttTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenkhoTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tenLB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit makhoTE;
        private DevExpress.XtraEditors.TextEdit sttTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Chuthich;
        private DevExpress.XtraEditors.TextEdit tenkhoTE;
    }
}