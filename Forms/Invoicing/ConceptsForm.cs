using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using turtle.Model;
using turtle.Utils;

namespace turtle.Forms.Invoicing
{
    public partial class ConceptsForm : Form
    {
        private List<Concept> Concepts;

        public ConceptsForm(List<Concept> concepts)
        {
            InitializeComponent();
            Concepts = concepts;
            conceptsDataGrid.DataSource = Concepts.Select(c => new { c.Quantity, c.Description, c.Price }).ToList();
        }

        private void addConceptButton_Click(object sender, EventArgs e)
        {
            conceptsPanel.Hide();
            conceptPanel.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            conceptPanel.Hide();
            conceptsPanel.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateConcept())
            {
                Concepts.Add(new Concept
                {
                    Quantity = Convert.ToInt32(quantityTextBox.Text),
                    Description = descriptionTextBox.Text,
                    Price = Convert.ToDecimal(priceTextBox.Text),
                    //Iva = Convert.ToDecimal(ivaTextBox.Text),
                    //IvaRate = Convert.ToDecimal(ivaRateTextBox.Text)
                });
                conceptPanel.Hide();
                conceptsPanel.Show();
                conceptsDataGrid.DataSource = Concepts.Select(c => new { c.Quantity, c.Description, c.Price }).ToList();
            }
        }

        #region Validations

        private bool ValidateConcept()
        {
            var controlsValidations = new Dictionary<Control, bool>();
            controlsValidations.Add(quantityTextBox, Validator.IsInteger(quantityTextBox.Text, false));
            controlsValidations.Add(priceTextBox, Validator.IsDecimal(priceTextBox.Text, false));
            //controlsValidations.Add(ivaTextBox, Validator.IsDecimal(ivaTextBox.Text, true));
            controlsValidations.Add(ivaRateTextBox, Validator.IsDecimal(ivaRateTextBox.Text, true));
            controlsValidations.Add(unitComboBox, unitComboBox.SelectedItem != "");
            return Validator.Validate(controlsValidations);
        }

        #endregion

        private void cancelButton_Click(object sender, EventArgs e)
        {
            conceptPanel.Hide();
            conceptsPanel.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}