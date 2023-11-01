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


namespace QLCF
{
    public partial class TongQuan : UserControl
    {
        private int userControlWidth;
        private int userControlHeight;

        private Timer timer = new Timer();
        private List<Panel> panelList;


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
            btnNgayThongke.PerformClick();
            //bieudo();

            ThemDuLieuVaoDataGridView();

            AddItemPanelDanhGia();
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
        public void dieuChinhKichThuoc3BoxPnl3()
        {
            Size userControlSize = this.Size;
            userControlWidth = userControlSize.Width;
            userControlHeight = userControlSize.Height;
            //MessageBox.Show(userControlWidth +"--"+ userControlHeight);

            if (userControlWidth == 1700)
            {
                
                flowLayoutPnl3.Size = new Size(1700, 790);

                pnlBieuDoAndDanhGia.Size = new Size(891 + 302, 730);
                panelBieuDo.Size = new Size(891, 335+100);
                chart1.Size = new Size(891, 304 + 100);
                pnlDanhGia.Size = new Size(891, 141+146);
                pnlMonBanChay.Size = new Size(470, 482+248);

                

                for (int i = 0; i < 10; i++)
                {
                    panelList[i].Size = new Size(429+150, 135*2);


                    // Lấy danh sách các controls trong panel (chẳng hạn panel1 là tên của Panel của bạn)
                    Control.ControlCollection controlCollection = panelList[i].Controls;

                    // Lặp qua danh sách controls và làm việc với từng control
                    foreach (Control control in controlCollection)
                    {
                        // Thực hiện các thao tác cần thiết với control ở đây
                        // Ví dụ: 
                        if (control is Label)
                        {
                            int widthItemDanhGia = control.Size.Width;
                            int heightItemDanhGia = control.Size.Height;
                              
                            Label NameUser = (Label)control;
                            // Thực hiện các tác vụ với Label
                            NameUser.Font = new Font("Arial", 15, FontStyle.Regular);
                        }
                    }
                }
            }
            else if (userControlWidth == 1395)
            {
                
                flowLayoutPnl3.Size = new Size(1395, 490);

                pnlBieuDoAndDanhGia.Size = new Size(891, 482);
                panelBieuDo.Size = new Size(891, 335);
                chart1.Size = new Size(891, 304);
                pnlDanhGia.Size = new Size(891, 141);
                pnlMonBanChay.Size = new Size(470, 482);

                for (int i = 0; i < 10; i++)
                {
                    panelList[i].Size = new Size(429, 135);


                    // Lấy danh sách các controls trong panel (chẳng hạn panel1 là tên của Panel của bạn)
                    Control.ControlCollection controlCollection = panelList[i].Controls;


                    // Lặp qua danh sách controls và làm việc với từng control
                    foreach (Control control in controlCollection)
                    {
                        // Thực hiện các thao tác cần thiết với control ở đây
                        // Ví dụ: 
                        if (control is Label)
                        {
                            int widthItemDanhGia = control.Size.Width;
                            int heightItemDanhGia = control.Size.Height;

                            Label NameUser = (Label)control;
                            // Thực hiện các tác vụ với Label
                            NameUser.Font = new Font("Arial", 11, FontStyle.Regular);
                            
                        }
                    }
                }
            }

        }
        //GK - biểu đồ barchart
        // thêm thư viện System.Windows.Forms.DataVisualization vào dự án của mình.
        // Để làm điều này, cần thực hiện các bước sau:
        // a.Nhấp chuột phải vào tên dự án trong Solution Explorer.
        // b.Chọn "Add" và sau đó chọn "Reference."
        // c.Trong cửa sổ Reference Manager, tìm và chọn "System.Windows.Forms.DataVisualization."
        // d.Nhấp vào nút "OK" để thêm thư viện này vào dự án
               

