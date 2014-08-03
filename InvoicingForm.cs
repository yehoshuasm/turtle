using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using turtle.Utils;

namespace turtle
{
    public partial class InvoicingForm : Form
    {
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
                //Do something
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
            var elements = new Dictionary<Control, bool>();
            elements.Add(rfcTextBox, Validator.IsRfc(rfcTextBox.Text));
            elements.Add(nameTextBox, Validator.IsAlphanumeric(nameTextBox.Text));
            elements.Add(emailTextBox, Validator.IsEmail(emailTextBox.Text));
            elements.Add(streetTextBox, Validator.IsAlphabetic(streetTextBox.Text));
            elements.Add(externalNumberTextBox, Validator.IsInteger(externalNumberTextBox.Text));
            elements.Add(internalNumberTextBox, Validator.IsInteger(internalNumberTextBox.Text));
            elements.Add(suburbTextBox, Validator.IsAlphanumeric(suburbTextBox.Text));
            elements.Add(municipalityTextBox, Validator.IsAlphabetic(municipalityTextBox.Text));
            elements.Add(stateTextBox, Validator.IsAlphabetic(stateTextBox.Text));
            elements.Add(countryTextBox, Validator.IsAlphabetic(countryTextBox.Text));
            elements.Add(zipCodeTextBox, Validator.IsInteger(zipCodeTextBox.Text));
            return Validate(elements);
            //    String messageReceiverInformation = "RFC:" + rfcTextBox.Text + "\n" +
            //        "Nombre:" + nameTextBox.Text + "\n" +
            //        "Calle:" + streetTextBox.Text + "\n" +
            //        "N° Ext:" + externalNumberTextBox.Text + "\n" +
            //        "N° Int:" + internalNumberTextBox.Text + "\n" +
            //        "Colonia:" + suburbTextBox.Text + "\n" +
            //        "Municipio:" + municipalityTextBox.Text + "\n" +
            //        "Estado:" + stateTextBox.Text + "\n" +
            //        "País:" + countryTextBox.Text + "\n" +
            //        "C.P:" + zipCodeTextBox.Text + "\n";
            //    String captionReceioverInformation = "Corfirmar los Datos";
            //    DialogResult resultConfirmReceiverInformation = MessageBox.Show(messageReceiverInformation, captionReceioverInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //    if (resultConfirmReceiverInformation == DialogResult.Yes)
            //    {
            //        return true;
            //    }
            //}
        }

        private bool ValidateRequiredInformation()
        {
            var elements = new Dictionary<Control, bool>();
            elements.Add(ticketNumberTextBox, Validator.IsInteger(ticketNumberTextBox.Text));
            elements.Add(subTotalTextBox, Validator.IsDecimal(subTotalTextBox.Text));
            elements.Add(totalTextBox, Validator.IsDecimal(totalTextBox.Text));
            return Validate(elements);
            //        String messageRequiredInformation = "Tipo de Comprobante:" + receipTypeComboBox.Text + "\n" +
            //            "N° Ticket:" + ticketNumberTextBox.Text + "\n" +
            //            "Expedición:" + placeOfIssueComboBox.Text + "\n" +
            //            "Método de Pago:" + paymentMethodComboBox.Text + "\n" +
            //            "Forma de Pago:" + paymentFormComboBox.Text + "\n" +
            //            "SubTotal:" + subTotalTextBox.Text + "\n" +
            //            "Total:" + totalTextBox.Text;
            //             String captionRequiredInformation = "Corfirmar los Datos";
            //        DialogResult resultConfirmRequiredInformation = MessageBox.Show(messageRequiredInformation, captionRequiredInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //        if (resultConfirmRequiredInformation == DialogResult.Yes)
            //        {
            //            return true;
            //        }
        }

        private bool ValidateOptionalInformation()
        {
            var elements = new Dictionary<Control, bool>();
            elements.Add(serialNumberTextBox, Validator.IsAlphanumeric(serialNumberTextBox.Text));
            elements.Add(folioTextBox, Validator.IsInteger(folioTextBox.Text));
            elements.Add(accountNumberTextBox, Validator.IsInteger(accountNumberTextBox.Text));
            elements.Add(currencyTextBox, Validator.IsAlphabetic(currencyTextBox.Text));
            elements.Add(exchangeRateTextBox, Validator.IsDecimal(exchangeRateTextBox.Text));
            elements.Add(taxRegimeTextBox, Validator.IsAlphanumeric(taxRegimeTextBox.Text));
            elements.Add(notesTextBox, Validator.IsAlphanumeric(notesTextBox.Text));
            return Validate(elements);
            //        String messageOptionalInformation = "N° Serie:" + serialNumberTextBox.Text + "\n" +
            //            "Folio:" + folioTextBox.Text + "\n" +
            //            "N° Cuenta:" + accountNumberTextBox.Text + "\n" +
            //            "Moneda:" + currencyTextBox.Text + "\n" +
            //            "Tipo de Cambio:" + exchangeRateTextBox.Text + "\n" +
            //            "Regimen Fiscal:" + taxRegimeTextBox.Text + "\n" +
            //            "Comentarios:" + notesTextBox.Text;
            //        String captionOptionalInformation = "Corfirmar los Datos";
            //        DialogResult resultConfirmOptionalInformation = MessageBox.Show(messageOptionalInformation, captionOptionalInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //        if (resultConfirmOptionalInformation == DialogResult.Yes)
            //        {
            //            return true;
            //        }
        }

        private void SetNotValidColor(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.BackColor = Color.FromArgb(252, 143, 143);
            }
        }

        private void SetValidColor(Control textBox)
        {
            textBox.BackColor = Color.White;
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            SetValidColor(((TextBox)sender));
        }

        

    }
}