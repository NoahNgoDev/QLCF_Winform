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
            }
            else if (result == DialogResult.Cancel){}
        }

        private void btnDN_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text.Trim();
            string password = txtPass.Text; // Không cần Trim ở đây vì mật khẩu có thể có khoảng trắng

            // Kiểm tra tên đăng nhập và mật khẩu
            if (username.Equals("AA") && password.Equals("AA"))
            {
                FormSellNhanVien formA = new FormSellNhanVien();
                formA.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else if (username.Equals("BB") && password.Equals("BB"))
            {
                MainQuanLy formB = new MainQuanLy();
                formB.Show();
                this.Hide(); // Ẩn form đăng nhập
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
