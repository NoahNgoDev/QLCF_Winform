using QLCF.NhanVienForm.user_SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF.NhanVienForm
{
    public partial class User_Sell : UserControl
    {
        private User_SanPham sp = new User_SanPham();
        private User_MonDuocChon mdc = new User_MonDuocChon();
        private List<User_SanPham> user_SanPhamList;
        public List<User_MonDuocChon> user_MonDuocChonList;



        public User_Sell()
        {
            InitializeComponent();
            
        }

        private void User_Sell_Load(object sender, EventArgs e)
        {
            user_SanPhamList = new List<User_SanPham>();

            for (int i = 0; i < 40; i++)
            {
                // trong mỗi đối tượng của layout sản phẩm sẽ có 1 tag ví dụ: trà chanh có tag là trà

                sp = new User_SanPham
                {
                    Margin = new Padding(5,5,0,0),
                    BackColor = System.Drawing.Color.FromArgb(147, 177, 166),
                    Size = new System.Drawing.Size(363-5, 135)
                    
                };


                flowLayoutPanel_Contain_SanPham.Controls.Add(sp);
            }


            user_MonDuocChonList = new List<User_MonDuocChon>();

            for (int i = 0; i < 17; i++)
            {
                // trong mỗi đối tượng của layout sản phẩm sẽ có 1 tag ví dụ: trà chanh có tag là trà

                User_MonDuocChon mdc = new User_MonDuocChon();
                mdc.Margin = new Padding(1);
                mdc.BackColor = System.Drawing.Color.FromArgb(178, 200, 186);
                mdc.Size = new System.Drawing.Size(385, 60);
                mdc.BorderStyle = BorderStyle.FixedSingle;

                user_MonDuocChonList.Add(mdc);

                flowLayoutPanel_MonSelect.Controls.Add(mdc);
            }

            Console.WriteLine(user_MonDuocChonList.Count());
        }


        public void responsive(int newWidthForm)
        {
           

            if (newWidthForm == 1920)
            {
                //flowLayoutPnl2.Size = new Size(1700, 156);

                pnlContain_ThanhToan.Size = new Size(410+100, 1080);

                for (int i = 0; i < 17; i++)
                {
                    user_MonDuocChonList[i].Size = new Size(385 + 100, 60);
                }
                
            }
            else //if (newWidthForm == 1395)
            {
                //flowLayoutPnl2.Size = new Size(1395, 143);

                pnlContain_ThanhToan.Size = new Size(410, 733);

                for (int i = 0; i < 17; i++)
                {
                    if (user_MonDuocChonList != null)
                    {
                        user_MonDuocChonList[i].Size = new Size(385, 60);
                    }
                    
                }
                //Console.WriteLine(user_MonDuocChonList.Count());
            }
        }

       
    }
}
