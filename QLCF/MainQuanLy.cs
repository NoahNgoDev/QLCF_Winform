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
        private int userControlCurrenly = 0;


        // GK-Gọi userControl 
        TongQuan userControl_TongQuan = new TongQuan();
        DoanhThu userControl_DoanhThu = new DoanhThu();

        public MainQuanLy()
        {
            InitializeComponent();
            //GK
            caiDatTriChoNameAvarta();
            //GK
            addUserControlForPanel(userControl_TongQuan);
        }




        // GK-đóng cửa sổ chương trình 
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // GK-thu nhỏ phóng to cửa sổ
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
        private void caiDatTriChoNameAvarta()
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





        // GK-Thêm usercontrol vào panel để hiển thị
        private void addUserControlForPanel(UserControl userControl)
        {
            //pnlForUserControl.Controls.Add(userControl_TongQuan);
            //pnlForUserControl.Controls.Add(userControl_DoanhThu);

            userControl.Dock = DockStyle.Fill;
            pnlForUserControl.Controls.Clear();
            pnlForUserControl.Controls.Add(userControl);
            userControl.BackColor = Color.White;
            //userControl.Location = new Point(157, 34);
            userControl.BringToFront();

        }





        // GK-chuyển đổi giữa các user control
        private void chuyenUserControl()
        {
            if (userControlCurrenly == 0)
            {
                userControl_TongQuan.Visible = true;
            }
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            userControlCurrenly = 0;
        }
        

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            userControlCurrenly = 1;
        }
    }
}
