using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using turtle.Model;
using turtle.Utils;
using turtle.Forms.Invoicing;

namespace turtle.Forms.Invoicing
{
    public partial class ConceptsForm : Form
    {
        public static List<Concept> Concepts;
        InvoicingForm invoicing;
        public ConceptsForm(List<Concept> concepts,InvoicingForm invoicing)
        {
            InitializeComponent();
            Concepts = concepts;
            conceptsDataGrid.DataSource = Concepts.Select(c => new { c.Quantity, c.Description, c.Price, c.Import }).ToList();
            this.invoicing = invoicing;
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
                    Unit= unitComboBox.SelectedItem.ToString(),
                    Import = Convert.ToInt32(quantityTextBox.Text) * Convert.ToDecimal(priceTextBox.Text),
                    IvaRate = Convert.ToDecimal(ivaRatecomboBox.SelectedItem.ToString()),
                    Iva = Convert.ToDecimal(ivaTextBox.Text),
                    
                });
                conceptPanel.Hide();
                conceptsPanel.Show();
                conceptsDataGrid.DataSource = Concepts.Select(c => new {c.Quantity , c.Description, c.Price, c.Import}).ToList();
            }
        }

        #region Validations

        private bool ValidateConcept()
        {
            var controlsValidations = new Dictionary<Control, bool>();
            controlsValidations.Add(quantityTextBox, Validator.IsInteger(quantityTextBox.Text, false));
            controlsValidations.Add(priceTextBox, Validator.IsDecimal(priceTextBox.Text, false));
            controlsValidations.Add(ivaTextBox, Validator.IsDecimal(ivaTextBox.Text, false));
            controlsValidations.Add(descriptionTextBox,Validator.IsAlphanumeric(descriptionTextBox.Text,false));
            //controlsValidations.Add(ivaRatecomboBox1, Validator.IsDecimal(ivaRatecomboBox1.Text, false));
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
            this.Hide();
            setTotalandSubTotal();
        }

        private void ivaRateSelectItem(object sender, EventArgs e)
        {
            decimal import = Convert.ToInt32(quantityTextBox.Text) * Convert.ToDecimal(priceTextBox.Text);
            ivaTextBox.Text = ((import * Convert.ToDecimal(ivaRatecomboBox.SelectedItem.ToString()))/100).ToString();
        }

        public void setTotalandSubTotal()
        {
            Decimal total = 0, subTotal = 0;


            foreach (turtle.Model.Concept concep in ConceptsForm.Concepts)
            {
                subTotal = subTotal + concep.Import;
                total = total + (subTotal + concep.Iva);
            }

            //invoicing.subTotalTextBox.Text = subTotal.ToString();
            //invoicing.Text = total.ToString();
        }
    }
}