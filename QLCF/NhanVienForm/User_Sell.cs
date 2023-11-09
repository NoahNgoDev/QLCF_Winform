using QLCF.NhanVienForm.user_SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF.NhanVienForm
{
    public partial class User_Sell : UserControl
    {
        User_SanPham sp = new User_SanPham();


        public User_Sell()
        {
            InitializeComponent();
            
        }

        private void User_Sell_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                // trong mỗi đối tượng của layout sản phẩm sẽ có 1 tag ví dụ: trà chanh có tag là trà

                sp = new User_SanPham
                {
                    Margin = new Padding(2),
                    BackColor = System.Drawing.Color.FromArgb(i * 3, 0, 0),
                    Size = new System.Drawing.Size(363, 135)
                };


                flowLayoutPanel_Contain_SanPham.Controls.Add(sp);
            }

            for (int i = 0; i < 10; i++)
            {
                // trong mỗi đối tượng của layout sản phẩm sẽ có 1 tag ví dụ: trà chanh có tag là trà

                User_MonDuocChon mdc = new User_MonDuocChon();
                mdc.Margin = new Padding(1);
                mdc.BackColor = System.Drawing.Color.FromArgb(i+100 + 30, 214, 0);
                mdc.Size = new System.Drawing.Size(385, 60);


                flowLayoutPanel_MonSelect.Controls.Add(mdc);
            }


           
        }


        public void responsive(int newWidthForm)
        {
            if (newWidthForm == 1920)
            {
                //flowLayoutPnl2.Size = new Size(1700, 156);

                pnlContain_ThanhToan.Size = new Size(410+100, 1080);


            }
            else //if (newWidthForm == 1395)
            {
                //flowLayoutPnl2.Size = new Size(1395, 143);

                pnlContain_ThanhToan.Size = new Size(410, 733);
                
            }
        }

       
    }
}
