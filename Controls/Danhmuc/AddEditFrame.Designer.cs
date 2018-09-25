namespace Ketoan.Controls.Danhmuc
{
    partial class AddEditFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditFrame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.denyBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invisibleLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.denyBtn);
            this.panel1.Controls.Add(this.acceptBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 59);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.LoseFocusClick);
            // 
            // denyBtn
            // 
            this.denyBtn.Image = ((System.Drawing.Image)(resources.GetObject("denyBtn.Image")));
            this.denyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.denyBtn.Location = new System.Drawing.Point(412, 6);
            this.denyBtn.Name = "denyBtn";
            this.denyBtn.Size = new System.Drawing.Size(95, 46);
            this.denyBtn.TabIndex = 1;
            this.denyBtn.Text = "         Hủy bỏ";
            this.denyBtn.UseVisualStyleBackColor = true;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acceptBtn.Location = new System.Drawing.Point(311, 6);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(95, 46);
            this.acceptBtn.TabIndex = 0;
            this.acceptBtn.Text = "         Đồng ý";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invisibleLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 281);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.LoseFocusClick);
            // 
            // invisibleLB
            // 
            this.invisibleLB.AutoSize = true;
            this.invisibleLB.Location = new System.Drawing.Point(472, 9);
            this.invisibleLB.Name = "invisibleLB";
            this.invisibleLB.Size = new System.Drawing.Size(0, 13);
            this.invisibleLB.TabIndex = 0;
            // 
            // AddEditFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 340);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEditFrame";
            this.Text = "AddEditFrame";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button denyBtn;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label invisibleLB;
    }
}