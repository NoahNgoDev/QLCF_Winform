﻿using System;
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
    public partial class TaiKhoan : UserControl
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        //respontive form
        public void responsive_TaiKhoan(int newWidthForm)
        {

            if (newWidthForm == 1920)
            {
                pnlReponsiveTaiKhoan.Size = new Size(1395 + 310, 71);
                pnlContainTableTaiKhoan.Size = new Size(1389 + 300, 589 + 305);
            }
            else if (newWidthForm == 1615)
            {
                pnlReponsiveTaiKhoan.Size = new Size(1395, 71);
                pnlContainTableTaiKhoan.Size = new Size(1389, 632);

            }

        }
    }
}
