using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            //GK
            bieudo();


            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(1, "John Doe", "123-456-7890");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
            ThemDuLieuVaoDataGridView(2, "Jane Smith", "987-654-3210");
        }


        // GK - lấy ngày giờ hiện tại
        private void KhoiTaoNgayThangHienTai()
        {
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
            timer.Tick += Timer_Tick;
        }

        //Gk - định dạng ngày và giờ khi hiển thị
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string timeText = currentTime.ToString("HH:mm:ss");
            string dateText = currentTime.ToString("dd/MM/yyyy");

            txtNgayThangHienTai.Text = timeText + "  " + dateText;
        }

        //Gk - điều chỉnh kích thức khi thu-phóng cửa sổ của flowLayoutPanel 2
        public void dieuChinhKichThuoc4BoxPnl2()
        {
            Size userControlSize = this.Size;
            userControlWidth = userControlSize.Width;
            userControlHeight = userControlSize.Height;


            //MessageBox.Show(userControlWidth + " - " + userControlHeight);

            if (userControlWidth == 1700)
            {
                flowLayoutPnl2.Size = new Size(1700, 156);

                pnlDatcho.Size = new Size(242+60, 150);
                pnlLuotDanhGia.Size = new Size(254 + 60, 150);
                pnlKhachHang.Size = new Size(262 + 60, 150);
                pnlDonHang.Size = new Size(240 + 60, 150);
                pnlDoanhThu.Size = new Size(336 + 65, 150);

            }else if (userControlWidth == 1395)
            {
                flowLayoutPnl2.Size = new Size(1395, 143);

                pnlDatcho.Size = new Size(234, 137);
                pnlLuotDanhGia.Size = new Size(254, 137);
                pnlKhachHang.Size = new Size(262, 137);
                pnlDonHang.Size = new Size(251, 137);
                pnlDoanhThu.Size = new Size(336, 137);
            }
        }

        //Gk - điều chỉnh kích thức khi thu-phóng cửa sổ của flowLayoutPanel 3
        public void tammm()
        {
            Size userControlSize = this.Size;
            userControlWidth = userControlSize.Width;
            userControlHeight = userControlSize.Height;
            //MessageBox.Show(userControlWidth +"--"+ userControlHeight);

            
        }


        //GK - biểu đồ barchart
        // thêm thư viện System.Windows.Forms.DataVisualization vào dự án của mình.
        // Để làm điều này, cần thực hiện các bước sau:
        // a.Nhấp chuột phải vào tên dự án trong Solution Explorer.
        // b.Chọn "Add" và sau đó chọn "Reference."
        // c.Trong cửa sổ Reference Manager, tìm và chọn "System.Windows.Forms.DataVisualization."
        // d.Nhấp vào nút "OK" để thêm thư viện này vào dự án

        public void bieudo()
        {
            // Lấy ra biểu đồ
            var chart = chart1;

            // Tạo một chuỗi các giá trị trên trục X
            string[] categories = { "ngày 1", "ngày 2", "ngày 3", "ngày 4", "ngày 5", "ngày 6", "ngày 7", "ngày 8", "ngày 9", "ngày 10", "ngày 11", "ngày 12", "ngày 13" };

            // Tạo một mảng chứa giá trị trên trục Y
            int[] values = { 10, 20, 15, 30, 125, 90, 10, 20, 15, 30, 125, 90, 34 };

            string NameSeries = "Khách hàng";

            // Tạo loạt dữ liệu (series) cho biểu đồ
            chart.Series["Series1"].Name = NameSeries;
            //chart.Series.Add("Data");
            chart.Series[NameSeries].ChartType = SeriesChartType.Column; // Loại biểu đồ cột
            // hiện số trên mỗi cột
            chart.Series[NameSeries].IsValueShownAsLabel = true;

            // Thêm dữ liệu vào biểu đồ bằng vòng lặp
            for (int i = 0; i < categories.Length; i++)
            {
                chart.Series[NameSeries].Points.AddXY(categories[i], values[i]);
            }


            chart1.Legends["Khách hàng"].Position.Auto = false; // Vô hiệu hóa vị trí tự động

            //Đặt tên cho trục
            chart1.ChartAreas["Khách hàng"].AxisX.Title = "Ngày"; // Đặt tên trục X
            chart1.ChartAreas["Khách hàng"].AxisY.Title = "Số lượng khách"; // Đặt tên trục Y


        }

        private List<UserInfo> userList = new List<UserInfo>();
        public class UserInfo
        {
            public int MaSo { get; set; }
            public string HoTen { get; set; }
            public string SoDienThoai { get; set; }
        }
        private void ThemDuLieuVaoDataGridView(int maSo, string hoTen, string soDienThoai)
        {
            UserInfo user = new UserInfo
            {
                MaSo = maSo,
                HoTen = hoTen,
                SoDienThoai = soDienThoai
            };

            userList.Add(user);

            // Thêm dữ liệu vào DataGridView
            dataGridView1.Rows.Add(user.MaSo, user.HoTen, user.SoDienThoai);

            dataGridView1.ScrollBars = ScrollBars.Vertical; // Ẩn chỉ thanh cuộn dọc


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
