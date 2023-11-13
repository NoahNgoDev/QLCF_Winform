using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF.NhanVienForm.user_SanPham
{
    public partial class User_MonDuocChon : UserControl
    {
        private int SoluongXDonGia;
        private int soluong = 1;
        private int tam = 0;


        public User_MonDuocChon()
        {
            InitializeComponent();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            soluong += 1;
            lbSoLuong.Text = soluong.ToString();



        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (soluong > 1)
            {
                //đổi màu khi click
                btnGiam.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 125, 157);
                //đổi màu khi hover
                btnGiam.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 242, 253);
                soluong -= 1;
            }
            else
            {
                btnGiam.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 227, 200);
                btnGiam.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 227, 200);
            }

            lbSoLuong.Text = soluong.ToString();
        }



        public int soluongXDonGiaPRO
        {
            get { return this.SoluongXDonGia; }
            set { this.SoluongXDonGia = value; }
        }



        private void lbSoLuong_TextChanged(object sender, EventArgs e)
        {
            int temp_SoluongXDonGia = int.Parse(lbSoLuong.Text) * int.Parse(lbDonGia.Text); ;
            //Console.WriteLine(temp_SoluongXDonGia);
            
        }

        

        public int LaySoLuongXDonGia()
        {
            soluongXDonGiaPRO = soluong * int.Parse(lbDonGia.Text);
            return soluongXDonGiaPRO;
        }
    }
}
