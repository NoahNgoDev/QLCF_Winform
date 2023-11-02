namespace QLCF
{
    partial class DangNhap
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
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbTendn = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.chkGhi = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.BackColor = System.Drawing.Color.White;
            this.lbDangNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lbDangNhap.Location = new System.Drawing.Point(380, 77);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(158, 32);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "Đăng Nhập ";
            // 
            // lbTendn
            // 
            this.lbTendn.AutoSize = true;
            this.lbTendn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTendn.Location = new System.Drawing.Point(236, 131);
            this.lbTendn.Name = "lbTendn";
            this.lbTendn.Size = new System.Drawing.Size(140, 23);
            this.lbTendn.TabIndex = 1;
            this.lbTendn.Text = "Tên Đăng Nhập";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(290, 204);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(65, 16);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Mật Khẩu ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(410, 131);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(196, 22);
            this.txtTen.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(410, 204);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(196, 22);
            this.txtPass.TabIndex = 4;
            // 
            // chkGhi
            // 
            this.chkGhi.AutoSize = true;
            this.chkGhi.Location = new System.Drawing.Point(333, 272);
            this.chkGhi.Name = "chkGhi";
            this.chkGhi.Size = new System.Drawing.Size(127, 20);
            this.chkGhi.TabIndex = 5;
            this.chkGhi.Text = "Bạn có ghi nhớ ?";
            this.chkGhi.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(491, 272);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(115, 23);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập ";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(816, 460);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.chkGhi);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbTendn);
            this.Controls.Add(this.lbDangNhap);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbTendn;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox chkGhi;
        private System.Windows.Forms.Button btnDangNhap;
    }
}