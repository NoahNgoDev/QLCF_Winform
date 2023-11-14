using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF.MainForm
{
    public partial class DK_NhanVien : Form
    {
        public DK_NhanVien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            DK_NhanVien tt = new DK_NhanVien();
            if (txtMaNhanVien.Text == "" || txtHoTen.Text == "" || txtSDT.Text =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string str = "Mã Nhân Viên: " + txtMaNhanVien.Text + "\nTên Nhân Viên:" + txtHoTen.Text + "\nSố Điện Thoại:" + txtSDT.Text + "\nNgày Sinh:" + datNgaySinh.Value.ToShortDateString() + "\nGiới tính:" + (radNam.Checked ? "Nam" : "Nữ");
            MessageBox.Show(str, "Thông Báo");





        }
    }
}
