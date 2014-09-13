using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace turtle.Forms
{
    public partial class OutstandingInvoices : Form
    {
        public OutstandingInvoices()
        {
            InitializeComponent();
        }

        private void OutstandingInvoices_Load(object sender, EventArgs e)
        {
            var a = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        }
    }
}