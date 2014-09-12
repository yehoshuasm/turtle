using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace turtle.Utils
{
    class DataWriter
    {
        public static void SaveXmlInvoice(string invoice)
        {
            var fileName = DateTime.Now.ToString("yyyymmdd");
            try
            {
                var stream = new StreamWriter(fileName);
                stream.Write(invoice);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar");
            }
        }
    }
}
