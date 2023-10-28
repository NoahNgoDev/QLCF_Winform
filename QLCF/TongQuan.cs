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

        private Timer timer;

        public TongQuan()
        {
            InitializeComponent();
            //Gk
            KhoiTaoNgayThangHienTai();
            //GK
            dieuChinhKichThuoc4BoxPnl2();
            
        }

        private void TongQuan_Load(object sender, EventArgs e)
        {
            timer.Start();
        }


        // GK - lấy ngày giờ hiện tại
        private void KhoiTaoNgayThangHienTai()
        {
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string timeText = currentTime.ToString("HH:mm:ss");
            string dateText = currentTime.ToString("dd/MM/yyyy");

            txtNgayThangHienTai.Text = timeText + "  " + dateText;
        }


        public void dieuChinhKichThuoc4BoxPnl2()
        {
            Size userControlSize = this.Size;
            userControlWidth = userControlSize.Width;
            userControlHeight = userControlSize.Height;


            //MessageBox.Show(userControlWidth + " - " + userControlHeight);

            if (userControlWidth == 1700)
            {
                flowLayoutPnl2.Size = new Size(1395, 156);

                pnlDatcho.Size = new Size(403, 150);
                pnlKhachHang.Size = new Size(403, 150);
                pnlDonHang.Size = new Size(403, 150);
                pnlDoanhThu.Size = new Size(403, 150);

            }else if (userControlWidth == 1395)
            {
                flowLayoutPnl2.Size = new Size(1395, 143);

                pnlDatcho.Size = new Size(328, 137);
                pnlKhachHang.Size = new Size(328, 137);
                pnlDonHang.Size = new Size(328, 137);
                pnlDoanhThu.Size = new Size(328, 137);
            }
        }

        
    }
}
