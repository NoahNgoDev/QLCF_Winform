using QLCF.NhanVienForm;
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
    public partial class FormSellNhanVien : Form
    {
        //biến dùng để xác định cho việc di chuyển form
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;
        private Boolean enable = false;
        //private int userControlCurrenly = 0;
        private Button currentButton;
        private int newWidthForm = 0;

        User_DatBan userControl_DatBan = new User_DatBan();
        User_Donban userControl_Donban = new User_Donban();
        User_Sell userControl_Sell = new User_Sell();
        User_Setting userControl_Setting = new User_Setting();

        //gọi form đăng nhập
        DangNhap Form_DangNhap = new DangNhap();

        public FormSellNhanVien()
        {
            InitializeComponent();
            
        }


        private void FormSellNhanVien_Load(object sender, EventArgs e)
        {
            addUserControlForPanel(userControl_Sell);
            this.SizeChanged += FormSellNhanVien_SizeChanged;
            //formDangNhap();
        }



        //form đăng nhập
        public void formDangNhap()
        {
            // Hiển thị form đăng nhập và kiểm tra kết quả trả về...
            DialogResult result = Form_DangNhap.ShowDialog();
            // Kiểm tra kết quả trả về của form đăng nhập
            if (result == DialogResult.Yes) // Đăng nhập thành công
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









        // Thêm usercontrol vào panel để hiển thị
        private void addUserControlForPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainUserControl.Controls.Clear();
            pnlContainUserControl.Controls.Add(userControl);
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




        public void reponsive(int newWidthForm)
        {
            //pnlContain_ThanhToan
            userControl_Sell.responsive(newWidthForm);
        }

        private void FormSellNhanVien_SizeChanged(object sender, EventArgs e)
        {
            //lấy độ rộng của form mỗi khi thay đổi kích thức của form
            newWidthForm = this.Width;
            Console.WriteLine(newWidthForm.ToString());
            // Gọi phương thức Invalidate để vẽ lại giao diện
            //this.Invalidate();

            if (newWidthForm == 1920)
            {
                this.Size = new Size(1920, 1080);
                reponsive(newWidthForm);
            }
            else //if (newWidthForm == 1615)
            {
                this.Size = new Size(1387, 788);
                reponsive(newWidthForm);
            }
        }






        // GK-đóng cửa sổ chương trình 
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void FormSellNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            if (enable)
            {
                this.isDragging = true;
                this.mouseX = e.X;
                this.mouseY = e.Y;
            }
        }

        private void FormSellNhanVien_MouseMove(object sender, MouseEventArgs e)
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

        private void FormSellNhanVien_MouseUp(object sender, MouseEventArgs e)
        {
            if (enable)
                this.isDragging = false;
        }






        // GK-di chuyển cửa sổ (btn move)
        private void btnmove_MouseMown(object sender, MouseEventArgs e)
        {
            enable = true;
            FormSellNhanVien_MouseDown(sender, e);
            enable = false;
        }

        private void btnmove_MouseMove(object sender, MouseEventArgs e)
        {
            enable = true;
            FormSellNhanVien_MouseMove(sender, e);
            enable = false;
        }

        private void btnmove_MouseUp(object sender, MouseEventArgs e)
        {
            enable = true;
            FormSellNhanVien_MouseUp(sender, e);
        }





        // button usercontrol
        private void btnKhachGoiMon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_Sell);
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_DatBan);

        }

        private void btnDonBan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_Donban);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            addUserControlForPanel(userControl_Setting);
        }

        
    }
}