        //private List<UserInfo> userList = new List<UserInfo>();
        public class Person
        {
            public int MaSo { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
        }
        private void ThemDuLieuVaoDataGridView()//(int maSo, string hoTen, string soDienThoai)
        {
            dataGridView_MonBanChay.ScrollBars = ScrollBars.Vertical; // Ẩn chỉ thanh cuộn ngan

            // Đặt tên cột <Biến tên cột>,<name cột>
            dataGridView_MonBanChay.Columns.Add("maMon", "Mã món");
            dataGridView_MonBanChay.Columns.Add("tenMon", "Tên món");
            dataGridView_MonBanChay.Columns.Add("slBan", "Số lượng bán");


            // Điều chỉnh độ rộng của cột 1 thành 100 pixels    
            dataGridView_MonBanChay.Columns[0].Width = 30;

            // Điều chỉnh độ rộng của cột 2 thành 150 pixels
            dataGridView_MonBanChay.Columns[1].Width = 150;
            // Điều chỉnh độ rộng của cột 3 thành 150 pixels
            dataGridView_MonBanChay.Columns[2].Width = 150;

            dataGridView_MonBanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


            // Tạo một danh sách dữ liệu (ví dụ: List of objects)
            List<Person> people = new List<Person>
            {
                new Person { MaSo = 1, Name = "John", Age = "3232" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
                new Person { MaSo = 2, Name = "Alice", Age = "323g2" },
                new Person { MaSo = 13, Name = "Bob", Age = "323d2g" },
            };

            // Thêm dữ liệu vào DataGridView bằng vòng lặp
            foreach (var person in people)
            {
                dataGridView_MonBanChay.Rows.Add(person.MaSo,person.Name, person.Age);
            }


            dataGridView_MonBanChay.RowTemplate.Height = 90; // Đặt độ cao dòng thành 30 pixel
            dataGridView_MonBanChay.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Đặt font cho toàn bộ DataGridView

        }
        




        public void bieudo(String newSeries)
        {
            // Xóa dữ liệu cũ (nếu có)
            chart1.Series.Clear();

            // Thêm dữ liệu vào biểu đồ
            chart1.Series.Add(newSeries);

            // Cài đặt biểu đồ cột
            chart1.Series[newSeries].ChartType = SeriesChartType.Column; 

            // hiện số trên mỗi cột
            chart1.Series[newSeries].IsValueShownAsLabel = true;

            // Vô hiệu hóa vị trí tự động chú thích
            chart1.Legends["Khách hàng"].Position.Auto = false; 
            
            //Đặt tên cho trục
            chart1.ChartAreas["Khách hàng"].AxisX.Title = "Ngày"; // Đặt tên trục X
            chart1.ChartAreas["Khách hàng"].AxisY.Title = "Số lượng khách"; // Đặt tên trục Y


        }

        private void btnNgayThongke_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ (nếu có)
            chart1.Series.Clear();

            // Tạo dữ liệu mẫu cho ngày
            string[] days = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
            int[] customers = { 10, 20, 15, 133, 12, 90, 10, 20, 133, 30, 12, 90, 34, 133, 15, 30, 12, 90, 133, 20, 15, 30, 12, 133, 34, 12, 90, 34, 133, 34, 65 };

            // Thêm dữ liệu vào biểu đồ
            //chart1.Series.Add("Khách hàng trong ngày");

            bieudo("Khách hàng trong ngày");

            chart1.Series["Khách hàng trong ngày"].Points.DataBindXY(days, customers);

            lbTitleThongKe.Text = "Thống kê lượng khách hàng - trong ngày";
        }

        private void btnTuanThongke_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ (nếu có)
            chart1.Series.Clear();

            // Tạo dữ liệu mẫu cho ngày
            string[] days = { "tuần 1", "tuần 2", "tuần 3", "tuần 4" };
            int[] customers = { 10, 34, 54, 12};

            // Thêm dữ liệu vào biểu đồ
            //chart1.Series.Add("Khách hàng trong ngày");

            bieudo("Khách hàng trong Tuần");

            chart1.Series["Khách hàng trong Tuần"].Points.DataBindXY(days, customers);

            lbTitleThongKe.Text = "Thống kê lượng khách hàng - trong tuần";
        }

        private void btnThangThongke_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ (nếu có)
            chart1.Series.Clear();

            // Tạo dữ liệu mẫu cho ngày
            string[] days = { "tháng 1", "tháng 2", "tháng 3", "tháng 4", "tháng 5", "tháng 6", "tháng 7", "tháng 8", "tháng 9", "tháng 10", "tháng 11", "tháng 12" };
            int[] customers = { 10, 34, 54, 12, 64, 10, 34, 54, 12, 64, 12, 64 };

            // Thêm dữ liệu vào biểu đồ
            //chart1.Series.Add("Khách hàng trong ngày");

            bieudo("Khách hàng trong Tháng");

            chart1.Series["Khách hàng trong Tháng"].Points.DataBindXY(days, customers);

            lbTitleThongKe.Text = "Thống kê lượng khách hàng - trong tháng";
        }

        private void AddItemPanelDanhGia()
        {
            // Tạo danh sách Panel và thêm vào FlowLayoutPanel
            panelList = new List<Panel>();
            for (int i = 0; i < 10; i++)
            {
                // xem chi tiết
                Label label11 = new Label();
                label11.AutoSize = true;
                label11.Text = "tên người dùng";
                label11.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
                label11.Dock = DockStyle.Top;

                Label label22 = new Label();
                label22.Text = "\n\nnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dung";
                label22.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
                label22.Dock = DockStyle.Fill;
                label22.AutoSize = false;

                Panel panel = new Panel();

                panel.BackColor = System.Drawing.Color.FromArgb(i * 25, 0, 0);
                panel.Size = new System.Drawing.Size(429, 135);

                label11.Font = new Font("Arial", 11, FontStyle.Regular);
                label22.Font = new Font("Arial", 11, FontStyle.Regular);



                panel.Controls.Add(label11);
                panel.Controls.Add(label22);

                panelList.Add(panel);
                flowLayoutPnlDanhGia.Controls.Add(panel);
            }


            // xem chi tiết
            Button btnXemChiTietDanhGia = new Button();
            btnXemChiTietDanhGia.Text = "Xem chi tiết đánh giá";
            btnXemChiTietDanhGia.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
            btnXemChiTietDanhGia.Dock = DockStyle.Fill;
            btnXemChiTietDanhGia.AutoSize = true;
            btnXemChiTietDanhGia.Size = new System.Drawing.Size(98, 49);

            Panel panel1 = new Panel();
            
            panel1.BackColor = System.Drawing.Color.FromArgb(122, 0, 0);
            panel1.Size = new System.Drawing.Size(100, 50);

            panel1.Controls.Add(btnXemChiTietDanhGia);

            panelList.Add(panel1);
            flowLayoutPnlDanhGia.Controls.Add(panel1);
        }
    }
}

