﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLCF.NhanVienForm.user_SanPham
{
    public partial class User_SanPham : UserControl
    {

        private User_Sell user_Sell = new User_Sell();
        public event EventHandler User_SanPham_Clicked;

        public User_SanPham()
        {
            InitializeComponent();
            //pnlBoXSanPham.Click += pnlBoXSanPham_Click;
        }

        

        private void User_SanPham_Load(object sender, EventArgs e)
        {
            Image image = pictureBox_Mon.Image;

            // Lấy kích thước của PictureBox
            int width = pictureBox_Mon.Width;
            int height = pictureBox_Mon.Height;

            // Tạo một đối tượng ảnh mới với kích thước đã cho
            Image resizedImage = new Bitmap(image, width, height);

            // Gán ảnh đã thay đổi kích thước vào PictureBox
            pictureBox_Mon.Image = resizedImage;

        }



        private void objectClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Control clickedObject = (Control)sender;
                if (clickedObject is UserControl || clickedObject is Label || clickedObject is PictureBox)
                {
                    Console.WriteLine(clickedObject);
                   
                    User_MonDuocChon mdc = new User_MonDuocChon();
                    mdc.Margin = new Padding(1);
                    mdc.BackColor = System.Drawing.Color.FromArgb(178, 200, 186);
                    mdc.Size = new System.Drawing.Size(385, 60);
                    mdc.BorderStyle = BorderStyle.FixedSingle;

                    //clickedObject.Controls.Add(mdc);
                    user_Sell.user_MonDuocChonList.Add(mdc);
                    user_Sell.flowLayoutPanel_MonSelect.Controls.Add(mdc);
                }
            }
        }

        //--> click chọn đối tượng 

        

        private void pictureBox_Mon_Click(object sender, EventArgs e)
        {
            objectClick(sender, e);
            Console.WriteLine(lbNameSP.Text + " " + lbDonGia.Text);
        }

        private void lbNameSP_Click(object sender, EventArgs e)
        {
            objectClick(sender, e);
            Console.WriteLine(lbNameSP.Text + " " + lbDonGia.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            objectClick(sender, e);
            Console.WriteLine(lbNameSP.Text + " " + lbDonGia.Text);
        }

        private void pnlBoXSanPham_Click(object sender, EventArgs e)
        {
            Panel clickedObject = (Panel)sender;// đối tượng sender để xác định object đã được nhấp vào
            string Name = "";
            string NameGia = "";
            foreach (Control control in clickedObject.Controls)
            {

                if (control is Label && control.Name == "lbNameSP")
                {
                    Label labelName = (Label)control;
                    Name += labelName.Text + " ";
                }
                if (control is Label && control.Name == "lbDonGia")
                {
                    Label labelDonGia = (Label)control;
                    NameGia += labelDonGia.Text;
                }
            }


            // Thêm UserControlC vào FlowLayoutPanel của UserControlB
            User_Sell userControlB = this.ParentForm.Controls.Find("User_Sell", true).FirstOrDefault() as User_Sell;
            if (userControlB != null)
            {
                User_MonDuocChon mdc = new User_MonDuocChon();
                mdc.Margin = new Padding(1);
                mdc.BackColor = System.Drawing.Color.FromArgb(178, 200, 186);
                mdc.Size = new System.Drawing.Size(385, 60);
                mdc.BorderStyle = BorderStyle.FixedSingle;
                userControlB.flowLayoutPanel_MonSelect.Controls.Add(mdc);
            }
        }
    }
}
    