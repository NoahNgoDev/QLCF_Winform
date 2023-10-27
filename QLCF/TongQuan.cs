using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCF
{
    public partial class TongQuan : UserControl
    {
        private int userControlWidth;
        private int userControlHeight;

        public TongQuan()
        {
            InitializeComponent();
            //Gk
            NgayThangHienTai();

            dieuChinhKichThuoc4BoxPnl2();
            
        }


        // GK - lấy ngày giờ hiện tại
        private void NgayThangHienTai()
        {
            // Lấy ngày tháng hiện tại
            DateTime currentDate = DateTime.Now;

            // Định dạng ngày tháng theo yêu cầu
            string formattedDate = currentDate.ToString("HH:mm    dd-MM-yyyy");

            // Hiển thị ngày tháng đã định dạng trong một TextBox
            txtNgayThangHienTai.Text = formattedDate;
        }

        public void dieuChinhKichThuoc4BoxPnl2()
        {
            Size userControlSize = this.Size;
            userControlWidth = userControlSize.Width;
            userControlHeight = userControlSize.Height;


            //MessageBox.Show(userControlWidth + " - " + userControlHeight);

            if (userControlWidth == 1700)
            {
                flowLayoutPnl2.Size = new Size(1395, 550);

                pnlDatcho.Size = new Size(403, 200);
                pnlKhachHang.Size = new Size(403, 200);
                pnlDonHang.Size = new Size(403, 200);
                pnlDoanhThu.Size = new Size(403, 200);

            }else if (userControlWidth == 1395)
            {
                flowLayoutPnl2.Size = new Size(1395, 137);

                pnlDatcho.Size = new Size(328, 137);
                pnlKhachHang.Size = new Size(328, 137);
                pnlDonHang.Size = new Size(328, 137);
                pnlDoanhThu.Size = new Size(328, 137);
            }
        }

        
    }
}
