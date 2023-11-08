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
    public partial class MainQuanLy : Form
    {
        //biến dùng để xác định cho việc di chuyển form
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;
        private Boolean enable = false;
        //private int userControlCurrenly = 0;
        private Button currentButton;

        // GK-Gọi userControl 
        TongQuan userControl_TongQuan = new TongQuan();
        DoanhThu userControl_DoanhThu = new DoanhThu();
        SanPham userControl_SanPham = new SanPham();
        NhanVien userControl_NhanVien = new NhanVien();
        KhachHang userControl_KhachHang = new KhachHang();
        HoaDon userControl_HoaDon = new HoaDon();
        TaiKhoan userControl_TaiKhoan = new TaiKhoan();
        CaiDat userControl_CaiDat = new CaiDat();
        private int newWidthForm;

        //gọi form đăng nhập
        DangNhap Form_DangNhap = new DangNhap();

        public MainQuanLy()
        {
            InitializeComponent();
            this.SizeChanged += MainQuanLy_SizeChanged;
            
        }

        private void MainQuanLy_Load(object sender, EventArgs e)
        {


            FormDangNhap();

            // cài đặt vị trí cho name avarta khi thay đổi độ dài
            caiDatViTriChoNameAvarta();

            // Kích hoạt Button có tên là button1 khi Form được tải
            btnTongQuan.PerformClick();

            //GK-Điều chỉnh tên cửa sổ theo cửa sổ đang mở
            TitleCurently.Text = btnTongQuan.Text;

            //GK-cửa sổ mặc định sẽ ở trang tổng quan
            addUserControlForPanel(userControl_TongQuan);

            
        }



        //form đăng nhập
        public void FormDangNhap()
        {
            // Hiển thị form đăng nhập và kiểm tra kết quả trả về...
            DialogResult result = Form_DangNhap.ShowDialog();
            // Kiểm tra kết quả trả về của form đăng nhập
            if (result == DialogResult.OK) // Đăng nhập thành công
            {
                // Hiển thị form MainQuanLy
                this.Show();
            }
            else
            {
                // Người dùng có thể đã hủy đăng nhập hoặc đăng nhập không thành công
                // Thực hiện xử lý tùy thuộc vào trường hợp cụ thể của bạn.
                this.Close(); // Đóng form MainQuanLy nếu không đăng nhập thành công.
            }
        }


        // kiểm tra reponsive 
        private void MainQuanLy_SizeChanged(object sender, EventArgs e)
        {
            //lấy độ rộng của form mỗi khi thay đổi kích thức của form
            newWidthForm = this.Width;
            //Console.WriteLine(newWidthForm.ToString());
            // Gọi phương thức Invalidate để vẽ lại giao diện
            //this.Invalidate();

            if (newWidthForm == 1920)
            {
                reponsive(newWidthForm);
            }
            else if (newWidthForm == 1615)
            {
                reponsive(newWidthForm);
            }
        }


        private void reponsive(int newWidthForm)
        {
            userControl_TongQuan.responsive_TongQuan(newWidthForm);
            userControl_DoanhThu.responsive_DoanhThu(newWidthForm);
            userControl_NhanVien.responsive_NhanVien(newWidthForm);
            userControl_SanPham.responsive_SanPham(newWidthForm);
            userControl_TaiKhoan.responsive_TaiKhoan(newWidthForm);
            userControl_KhachHang.responsive_KhachHang(newWidthForm);
            userControl_HoaDon.responsive_HoaDon(newWidthForm);
            userControl_CaiDat.responsive_CaiDat(newWidthForm);
        }


        // GK-đóng cửa sổ chương trình 
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // GK-thu nhỏ  và phóng to cửa sổ
        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Nếu cửa sổ đang ở trạng thái bình thường, thì chuyển sang trạng thái phóng to (maximized).
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                // Nếu cửa sổ đang ở trạng thái phóng to, thì chuyển về trạng thái bình thường.
                this.WindowState = FormWindowState.Normal;
            }
        }



        // GK-thu cửa sổ 
        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        // GK-di chuyển cửa sổ (form)
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (enable)
            {
                this.isDragging = true;
                this.mouseX = e.X;
                this.mouseY = e.Y;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (enable)
            {
                if (isDragging)
                {
                    int deltaX = e.X - this.mouseX;
                    int deltaY = e.Y - this.mouseY;
                    this.Location = new System.Drawing.Point(this.Location.X + deltaX, this.Location.Y + deltaY);
                }
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (enable)
                this.isDragging = false;
        }




        // GK-di chuyển cửa sổ (btn move)
        private void btnmove_MouseMown(object sender, MouseEventArgs e)
        {
            enable = true;
            MainForm_MouseDown(sender, e);
            enable = false;
        }

        private void btnmove_MouseMove(object sender, MouseEventArgs e)
        {
            enable = true;
            MainForm_MouseMove(sender, e);
            enable = false;
        }

        private void btnmove_MouseUp(object sender, MouseEventArgs e)
        {
            enable = true;
            MainForm_MouseUp(sender, e);
        }




        // GK-cài đặt vị trí cho lable dịch qua trái
        private void caiDatViTriChoNameAvarta()
        {
            // lấy độ rộng lúc cũ
            int rightlbNameAvarta = lbNameAvarta.Width;
            lbNameAvarta.Text = "Trần Lê Nguyễn Anh Kiệt";
            // lấy độ rộng lúc mới
            int rightlbNameAvartaNew = lbNameAvarta.Width;
            //MessageBox.Show(rightlbNameAvartaNew + "  " + rightlbNameAvarta);
            // độ rộng mới trừ độ rộng cũ = độ rộng khoản cách mới 
            int rightXnew = rightlbNameAvartaNew - rightlbNameAvarta;
            int rightXX = lbNameAvarta.Location.X - rightXnew;
            int rightY = lbNameAvarta.Location.Y;
            lbNameAvarta.Location = new Point(rightXX, rightY);

            int right_lbchucvu = lbchucvu.Width;
            lbchucvu.Text = "nhân viên - Part time";
            int right_lbchucvuNew = lbchucvu.Width;
            int right_lbchucvu_ = right_lbchucvuNew - right_lbchucvu;
            int right_lbchucvu__ = lbchucvu.Location.X - right_lbchucvu_;
            int right_lbchucvu_Y = lbchucvu.Location.Y;
            lbNameAvarta.Location = new Point(right_lbchucvu__, right_lbchucvu_Y);
        }





        // Thêm usercontrol vào panel để hiển thị
        private void addUserControlForPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlForUserControl.Controls.Clear();
            pnlForUserControl.Controls.Add(userControl);
            userControl.BackColor = Color.FromArgb(205, 245, 253);
            //userControl.Location = new Point(157, 34);
            userControl.BringToFront();

        }

        // đổi màu button cửa sổ đang bật
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 119, 179);
                    currentButton.ForeColor = Color.Honeydew;
                    TitleCurently.Font = new System.Drawing.Font("Tahoma", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    TitleCurently.Image = currentButton.Image;
                    TitleCurently.TextImageRelation = TextImageRelation.ImageBeforeText;
                    TitleCurently.Text = "  "+currentButton.Text;
                }
            }
        }
        
        // trả lại màu cũ khi button không còn được kích hoạt
        private void DisableButton()
        {
            foreach (Control previousBtn in LeftBarControll.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.BackColor = Color.DarkSeaGreen;
                }
            }
        }


        


        // button tổng quan đổi màu và kích hoạt hiện form user control khi được lick vào
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_TongQuan);
        }

        // button doanh thu đổi màu và kích hoạt hiện form user control khi được lick vào
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_DoanhThu);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_SanPham);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_NhanVien);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_KhachHang);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_HoaDon);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_TaiKhoan);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_CaiDat);
        }


        
    }
}
