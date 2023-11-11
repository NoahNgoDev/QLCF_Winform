using QLCF.NhanVienForm.user_SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLCF.NhanVienForm
{
    public partial class User_Sell : UserControl
    {
        
        
        private User_MonDuocChon mdc = new User_MonDuocChon();
        private List<User_SanPham> user_SanPhamList;
        public List<User_MonDuocChon> user_MonDuocChonList;

        

        public User_Sell()
        {
            InitializeComponent();
            
        }



        int a = 0;
        private int count = 0;
        public string nameSP_Selected = "";

        private void User_Sell_Load(object sender, EventArgs e)
        {
            //int giatienmoisanpham = 0;
            user_SanPhamList = new List<User_SanPham>();
            for (int i = 1; i <= 20; i++)
            {
                // trong mỗi đối tượng của layout sản phẩm sẽ có 1 tag ví dụ: trà chanh có tag là trà
                if (i % 2 == 0)
                {
                   
                    User_SanPham sp = new User_SanPham()
                    {
                        Margin = new Padding(5, 5, 0, 0),
                        BackColor = System.Drawing.Color.FromArgb(147, 177, 166),
                        Size = new System.Drawing.Size(363 - 5, 135)

                    };

                    flowLayoutPanel_Contain_SanPham.Controls.Add(sp);
                }
                else
                {
                    User_SanPham sp1 = new User_SanPham();

                    sp1.lbNameSP.Text = "222";
                    sp1.Margin = new Padding(5, 5, 0, 0);
                    sp1.BackColor = System.Drawing.Color.FromArgb(10, 111, 29);
                    sp1.Size = new System.Drawing.Size(363 - 5, 135);
                    flowLayoutPanel_Contain_SanPham.Controls.Add(sp1);

                }
                
            }

            lbSoTienCanThanhToan.Text = a.ToString();

            lbTongSoLuong.Text = count.ToString();

            
            
        }

        public void responsive(int newWidthForm)
        {

            //count = flowLayoutPanel_MonSelect.Controls.Count;
            if (newWidthForm == 1920)
            {
                //flowLayoutPnl2.Size = new Size(1700, 156);

                pnlContain_ThanhToan.Size = new Size(410 + 170, 1080);

                for (int i = 0; i < count; i++)
                {
                    user_MonDuocChonList[i].Size = new Size(385 + 170, 60);
                }

            }
            else //if (newWidthForm == 1395)
            {
                //flowLayoutPnl2.Size = new Size(1395, 143);

                pnlContain_ThanhToan.Size = new Size(410, 733);

                for (int i = 0; i < count; i++)
                {
                    if (user_MonDuocChonList != null)
                    {
                        user_MonDuocChonList[i].Size = new Size(385, 60);
                    }

                    
                }
            }
        }






        private void flowLayoutPanel_MonSelect_ControlAdded(object sender, ControlEventArgs e)
        {
            count = flowLayoutPanel_MonSelect.Controls.Count;
            

            foreach (Control control in flowLayoutPanel_MonSelect.Controls)
            {
                if (nameSP_Selected == control.Name)
                {
                    flowLayoutPanel_MonSelect.Controls.RemoveAt(count);
                    mdc.lbSoLuong.Text = (int.Parse(mdc.lbSoLuong.Text) + 1).ToString();
                }
            }

            lbTongSoLuong.Text = count.ToString();
        }

        private void flowLayoutPanel_MonSelect_ControlRemoved(object sender, ControlEventArgs e)
        {
            count = flowLayoutPanel_MonSelect.Controls.Count;
            lbTongSoLuong.Text = count.ToString();
        }





        private void btnClearAll_ItemSelect_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_MonSelect.Controls.Clear();
        }
    }
}
