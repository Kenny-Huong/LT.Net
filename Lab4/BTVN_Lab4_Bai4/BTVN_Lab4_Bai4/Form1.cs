﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Lab4_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)) {
                e.Handled = true; return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var number = txtN.Text;
            listNumber.Items.Add(number);
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if()
        }
    }
}
