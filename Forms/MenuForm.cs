using System;
using System.Windows.Forms;
using turtle.Forms;

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

        private void configButton_Click(object sender, EventArgs e)
        {
            new turtle.Forms.ConfigForm().Show();
        }

        private void outstandingInvoidesButton_Click(object sender, EventArgs e)
        {
            new OutstandingInvoices().Show();
        }
    }
}