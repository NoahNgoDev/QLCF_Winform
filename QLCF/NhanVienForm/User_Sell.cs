using QLCF.NhanVienForm.user_SanPham;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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


        

        private void FlowLayoutPanelItemClick(object sender, EventArgs e)
        {
            // Lấy tên của đối tượng được click
            if (sender is Control clickedControl)
            {
                string itemName = clickedControl.Name;
                MessageBox.Show("Đã click vào item có tên: " + itemName);
            }
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

                    User_SanPham sp = new User_SanPham();


                    sp.Margin = new Padding(5, 5, 0, 0);
                    sp.BackColor = System.Drawing.Color.FromArgb(147, 177, 166);
                    sp.Size = new System.Drawing.Size(363 - 5, 135);
                    sp.pnlBoXSanPham.Tag = "11";
                    
                    ;
                    flowLayoutPanel_Contain_SanPham.Controls.Add(sp);
                }
                else
                {
                    User_SanPham sp1 = new User_SanPham();

                    sp1.lbNameSP.Text = "222";
                    sp1.Margin = new Padding(5, 5, 0, 0);
                    sp1.BackColor = System.Drawing.Color.FromArgb(10, 111, 29);
                    sp1.Size = new System.Drawing.Size(363 - 5, 135);
                    sp1.pnlBoXSanPham.Tag = "22";
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




        List<string> nameSPList = new List<string>();

        private void flowLayoutPanel_MonSelect_ControlAdded(object sender, ControlEventArgs e)
        {
            count = flowLayoutPanel_MonSelect.Controls.Count;
            lbTongSoLuong.Text = count.ToString();


            // Lấy đối tượng Label từ Item trong FlowLayoutPanel
            //Chúng ta sử dụng phương thức OfType<ItemType>() để lấy tất cả các đối tượng Item trong FlowLayoutPanel.
            //Sau đó, chúng ta sử dụng phương thức FirstOrDefault() để lấy Item đầu tiên trong danh sách.
            //Tiếp theo, chúng ta truy cập đến đối tượng Label trong Item bằng cách sử dụng phương thức OfType<Label>().
            Label label_SanPham = flowLayoutPanel_MonSelect.Controls// gọi các đối tượng trong flowLayoutPanel
                .OfType<User_MonDuocChon>() // các đối tượng có kiểu là user_MonDuocChon
                .FirstOrDefault()?.Controls // lấy đối tượng con đầu tiên trong user_MonDuocChon mà nó tìm thấy
                .OfType<Panel>() // đối tượng con trong đó là kiểu panel
                .LastOrDefault()?.Controls // lấy đối tượng cuối (bên trái). tương tự như stack. đối tượng nào thêm sau cùng sẽ lấy ra trước... nếu FirstrDefault thì sẽ lấy lbSoluong
                .OfType<Label>() // đó đó phải là Last. trong panel lấy đối tượng có kiểu là Label
                .FirstOrDefault();// lấy đôi tượng cần tìm thôi

            Label label_DonGia = flowLayoutPanel_MonSelect.Controls// gọi các đối tượng trong flowLayoutPanel
               .OfType<User_MonDuocChon>() // các đối tượng có kiểu là user_MonDuocChon
               .FirstOrDefault()?.Controls // lấy đối tượng con đầu tiên trong user_MonDuocChon mà nó tìm thấy
               .OfType<Label>() // đối tượng con trong đó là kiểu panel
               .LastOrDefault();// lấy đối tượng ==>đơn giá
                // đó đó phải là Last. trong panel lấy đối tượng có kiểu là Label
               // lấy đôi tượng cần tìm thôi

            Label label_SoLuong = flowLayoutPanel_MonSelect.Controls// gọi các đối tượng trong flowLayoutPanel
               .OfType<User_MonDuocChon>() // các đối tượng có kiểu là user_MonDuocChon
               .FirstOrDefault()?.Controls // lấy đối tượng con đầu tiên trong user_MonDuocChon mà nó tìm thấy
               .OfType<Panel>() // đối tượng con trong đó là kiểu panel
               .FirstOrDefault()?.Controls // lấy đối tượng   ==> số lượng
               .OfType<Label>() // đó đó phải là Last. trong panel lấy đối tượng có kiểu là Label
               .FirstOrDefault();// lấy đôi tượng cần tìm thôi


            Label label_TagPanel = flowLayoutPanel_Contain_SanPham.Controls// gọi các đối tượng trong flowLayoutPanel
               .OfType<User_SanPham>() // các đối tượng có kiểu là user_MonDuocChon
               .FirstOrDefault()?.Controls // lấy đối tượng con đầu tiên trong user_MonDuocChon mà nó tìm thấy
               .OfType<Panel>() // đối tượng con trong đó là kiểu panel
               .FirstOrDefault()?.Controls
               .OfType<Label>()
               .LastOrDefault();// lấy đôi tượng cần tìm thôi
            
            
            

            label_SoLuong.Text = 1.ToString();
            


            if (label_SanPham != null && label_DonGia != null && label_SoLuong != null && label_TagPanel != null)
            {
                string value = label_SanPham.Text;
                Console.WriteLine(label_SanPham.Name+ " " + label_SanPham.Text);
                //Console.WriteLine(label_DonGia.Name);
                //Console.WriteLine(label_SoLuong.Name);
                if (nameSPList.Count > 0)
                {
                    foreach (var name in nameSPList)
                    {

                        Console.WriteLine(name+" -- "+ label_SanPham.Text);
                        if (label_SanPham.Text == name)
                        {
                            removeItemSelected_FlowLayoutPanel();
                            label_SoLuong.Text = (int.Parse(label_SoLuong.Text) + 1).ToString();
                            //Console.WriteLine(name);
                        }
                        else
                        {
                            nameSPList.Add(label_SanPham.Text);
                            //Console.WriteLine("themm 22");
                        }
                    }
                }

                Console.WriteLine(" ten san pham licked: " + label_TagPanel.Text);
                nameSPList.Add(label_TagPanel.Text);

                //Console.WriteLine("nameSPList: " + label_SanPham.Text);
               // Console.WriteLine("nameSPList:1 " + nameSPList.Count);
            }
            else
            {
                Console.WriteLine("Null");
            }




        }

        private void flowLayoutPanel_MonSelect_ControlRemoved(object sender, ControlEventArgs e)
        {
            count = flowLayoutPanel_MonSelect.Controls.Count;
            lbTongSoLuong.Text = count.ToString();
        }




        private void removeItemSelected_FlowLayoutPanel()
        {
            // Kiểm tra xem có ít nhất một phần tử trong FlowLayoutPanel hay không
            if (flowLayoutPanel_MonSelect.Controls.Count > 1)
            {
                
                // Lấy chỉ số của phần tử cuối cùng
                int lastIndex =  count - 1;

                // Xóa phần tử cuối cùng
                flowLayoutPanel_MonSelect.Controls.RemoveAt(lastIndex);
                //Console.WriteLine("remove at a " + lastIndex);


                // Hoặc sử dụng phương thức Remove
                // flowLayoutPanel1.Controls.Remove(flowLayoutPanel1.Controls[lastIndex]);
            }
        }


        private void btnClearAll_ItemSelect_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_MonSelect.Controls.Clear();
        }
    }
}
