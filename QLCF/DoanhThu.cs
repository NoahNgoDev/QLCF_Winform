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

        private void dateTimePicker_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            // Ví dụ trong mã nguồn:
            dateTimePicker_NgayBatDau.Format = DateTimePickerFormat.Short; // Chỉ hiển thị ngày
            //dateTimePicker_NgayKetThuc.Format = DateTimePickerFormat.Time;  // Chỉ hiển thị giờ

            // Ví dụ trong mã nguồn:
            dateTimePicker_NgayBatDau.Format = DateTimePickerFormat.Short; // Chỉ hiển thị ngày
            //dateTimePicker_NgayKetThuc.Format = DateTimePickerFormat.Time;  // Chỉ hiển thị giờ

            DateTime selectedDateNgayBatDau = dateTimePicker_NgayBatDau.Value; // Lấy giá trị đã chọn từ DateTimePicker
            DateTime selectedDateNgayKetThuc = dateTimePicker_NgayKetThuc.Value; // Lấy giá trị đã chọn từ DateTimePicker


        }
    }
}
