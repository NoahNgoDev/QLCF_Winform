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

                User_SanPham sp = new User_SanPham();
                sp.Margin = new Padding(2);
                sp.BackColor = System.Drawing.Color.FromArgb(i * 3, 0, 0);
                sp.Size = new System.Drawing.Size(363, 135);

                
                flowLayoutPanel_Contain_SanPham.Controls.Add(sp);
            }

            for (int i = 0; i < 10; i++)
            {
                // trong mỗi đối tượng của layout sản phẩm sẽ có 1 tag ví dụ: trà chanh có tag là trà

                User_MonDuocChon mdc = new User_MonDuocChon();
                mdc.Margin = new Padding(1);
                mdc.BackColor = System.Drawing.Color.FromArgb(i * 3, 214, 0);
                mdc.Size = new System.Drawing.Size(385, 60);


                flowLayoutPanel_MonSelect.Controls.Add(mdc);
            }
        }


    }
}
