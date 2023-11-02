using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class DangNhap : Form
    {
        private MainQuanLy mainForm;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Kiểm tra nút mà người dùng đã nhấn.
            if (result == DialogResult.OK)
            {
                this.Close();
                Console.WriteLine("dnag nhap78709");
            }
            else if (result == DialogResult.Cancel)
            {
                //MessageBox.Show("Bạn đã nhấn nút Cancel.");
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "") || (this.txtUser.Text == ""))
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else if ((this.txtUser.Text == "11") && (this.txtPass.Text == "11"))
            {
                //Application.Exit();
                //MessageBox.Show("Đăng nhập thành công", "Thông báo");
                // Hiện Form 2 (MainForm)
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                this.txtUser.Clear();
                this.txtPass.Clear(); 
                this.txtUser.Focus();
            }

        }
        
    }
}
