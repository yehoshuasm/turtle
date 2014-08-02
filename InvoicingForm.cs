using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            if (validateReceiverInformation())
            {
                receiverInformationPanel.Hide();
                requiredInformationPanel.Show();
            }
                        
        }

        private void requiredInformationNextButton_Click(object sender, EventArgs e)
        {
            if (validateRequiredInformation())
            {
                requiredInformationPanel.Hide();
                optionalInformationPanel.Show();
            }
        }

        private void optionalInformationNextButton_Click(object sender, EventArgs e)
        {
            if (validateOptionalInformation())
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

        //Method for validate forms
        
        //Panel Receiver Information
        public Boolean validateReceiverInformation()
        {
            Boolean validateRFC = Utils.Validator.isVarChar(rfcTextBox.Text);
            Boolean validateName = Utils.Validator.isString(nameTextBox.Text);
            Boolean validateEmail = Utils.Validator.isEmailAddress(emailTextBox.Text);
            Boolean validateStreet = Utils.Validator.isString(streetTextBox.Text);
            Boolean validateNoExt = Utils.Validator.isVarChar(ExternalNumberTextBox.Text);
            Boolean validateNoInt = Utils.Validator.isVarChar(InternalNumberTextBox.Text);
            Boolean validateSuburb = Utils.Validator.isString(suburbTextBox.Text);
            Boolean validateMunicipaly = Utils.Validator.isString(municipalityTextBox.Text);
            Boolean validateState = Utils.Validator.isString(stateTextBox.Text);
            Boolean validateCountry = Utils.Validator.isString(countryTextBox.Text);
            Boolean validateZipCode = Utils.Validator.isNumeric(zipCodeTextBox.Text);

            if (validateRFC && validateName && validateEmail && validateStreet && validateNoExt
                && validateNoInt && validateSuburb && validateMunicipaly && validateState && validateCountry && validateZipCode)
            {   
                String messageReceiverInformation= "RFC:" + rfcTextBox.Text + "\n" +
                    "Nombre:" + nameTextBox.Text + "\n" +
                    "Calle:" + streetTextBox.Text + "\n" +
                    "N° Ext:" + ExternalNumberTextBox.Text + "\n" +
                    "N° Int:" + InternalNumberTextBox.Text + "\n" +
                    "Colonia:" + suburbTextBox.Text + "\n" +
                    "Municipio:" + municipalityTextBox.Text + "\n" +
                    "Estado:" + stateTextBox.Text + "\n" +
                    "País:" + countryTextBox.Text + "\n" +
                    "C.P:" + zipCodeTextBox.Text + "\n";
                 String captionReceioverInformation="Corfirmar los Datos";
               
                                
               DialogResult resultConfirmReceiverInformation = MessageBox.Show(messageReceiverInformation, captionReceioverInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
               
               

                if (resultConfirmReceiverInformation==DialogResult.Yes)
                {
                    return true;
                }
            }

            if (!validateRFC)
            {
                rfcTextBox.BackColor = Color.Red;
            }
            if (!validateName)
            {
                nameTextBox.BackColor = Color.Red;
            }
            if (!validateEmail)
            {
                emailTextBox.BackColor = Color.Red;
            }
            if (!validateStreet)
            {
                streetTextBox.BackColor = Color.Red;
            }
            if (!validateNoExt)
            {
                ExternalNumberTextBox.BackColor = Color.Red;
            }
            if (!validateNoInt)
            {
                InternalNumberTextBox.BackColor = Color.Red;
            }
            if (!validateSuburb)
            {
                suburbTextBox.BackColor = Color.Red;
            }
            if (!validateMunicipaly)
            {
                municipalityTextBox.BackColor = Color.Red;
            }
            if (!validateState)
            {
                stateTextBox.BackColor = Color.Red;
            }
            if (!validateCountry)
            {
                countryTextBox.BackColor = Color.Red;
            }
            if (!validateZipCode)
            {
                zipCodeTextBox.BackColor = Color.Red;
            }

            return false;
        }

        //Panel Requiered Information
        public Boolean validateRequiredInformation()
        {
            
            Boolean validateNumberTicket = Utils.Validator.isNumeric(ticketNumberTextBox.Text);
            Boolean validateSubTotal = Utils.Validator.isFloat(subTotalTextBox.Text);
            Boolean validateTotal = Utils.Validator.isFloat(totalTextBox.Text);
            


            if (validateNumberTicket && validateSubTotal && validateTotal )
            {
                String messageRequiredInformation = "Tipo de Comprobante:" + receipTypeComboBox.Text + "\n" +
                    "N° Ticket:" + ticketNumberTextBox.Text + "\n" +
                    "Expedición:" + placeOfIssueComboBox.Text + "\n" +
                    "Método de Pago:" + paymentMethodComboBox.Text + "\n" +
                    "Forma de Pago:" + paymentFormComboBox.Text + "\n" +
                    "SubTotal:" + subTotalTextBox.Text + "\n" +
                    "Total:" + totalTextBox.Text;
                     String captionRequiredInformation = "Corfirmar los Datos";
                

                DialogResult resultConfirmRequiredInformation = MessageBox.Show(messageRequiredInformation, captionRequiredInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);



                if (resultConfirmRequiredInformation == DialogResult.Yes)
                {
                    return true;
                }
            }

            if (!validateNumberTicket)
            {
               ticketNumberTextBox.BackColor = Color.Red;
            }
            if (!validateSubTotal)
            {
                subTotalTextBox.BackColor = Color.Red;
            }
            if (!validateTotal)
            {
                totalTextBox.BackColor = Color.Red;
            }
            

            return false;
        }

        //Panel Optional Information
        public Boolean validateOptionalInformation()
        {

            Boolean validateSerialNumber = Utils.Validator.isVarChar(serialNumberTextBox.Text);
            Boolean validateFolio= Utils.Validator.isNumeric(folioTextBox.Text);
            Boolean validateAccountNumber = Utils.Validator.isNumeric(accountNumberTextBox.Text);
            Boolean validateCurrency = Utils.Validator.isString(currencyTextBox.Text);
            Boolean validateExchange = Utils.Validator.isVarChar(exchangeRateTextBox.Text);
            Boolean validateTaxRegime = Utils.Validator.isVarChar(taxRegimeTextBox.Text);
            Boolean validateNotes = Utils.Validator.isVarChar(notesTextBox.Text);


            if (validateSerialNumber && validateFolio && validateAccountNumber && validateCurrency && validateExchange && validateTaxRegime && validateNotes)
            {
                String messageOptionalInformation = "N° Serie:" + serialNumberTextBox.Text + "\n" +
                    "Folio:" + folioTextBox.Text + "\n" +
                    "N° Cuenta:" + accountNumberTextBox.Text + "\n" +
                    "Moneda:" + currencyTextBox.Text + "\n" +
                    "Tipo de Cambio:" + exchangeRateTextBox.Text + "\n" +
                    "Regimen Fiscal:" + taxRegimeTextBox.Text + "\n" +
                    "Comentarios:" + notesTextBox.Text;
                String captionOptionalInformation = "Corfirmar los Datos";
                

                DialogResult resultConfirmOptionalInformation = MessageBox.Show(messageOptionalInformation, captionOptionalInformation, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);



                if (resultConfirmOptionalInformation == DialogResult.Yes)
                {
                    return true;
                }
            }

            if (!validateSerialNumber)
            {
               serialNumberTextBox.BackColor = Color.Red;
            }
            if (!validateFolio)
            {
                folioTextBox.BackColor = Color.Red;
            }
            if (!validateAccountNumber)
            {
                accountNumberTextBox.BackColor = Color.Red;
            }
            if (!validateCurrency)
            {
                currencyTextBox.BackColor = Color.Red;
            }
            if (!validateExchange)
            {
                exchangeRateTextBox.BackColor = Color.Red;
            }
            if (!validateTaxRegime)
            {
                taxRegimeTextBox.BackColor = Color.Red;
            }
            if (!validateNotes)
            {
                notesTextBox.BackColor = Color.Red;
            }


            return false;
        }

        
        
    }
}