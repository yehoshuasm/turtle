using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace turtle.Utils
{
    public static class DataWriter
    {
        public static void SaveXmlInvoice(string invoice)
        {
            try
            {
                var stream = new StreamWriter("test.xml");
                stream.WriteLine(invoice);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar factura");
            }
        }
    }
}