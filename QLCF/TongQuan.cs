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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace QLCF
{
    public partial class TongQuan : UserControl
    {
        private int userControlWidth;
        private int userControlHeight;

        private Timer timer = new Timer();

        private int checkMax = 0;

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
            bieudo();

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
                checkMax = 1;
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
                            NameUser.AutoSize = false;
                            NameUser.Font = new Font("Arial", 15, FontStyle.Regular);




                            if (NameUser.Tag.ToString() == "unique1")
                            {
                                // Thực hiện các thao tác với control1
                                MessageBox.Show("8787899");
                            }
                            else if (NameUser.Tag.ToString() == "unique2")
                            {
                                // Thực hiện các thao tác với control2
                            }

                        }


                       

                    }
                        




                }




            }
            else if (userControlWidth == 1395)
            {
                checkMax = 0;
                flowLayoutPnl3.Size = new Size(1395, 490);

                pnlBieuDoAndDanhGia.Size = new Size(891, 482);
                panelBieuDo.Size = new Size(891, 335);
                chart1.Size = new Size(891, 304);
                pnlDanhGia.Size = new Size(891, 141);
                pnlMonBanChay.Size = new Size(470, 482);



            }

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



        //private List<UserInfo> userList = new List<UserInfo>();
        public class Person
        {
            public int MaSo { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
        }
        private void ThemDuLieuVaoDataGridView()//(int maSo, string hoTen, string soDienThoai)
        {
            //UserInfo user = new UserInfo
            //{
            //    MaSo = maSo,
            //    HoTen = hoTen,
            //    SoDienThoai = soDienThoai
            //};

            //userList.Add(user);


            //// Thêm dữ liệu vào DataGridView
            //dataGridView1.Rows.Add(user.MaSo, user.HoTen, user.SoDienThoai);

            dataGridView1.ScrollBars = ScrollBars.Vertical; // Ẩn chỉ thanh cuộn ngan



            // Đặt tên cột
            //dataGridView1.Columns.Add("Tên", "Tên");
            //dataGridView1.Columns.Add("Tuổi", "Tuổi");

            //dataGridView1.Rows.Add("MaSo", "HoTen", "SoDienThoai");


            //// Thêm dữ liệu vào DataGridView bằng vòng lặp
            //foreach (var person in userList)
            //{
            //    dataGridView1.Rows.Add(person.MaSo, person.HoTen, person.SoDienThoai);
            //}


            //DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            //column1.Name = "ColumnName1";
            //column1.HeaderText = "Mã số";

            //DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            //column2.Name = "ColumnName2";
            //column2.HeaderText = "họ và tên";

            //DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            //column3.Name = "ColumnName3";
            //column3.HeaderText = "hsodt";

            //dataGridView1.Columns.Add(column1);
            //dataGridView1.Columns.Add(column2);
            //dataGridView1.Columns.Add(column3);



            // Đặt tên cột <Biến tên cột>,<name cột>
            dataGridView1.Columns.Add("Ten", "Tên");
            dataGridView1.Columns.Add("Tuoi", "Tuổi");
            dataGridView1.Columns.Add("aga", "agr");


            // Điều chỉnh độ rộng của cột 1 thành 100 pixels    
            dataGridView1.Columns[0].Width = 100;

            // Điều chỉnh độ rộng của cột 2 thành 150 pixels
            dataGridView1.Columns[1].Width = 150;
            // Điều chỉnh độ rộng của cột 3 thành 150 pixels
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


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
                dataGridView1.Rows.Add(person.MaSo,person.Name, person.Age);
            }


            dataGridView1.RowTemplate.Height = 90; // Đặt độ cao dòng thành 30 pixel
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Đặt font cho toàn bộ DataGridView

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
                label22.Text = "\nnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dung";
                label22.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
                label22.Dock = DockStyle.Fill;

                Panel panel = new Panel();

                panel.BackColor = System.Drawing.Color.FromArgb(i * 25, 0, 0);
                panel.Size = new System.Drawing.Size(429, 135);

                label11.Tag = "label11unique1";
                label22.Tag = "label22unique2";



                panel.Controls.Add(label22);
                panel.Controls.Add(label11);

                panelList.Add(panel);
                flowLayoutPnlDanhGia.Controls.Add(panel);
            }


            // xem chi tiết
            Label label1 = new Label();
            label1.Text = "tên người dùng";
            label1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
            label1.Dock = DockStyle.Top;

            Label label2 = new Label();
            label2.Text = "nội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dungnội dung";
            label2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
            label2.Dock = DockStyle.Fill;

            Panel panel1 = new Panel();
            
            panel1.BackColor = System.Drawing.Color.FromArgb(122, 0, 0);
            panel1.Size = new System.Drawing.Size(429, 135);

            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);

            panelList.Add(panel1);
            flowLayoutPnlDanhGia.Controls.Add(panel1);
        }


    }
}

