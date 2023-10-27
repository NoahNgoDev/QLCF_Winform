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



        public MainQuanLy()
        {
            InitializeComponent();
            caiDatTriChoNameAvarta();


        }




        // đóng cửa sổ chương trình
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // thu nhỏ phóng to cửa sổ
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



        // thu cửa sổ 
        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        // di chuyển cửa sổ (form)
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




        // di chuyển cửa sổ (btn move)
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

        


        // cài đặt vị trí cho lable dịch qua trái
        private void caiDatTriChoNameAvarta()
        {
            // Đặt vị trí cho chữ
            int rightlbNameAvarta = lbNameAvarta.Width;
            lbNameAvarta.Text = "nguyên van tuầna";
            int rightlbNameAvartaNew = lbNameAvarta.Width;
            //MessageBox.Show(rightlbNameAvartaNew + "  " + rightlbNameAvarta);
            int rightXnew = rightlbNameAvartaNew - rightlbNameAvarta;
            int rightXX = lbNameAvarta.Location.X - rightXnew;
            int rightY = lbNameAvarta.Location.Y;
            lbNameAvarta.Location = new Point(rightXX, rightY);

            int right_lbchucvu = lbchucvu.Width;
            int right_lbchucvuNew = lbchucvu.Width;
            int right_lbchucvu_ = right_lbchucvuNew - right_lbchucvu;
            int right_lbchucvu__ = lbchucvu.Location.X - right_lbchucvu_;
            int right_lbchucvu_Y = lbchucvu.Location.Y;
            lbNameAvarta.Location = new Point(right_lbchucvu__, right_lbchucvu_Y);
        }




        //chuyển đổi giữa các user control
    }
}
