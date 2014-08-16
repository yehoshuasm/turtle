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

namespace turtle.Forms.Invoicing
{
    public partial class ConceptsForm : Form
    {
        private List<Concept> Concepts = new List<Concept> { new Concept{Quantity = 2, Description = "Testing"} };

        public ConceptsForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateConcept())
            {
                Concepts.Add(new Concept
                {
                    Quantity = Convert.ToInt32(quantityTextBox.Text),
                    Unit = unitComboBox.SelectedText,
                    Description = descriptionTextBox.Text,
                    Price = Convert.ToDecimal(priceTextBox.Text),
                    Iva = Convert.ToDecimal(ivaTextBox.Text),
                    IvaRate = Convert.ToDecimal(ivaRateTextBox.Text)
                });
            }
        }

        #region Validations

        private bool ValidateConcept()
        {
            var controlsValidations = new Dictionary<Control, bool>();
            controlsValidations.Add(quantityTextBox, Validator.IsInteger(quantityTextBox.Text, false));
            controlsValidations.Add(priceTextBox, Validator.IsDecimal(priceTextBox.Text, false));
            controlsValidations.Add(ivaTextBox, Validator.IsDecimal(ivaTextBox.Text, true));
            controlsValidations.Add(ivaRateTextBox, Validator.IsDecimal(ivaRateTextBox.Text, true));
            return Validator.Validate(controlsValidations);
        }

        #endregion
    }
}