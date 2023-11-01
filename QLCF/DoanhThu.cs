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
    public partial class DoanhThu : UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
            
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            btnHomNay.PerformClick();
        }

        private void dateTimePicker_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_NgayBatDau.Format = DateTimePickerFormat.Short; // Chỉ hiển thị ngày không hiển thị giờ

            DateTime selectedDateNgayBatDau = dateTimePicker_NgayBatDau.Value; // Lấy giá trị đã chọn từ DateTimePicker

            lb_NgayBatDau.Text = selectedDateNgayBatDau.ToString("dd/MM/yyyy"); // điều chỉnh hiển thị 
        }

        private void dateTimePicker_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker_NgayKetThuc.Format = DateTimePickerFormat.Short; // Chỉ hiển thị ngày

            DateTime selectedDateNgayKetThuc = dateTimePicker_NgayKetThuc.Value; // Lấy giá trị đã chọn từ DateTimePicker

            lb_NgayKetThuc.Text = selectedDateNgayKetThuc.ToString("dd/MM/yyyy");

        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string dateText = currentTime.ToString("dd/MM/yyyy");

            lb_NgayBatDau.Text = dateText;
            lb_NgayKetThuc.Text = dateText;
        }

        
    }
}
