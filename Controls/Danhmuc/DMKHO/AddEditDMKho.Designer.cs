namespace Ketoan.Controls.Danhmuc.DMKho
{
    partial class AddEditDMKho
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
            this.makhoTB = new System.Windows.Forms.TextBox();
            this.tenkhoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sttTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Size = new System.Drawing.Size(704, 59);
            // 
            // denyBtn
            // 
            this.denyBtn.Location = new System.Drawing.Point(597, 6);
            this.denyBtn.Click += new System.EventHandler(this.denyBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(496, 6);
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabPane1);
            this.panel2.Size = new System.Drawing.Size(704, 176);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kho";
            // 
            // makhoTB
            // 
            this.makhoTB.Location = new System.Drawing.Point(87, 30);
            this.makhoTB.Name = "makhoTB";
            this.makhoTB.Size = new System.Drawing.Size(159, 20);
            this.makhoTB.TabIndex = 1;
            // 
            // tenkhoTB
            // 
            this.tenkhoTB.Location = new System.Drawing.Point(87, 56);
            this.tenkhoTB.Name = "tenkhoTB";
            this.tenkhoTB.Size = new System.Drawing.Size(460, 20);
            this.tenkhoTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên kho";
            // 
            // sttTB
            // 
            this.sttTB.Location = new System.Drawing.Point(87, 82);
            this.sttTB.Name = "sttTB";
            this.sttTB.Size = new System.Drawing.Size(87, 20);
            this.sttTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số thứ tự";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(704, 176);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(704, 176);
            this.tabPane1.TabIndex = 6;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Thông tin chi tiết";
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.makhoTB);
            this.tabNavigationPage1.Controls.Add(this.sttTB);
            this.tabNavigationPage1.Controls.Add(this.label1);
            this.tabNavigationPage1.Controls.Add(this.label3);
            this.tabNavigationPage1.Controls.Add(this.label2);
            this.tabNavigationPage1.Controls.Add(this.tenkhoTB);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(686, 131);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(190, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Phục vụ tạo stt theo tính giá vốn)";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Thông tin thêm";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(686, 131);
            // 
            // AddEditDMKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 235);
            this.Name = "AddEditDMKho";
            this.Text = "AddEditDMKho";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.TextBox sttTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenkhoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox makhoTB;
        private System.Windows.Forms.Label label4;
    }
}