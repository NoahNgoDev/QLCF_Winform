using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLCF.NhanVienForm.user_SanPham
{
    public partial class User_SanPham : UserControl
    {


        private Color originalColor;


        public User_SanPham()
        {
            InitializeComponent();
        }

        private void User_SanPham_Load(object sender, EventArgs e)
        {
            Image image = pictureBox_Mon.Image;

            // Lấy kích thước của PictureBox
            int width = pictureBox_Mon.Width;
            int height = pictureBox_Mon.Height;

            // Tạo một đối tượng ảnh mới với kích thước đã cho
            Image resizedImage = new Bitmap(image, width, height);

            // Gán ảnh đã thay đổi kích thước vào PictureBox
            pictureBox_Mon.Image = resizedImage;

            User_SanPham user_SanPham = new User_SanPham(); 
            originalColor = user_SanPham.BackColor;
        }





        //--> click chọn đối tượng 

        private void User_SanPham_Click(object sender, EventArgs e)
        {
            User_SanPham clickedObject = (User_SanPham)sender;// đối tượng sender để xác định object đã được nhấp vào

            foreach (Control control in clickedObject.Controls)
            {
                string NameGia = "";
                string NameGia1 = "";
                if (control is Label && control.Name == "lbNameSP")
                {
                    Label labelName = (Label)control;
                    NameGia += labelName.Text + " ";

                }
                else if (control is Label && control.Name == "lbDonGia")
                {
                    Label labelDonGia = (Label)control;
                    NameGia1 += labelDonGia.Text;
                }
                 
                Console.WriteLine(NameGia+ NameGia1);
            }
        }

        private void pictureBox_Mon_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lbNameSP.Text);
        }

        private void lbNameSP_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lbNameSP.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lbNameSP.Text);
        }
    }
}
