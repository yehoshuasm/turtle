using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using turtle.Model;
using turtle.Utils;
using turtle.Forms.Invoicing;

namespace turtle
{
    public partial class InvoicingForm : Form
    {
        private Invoice Invoice;
        String emailAdded;

        /// <summary>
        /// Constructor
        /// </summary>
        public InvoicingForm()
        {
            InitializeComponent();
            Invoice = new Invoice();
        }

        private void receiverInformationNextButton_Click(object sender, EventArgs e)
        {
            if (ValidateReceiverInformation())
            {
                SetReceiverInformation();
                receiverInformationPanel.Hide();
                requiredInformationPanel.Show();
            }
        }

        private void requiredInformationNextButton_Click(object sender, EventArgs e)
        {
            if (ValidateRequiredInformation())
            {
                SetRequiredInformation();
                requiredInformationPanel.Hide();
                optionalInformationPanel.Show();
            }
        }

        private void optionalInformationNextButton_Click(object sender, EventArgs e)
        {
            if (ValidateOptionalInformation())
            {
                SetOptionalInformation();
                new ConceptsForm().Show();
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

        #region Validations

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateReceiverInformation()
        {   
            bool emailEvaluated=Validator.IsEmail(emailTextBox.Text);
            var controlsValidations = new Dictionary<Control, bool>();
            controlsValidations.Add(rfcTextBox, Validator.IsRfc(rfcTextBox.Text, false));
            controlsValidations.Add(nameTextBox, Validator.IsAlphanumeric(nameTextBox.Text, true));
            controlsValidations.Add(emailTextBox,emailEvaluated);
            controlsValidations.Add(streetTextBox, Validator.IsAlphabetic(streetTextBox.Text, false));
            controlsValidations.Add(externalNumberTextBox, Validator.IsInteger(externalNumberTextBox.Text, false));
            controlsValidations.Add(internalNumberTextBox, Validator.IsInteger(internalNumberTextBox.Text, true));
            controlsValidations.Add(suburbTextBox, Validator.IsAlphanumeric(suburbTextBox.Text, false));
            controlsValidations.Add(municipalityTextBox, Validator.IsAlphabetic(municipalityTextBox.Text, false));
            controlsValidations.Add(stateTextBox, Validator.IsAlphabetic(stateTextBox.Text, false));
            controlsValidations.Add(countryTextBox, Validator.IsAlphabetic(countryTextBox.Text, false));
            controlsValidations.Add(zipCodeTextBox, Validator.IsInteger(zipCodeTextBox.Text, false));

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
            return Validator.Validate(controlsValidations);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateRequiredInformation()
        {
            var controlsValidations = new Dictionary<Control, bool>();
            controlsValidations.Add(ticketNumberTextBox, Validator.IsInteger(ticketNumberTextBox.Text, false));
            controlsValidations.Add(subTotalTextBox, Validator.IsDecimal(subTotalTextBox.Text, false));
            controlsValidations.Add(totalTextBox, Validator.IsDecimal(totalTextBox.Text, false));
            return Validator.Validate(controlsValidations);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateOptionalInformation()
        {
            var controlsValidations = new Dictionary<Control, bool>();
            controlsValidations.Add(serialNumberTextBox, Validator.IsAlphanumeric(serialNumberTextBox.Text, true));
            controlsValidations.Add(folioTextBox, Validator.IsInteger(folioTextBox.Text, true));
            controlsValidations.Add(accountNumberTextBox, Validator.IsInteger(accountNumberTextBox.Text, true));
            controlsValidations.Add(currencyTextBox, Validator.IsAlphabetic(currencyTextBox.Text, true));
            controlsValidations.Add(exchangeRateTextBox, Validator.IsDecimal(exchangeRateTextBox.Text, true));
            controlsValidations.Add(taxRegimeTextBox, Validator.IsAlphanumeric(taxRegimeTextBox.Text, true));
            controlsValidations.Add(notesTextBox, Validator.IsAlphanumeric(notesTextBox.Text, true));
            return Validator.Validate(controlsValidations);
        }

        #endregion

        /// <summary>
        /// Asinga información del receptor de la factura
        /// </summary>
        private void SetReceiverInformation()
        {
            Invoice.Client = new Client
            {
                Rfc = rfcTextBox.Text,
                Name = nameTextBox.Text,
                //Email
                Address = new Address
                {
                    Street = streetTextBox.Text,
                    ExternalNumber = Convert.ToInt32(externalNumberTextBox.Text),
                    InternalNumber = Convert.ToInt32(internalNumberTextBox.Text),
                    Suburb = suburbTextBox.Text,
                    Municipality = municipalityTextBox.Text,
                    State = stateTextBox.Text,
                    Country = countryTextBox.Text,
                    ZipCode = Convert.ToInt32(zipCodeTextBox.Text)
                },
            };
        }

        /// <summary>
        /// Asigna información requerida de la factura
        /// </summary>
        private void SetRequiredInformation()
        {
            Invoice.ReceipType = receipTypeComboBox.SelectedText;
            Invoice.TicketNumber = Convert.ToInt32(ticketNumberTextBox.Text);
            Invoice.PlaceOfIssue = placeOfIssueComboBox.SelectedText;
            Invoice.PaymentMethod = paymentMethodComboBox.SelectedText;
            Invoice.PaymentForm = paymentFormComboBox.SelectedText;
            Invoice.SubTotal = Convert.ToDecimal(subTotalTextBox.SelectedText);
            Invoice.Total = Convert.ToDecimal(totalTextBox.Text);
        }

        /// <summary>
        /// Asigna información opcional de la factura
        /// </summary>
        private void SetOptionalInformation()
        {
            Invoice.SerialNumber = serialNumberTextBox.Text;
            Invoice.Folio = Convert.ToInt32(folioTextBox.Text);
            Invoice.AccountNumber = accountNumberTextBox.Text;
            Invoice.Currency = currencyTextBox.Text;
            Invoice.ExchangeRate = Convert.ToDecimal(exchangeRateTextBox.Text);
            Invoice.Notes = notesTextBox.Text;
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