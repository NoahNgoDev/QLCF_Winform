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
    public partial class User_SanPham : UserControl
    {
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
        }
    }
}
