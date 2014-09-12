using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using turtle.Model;
using turtle.Utils;
using System.Xml;

namespace turtle.Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void configFolioAcept_button_Click(object sender, EventArgs e)
        {
            if (ValidateConcept())
            {
                writeChange(); 
            }
        }

        private bool ValidateConcept()
        {
            var controlsValidations = new Dictionary<Control, bool>();
            controlsValidations.Add(serietextBox, Validator.IsAlphabetic(serietextBox.Text,true));
            controlsValidations.Add(initialFoliotextBox, Validator.IsDecimal(initialFoliotextBox.Text, true));
            controlsValidations.Add(finalFoliotextBox, Validator.IsDecimal(finalFoliotextBox.Text, true));
            //controlsValidations.Add(currentFoliotextBox, Validator.IsAlphanumeric(currentFoliotextBox.Text, true));
            //controlsValidations.Add(ivaRatecomboBox1, Validator.IsDecimal(ivaRatecomboBox1.Text, false));
            return Validator.Validate(controlsValidations);
        }


        private bool writeChange()
        {
           
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"C:\Users\Nestor\Documents\Visual Studio 2008\Projects\turtle\Forms\Config.xml");
                XmlNode node;
                node = xmlDoc.SelectSingleNode("Serie");
                node.InnerText = serietextBox.Text;

                node = xmlDoc.SelectSingleNode("FolioInicial");
                node.InnerText = initialFoliotextBox.Text;

                node = xmlDoc.SelectSingleNode("Foliofinal");
                node.InnerText = finalFoliotextBox.Text;

                return true;
              
            
        }
       
    }
}