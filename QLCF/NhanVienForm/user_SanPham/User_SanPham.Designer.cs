namespace QLCF.NhanVienForm.user_SanPham
{
    partial class User_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_SanPham));
            this.pnlBoXSanPham = new System.Windows.Forms.Panel();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbNameSP = new System.Windows.Forms.Label();
            this.pictureBox_Mon = new System.Windows.Forms.PictureBox();
            this.pnlBoXSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoXSanPham
            // 
            this.pnlBoXSanPham.Controls.Add(this.lbDonGia);
            this.pnlBoXSanPham.Controls.Add(this.lbNameSP);
            this.pnlBoXSanPham.Controls.Add(this.pictureBox_Mon);
            this.pnlBoXSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoXSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlBoXSanPham.Name = "pnlBoXSanPham";
            this.pnlBoXSanPham.Size = new System.Drawing.Size(358, 135);
            this.pnlBoXSanPham.TabIndex = 0;
            this.pnlBoXSanPham.Click += new System.EventHandler(this.pnlBoXSanPham_Click);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDonGia.Location = new System.Drawing.Point(217, 98);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(132, 34);
            this.lbDonGia.TabIndex = 5;
            this.lbDonGia.Text = "23.000đ";
            this.lbDonGia.Click += new System.EventHandler(this.lbDonGia_Click);
            // 
            // lbNameSP
            // 
            this.lbNameSP.AutoSize = true;
            this.lbNameSP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNameSP.Location = new System.Drawing.Point(125, 12);
            this.lbNameSP.Name = "lbNameSP";
            this.lbNameSP.Size = new System.Drawing.Size(228, 25);
            this.lbNameSP.TabIndex = 4;
            this.lbNameSP.Text = "Cà phê truyền thống ";
            this.lbNameSP.Click += new System.EventHandler(this.lbNameSP_Click);
            // 
            // pictureBox_Mon
            // 
            this.pictureBox_Mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Mon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Mon.Image")));
            this.pictureBox_Mon.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Mon.Name = "pictureBox_Mon";
            this.pictureBox_Mon.Size = new System.Drawing.Size(113, 129);
            this.pictureBox_Mon.TabIndex = 3;
            this.pictureBox_Mon.TabStop = false;
            this.pictureBox_Mon.Click += new System.EventHandler(this.pictureBox_Mon_Click);
            // 
            // User_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(177)))), ((int)(((byte)(166)))));
            this.Controls.Add(this.pnlBoXSanPham);
            this.Name = "User_SanPham";
            this.Size = new System.Drawing.Size(358, 135);
            this.Load += new System.EventHandler(this.User_SanPham_Load);
            this.pnlBoXSanPham.ResumeLayout(false);
            this.pnlBoXSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDonGia;
        public System.Windows.Forms.Label lbNameSP;
        private System.Windows.Forms.PictureBox pictureBox_Mon;
        public System.Windows.Forms.Panel pnlBoXSanPham;
    }
}
