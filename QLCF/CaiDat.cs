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
    public partial class CaiDat : UserControl
    {
        public CaiDat()
        {
            InitializeComponent();
        }

        //respontive form
        public void responsive_CaiDat(int newWidthForm)
        {

            if (newWidthForm == 1920)
            {
                flowLayoutPanel_containTitle.Size = new Size(1389+310, 61);
                pnlReponsiveCaiDat.Size = new Size(670 + 310, 22);
                //pnlContainTableCaiDat.Size = new Size(1389 + 300, 589 + 305);
            }
            else if (newWidthForm == 1615)
            {
                flowLayoutPanel_containTitle.Size = new Size(1389, 61);
                pnlReponsiveCaiDat.Size = new Size(670, 22);
                //pnlContainTableCaiDat.Size = new Size(1389, 632);

            }
        }
    }
}
