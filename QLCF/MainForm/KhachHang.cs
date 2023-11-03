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
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        //respontive form
        public void responsive_KhachHang(int newWidthForm)
        {

            if (newWidthForm == 1920)
            {
                pnlReponsiveKhachHang.Size = new Size(1395 + 310, 114);
                pnlContainTableKhachHang.Size = new Size(1389 + 305, 589 + 265);
            }
            else if (newWidthForm == 1615)
            {
                pnlReponsiveKhachHang.Size = new Size(1395, 114);
                pnlContainTableKhachHang.Size = new Size(1389, 589);

            }

        }
    }
}
