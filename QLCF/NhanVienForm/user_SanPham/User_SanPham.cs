using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLCF.NhanVienForm.user_SanPham
{
    public partial class User_SanPham : UserControl
    {
        //public int coutMonDuocChon = 0;
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
           
            Control clickedObject = (Control)sender;
            if (clickedObject is Panel || clickedObject is Label || clickedObject is PictureBox)
            {

                string Name = "";
                string NameGia = "";
                if (clickedObject is Panel)
                {
                    //lấy name và giá của từng sản phâm được chọn 
                    foreach (Control control in clickedObject.Controls)
                    {

                        if (control is Label && control.Name == "lbNameSP")
                        {
                            Label labelName = (Label)control;
                            Name += labelName.Text;
                        }
                        if (control is Label && control.Name == "lbDonGia")
                        {
                            Label labelDonGia = (Label)control;
                            NameGia += labelDonGia.Text;
                        }
                    }
                }
                else if (clickedObject is Label)
                {
                    Name = lbNameSP.Text;
                }
                else if (clickedObject is PictureBox)
                {
                    Name = lbNameSP.Text;
                }

                user_Sell.nameSP_Selected = Name;

                // Thêm user_Sanpham vào FlowLayoutPanel của user_Sell
                User_Sell userControlB = this.ParentForm.Controls.Find("User_Sell", true).FirstOrDefault() as User_Sell;
                
                
                
                if (userControlB != null)
                {
                    User_MonDuocChon mdc = new User_MonDuocChon();
                    mdc.Margin = new Padding(1);
                    mdc.BackColor = System.Drawing.Color.FromArgb(178, 200, 186 );
                    mdc.Size = new System.Drawing.Size(385, 60);
                    mdc.BorderStyle = BorderStyle.FixedSingle;
                    mdc.lbNameSP.Text = Name;
                    userControlB.flowLayoutPanel_MonSelect.Controls.Add(mdc);
                    Console.WriteLine("----"+mdc.lbNameSP.Text);
                }

            }
           
        }

        //--> click chọn đối tượng 

        private void pictureBox_Mon_Click(object sender, EventArgs e)
        {
            objectClick(sender, e);
        }

        private void lbNameSP_Click(object sender, EventArgs e)
        {
            objectClick(sender, e);
        }

        private void pnlBoXSanPham_Click(object sender, EventArgs e)
        {
            objectClick(sender, e);
        }

        private void lbDonGia_Click(object sender, EventArgs e)
        {
            objectClick(sender, e);
        }
    }
}
    