﻿using System;
using System.Windows.Forms;

namespace turtle
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
                       
        }

        private void invoicingButton_Click(object sender, EventArgs e)
        {
            new InvoicingForm().Show();
        }
    }
}