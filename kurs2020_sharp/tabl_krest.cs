﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kurs2020_sharp
{
    public partial class tabl_krest : Form
    {
        public tabl_krest()
        {
            InitializeComponent();
        }

        private void trud_butt_Click(object sender, EventArgs e)
        {
            Form tabnaim = new tabl_naim();
            tabnaim.ShowDialog();
            tabnaim.Controls.Clear();
        }
    }
}
