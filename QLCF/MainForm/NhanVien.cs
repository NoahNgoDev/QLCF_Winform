using QLCF.MainForm;
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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        //respontive form
        public void responsive_NhanVien(int newWidthForm)
        {

            if (newWidthForm == 1920)
            {
                pnlReponsiveNhanVien.Size = new Size(1395+310, 71);
                pnlContainTableNhanVien.Size = new Size(1389 + 300, 589 + 305);
            }
            else if (newWidthForm == 1615)
            {
                pnlReponsiveNhanVien.Size = new Size(1395, 71);
                pnlContainTableNhanVien.Size = new Size(1389, 632);

            }

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            DK_NhanVien nv = new DK_NhanVien();
            nv.Show();
        }
    }
}
