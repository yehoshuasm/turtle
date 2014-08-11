using System;
using System.Windows.Forms;
using System.Collections.Generic;
using turtle.Utils;
using System.Linq;
using System.Drawing;

namespace turtle
{
    public partial class InvoicingForm : Form
    {
        String emailAdded;
        public InvoicingForm()
        {
            InitializeComponent();
        }

        private void receiverInformationNextButton_Click(object sender, EventArgs e)
        {
            if (ValidateReceiverInformation())
            {
                receiverInformationPanel.Hide();
                requiredInformationPanel.Show();
            }
                        
        }

        private void requiredInformationNextButton_Click(object sender, EventArgs e)
        {
            if (ValidateRequiredInformation())
            {
                requiredInformationPanel.Hide();
                optionalInformationPanel.Show();
            }
        }

        private void optionalInformationNextButton_Click(object sender, EventArgs e)
        {
            if (ValidateOptionalInformation())
            {
                //Do some thing
            }
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

        private bool Validate(Dictionary<Control, bool> elements)
        {
            var notValidElements = elements.Where(e => !e.Value);
            SetNotValidColor(notValidElements.Select(c => c.Key).ToList());
            return elements.Count == 0; // Si no hay elementos no válidos regresa verdadero
        }

        private bool ValidateReceiverInformation()
        {   
            bool emailEvaluated=Validator.IsEmail(emailTextBox.Text);
            var elements = new Dictionary<Control, bool>();
            elements.Add(rfcTextBox, Validator.IsRfc(rfcTextBox.Text, false));
            elements.Add(nameTextBox, Validator.IsAlphanumeric(nameTextBox.Text, true));
            elements.Add(emailTextBox,emailEvaluated);
            elements.Add(streetTextBox, Validator.IsAlphabetic(streetTextBox.Text, false));
            elements.Add(externalNumberTextBox, Validator.IsInteger(externalNumberTextBox.Text, false));
            elements.Add(internalNumberTextBox, Validator.IsInteger(internalNumberTextBox.Text, true));
            elements.Add(suburbTextBox, Validator.IsAlphanumeric(suburbTextBox.Text, false));
            elements.Add(municipalityTextBox, Validator.IsAlphabetic(municipalityTextBox.Text, false));
            elements.Add(stateTextBox, Validator.IsAlphabetic(stateTextBox.Text, false));
            elements.Add(countryTextBox, Validator.IsAlphabetic(countryTextBox.Text, false));
            elements.Add(zipCodeTextBox, Validator.IsInteger(zipCodeTextBox.Text, false));

            if (emailEvaluated)
            {
                if (!emailAdded.Equals(""))
                {
                    emailTextBox.Text = emailAdded + "," + emailTextBox.Text;
                }
                else
                {
                    emailTextBox.Text = emailAdded;
                }
            }
            else
            {
                emailTextBox.Text = emailAdded;
            }
            return Validate(elements);
        }

        private bool ValidateRequiredInformation()
        {
            var elements = new Dictionary<Control, bool>();
            elements.Add(ticketNumberTextBox, Validator.IsInteger(ticketNumberTextBox.Text, false));
            elements.Add(subTotalTextBox, Validator.IsDecimal(subTotalTextBox.Text, false));
            elements.Add(totalTextBox, Validator.IsDecimal(totalTextBox.Text, false));
            return Validate(elements);
        }

        private bool ValidateOptionalInformation()
        {
            var elements = new Dictionary<Control, bool>();
            elements.Add(serialNumberTextBox, Validator.IsAlphanumeric(serialNumberTextBox.Text, true));
            elements.Add(folioTextBox, Validator.IsInteger(folioTextBox.Text, true));
            elements.Add(accountNumberTextBox, Validator.IsInteger(accountNumberTextBox.Text, true));
            elements.Add(currencyTextBox, Validator.IsAlphabetic(currencyTextBox.Text, true));
            elements.Add(exchangeRateTextBox, Validator.IsDecimal(exchangeRateTextBox.Text, true));
            elements.Add(taxRegimeTextBox, Validator.IsAlphanumeric(taxRegimeTextBox.Text, true));
            elements.Add(notesTextBox, Validator.IsAlphanumeric(notesTextBox.Text, true));
            return Validate(elements);
        }

        private void SetNotValidColor(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.BackColor = Color.FromArgb(252,144,144);
            }
        }

        private void addEmailButton_Click(object sender, EventArgs e)
        {
            emailAdded = emailTextBox.Text;
            emailTextBox.Text = "";

        }

        private void GotFocus_SetValidColor(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        
    }
}