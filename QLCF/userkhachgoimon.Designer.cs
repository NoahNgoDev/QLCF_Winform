namespace QLCF
{
    partial class userkhachgoimon
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
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnThe = new System.Windows.Forms.Button();
            this.btnTienmat = new System.Windows.Forms.Button();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lbMon = new System.Windows.Forms.Label();
            this.ln_mon = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(294, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThanhtoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Location = new System.Drawing.Point(59, 80);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(226, 50);
            this.btnThanhtoan.TabIndex = 1;
            this.btnThanhtoan.Text = "Thanh Toán";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            // 
            // btnThe
            // 
            this.btnThe.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnThe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThe.Location = new System.Drawing.Point(59, 40);
            this.btnThe.Name = "btnThe";
            this.btnThe.Size = new System.Drawing.Size(83, 34);
            this.btnThe.TabIndex = 2;
            this.btnThe.Text = "Thẻ ";
            this.btnThe.UseVisualStyleBackColor = false;
            // 
            // btnTienmat
            // 
            this.btnTienmat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTienmat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienmat.Location = new System.Drawing.Point(192, 40);
            this.btnTienmat.Name = "btnTienmat";
            this.btnTienmat.Size = new System.Drawing.Size(93, 34);
            this.btnTienmat.TabIndex = 3;
            this.btnTienmat.Text = "Tiền Mặt ";
            this.btnTienmat.UseVisualStyleBackColor = false;
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.Location = new System.Drawing.Point(19, 14);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(85, 17);
            this.lbTongtien.TabIndex = 4;
            this.lbTongtien.Text = "Tổng Tiền: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1151, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 769);
            this.panel1.TabIndex = 9;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Pink;
            this.btnClearAll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(221, 14);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(93, 26);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "ClearAll";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // lbMon
            // 
            this.lbMon.AutoSize = true;
            this.lbMon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMon.Location = new System.Drawing.Point(19, 23);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(109, 17);
            this.lbMon.TabIndex = 11;
            this.lbMon.Text = "Món Đang Gọi:";
            // 
            // ln_mon
            // 
            this.ln_mon.AutoSize = true;
            this.ln_mon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_mon.Location = new System.Drawing.Point(33, 20);
            this.ln_mon.Name = "ln_mon";
            this.ln_mon.Size = new System.Drawing.Size(39, 18);
            this.ln_mon.TabIndex = 0;
            this.ln_mon.Text = "Món";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearAll);
            this.panel2.Controls.Add(this.lbMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 56);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThanhtoan);
            this.panel3.Controls.Add(this.lbTongtien);
            this.panel3.Controls.Add(this.btnTienmat);
            this.panel3.Controls.Add(this.btnThe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 636);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 133);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 580);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbSoLuong);
            this.panel5.Controls.Add(this.lbGia);
            this.panel5.Controls.Add(this.ln_mon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 59);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 521);
            this.panel6.TabIndex = 1;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(127, 20);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(37, 18);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Giá ";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(218, 20);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(81, 18);
            this.lbSoLuong.TabIndex = 1;
            this.lbSoLuong.Text = "Số Lượng ";
            // 
            // userkhachgoimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Name = "userkhachgoimon";
            this.Size = new System.Drawing.Size(1468, 769);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnThe;
        private System.Windows.Forms.Button btnTienmat;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lbMon;
        private System.Windows.Forms.Label ln_mon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbGia;
    }
}
