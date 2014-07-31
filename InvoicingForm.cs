﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace turtle
{
    public partial class InvoicingForm : Form
    {
        public InvoicingForm()
        {
            InitializeComponent();
        }

        private void receiverInformationNextButton_Click(object sender, EventArgs e)
        {
            receiverInformationPanel.Hide();
            requiredInformationPanel.Show();
        }

        private void requiredInformationNextButton_Click(object sender, EventArgs e)
        {
            requiredInformationPanel.Hide();
            optionalInformationPanel.Show();
        }

        private void requiredInformationBackButton_Click(object sender, EventArgs e)
        {
            requiredInformationPanel.Hide();
            receiverInformationPanel.Show();
        }

        private void optionalInformationBackButton_Click(object sender, EventArgs e)
        {
            optionalInformationPanel.Hide();
            requiredInformationPanel.Show();
        }

        private void receiverInformatioCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}