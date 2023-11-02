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
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        //respontive form
        public void responsive_HoaDon(int newWidthForm)
        {

            if (newWidthForm == 1920)
            {
                pnlReponsiveHoaDon.Size = new Size(1395 + 310, 105);
                pnlContainTableHoaDon.Size = new Size(1389 + 300, 589 + 305);
            }
            else if (newWidthForm == 1615)
            {
                pnlReponsiveHoaDon.Size = new Size(1395, 105);
                pnlContainTableHoaDon.Size = new Size(1389, 632);

            }

        }
    }
}
