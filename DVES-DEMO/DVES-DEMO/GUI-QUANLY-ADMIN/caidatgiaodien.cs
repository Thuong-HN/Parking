﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVES_DEMO
{
    public partial class caidatgiaodien : Form
    {
        public caidatgiaodien() => InitializeComponent();

        private void Btnchongd_ql_Click(object sender, EventArgs e)
        {
            this.Hide();
            quanlyadmin to_quanlyadmin = new quanlyadmin();

            to_quanlyadmin.ShowDialog();
            this.Close();
        }
    }
}
