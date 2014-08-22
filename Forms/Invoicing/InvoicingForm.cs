using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using turtle.Model;
using turtle.Utils;
using turtle.Forms.Invoicing;
using turtle.mx.com.emitefacturacion.emitecfdi;

namespace turtle
{
    public partial class InvoicingForm : Form
    {
        Invoice Invoice;
        String emailAdded;

        /// <summary>
        /// Constructor
        /// </summary>
        public InvoicingForm()
        {
            InitializeComponent();
            Invoice = new Invoice
            {
                Concepts = new List<Concept>()
            };
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
                new ConceptsForm(Invoice.Concepts).Show();
                optionalInformationPanel.Hide();
                generatePanel.Show();
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
                if (emailAdded!=null&&!emailAdded.Equals(""))
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
            
            Invoice.Receiver = new Receiver
            {
                Rfc = rfcTextBox.Text,
                Name = nameTextBox.Text,
                //Email
                Address = new Address
                {
                    Street = streetTextBox.Text,
                    ExternalNumber = (externalNumberTextBox.Text),

                    InternalNumber = (internalNumberTextBox.Text),
                    Suburb = suburbTextBox.Text,
                    Municipality = municipalityTextBox.Text,
                    State = stateTextBox.Text,
                    Country = countryTextBox.Text,
                    ZipCode = (zipCodeTextBox.Text!=""?Convert.ToInt32(zipCodeTextBox.Text):0)
                }
            };
        }

        /// <summary>
        /// Asigna información requerida de la factura
        /// </summary>
        private void SetRequiredInformation()
        {
            Invoice.ReceipType = receipTypeComboBox.SelectedText;
            Invoice.TicketNumber = (ticketNumberTextBox.Text!=""?Convert.ToInt32(ticketNumberTextBox.Text):0);
            Invoice.PlaceOfIssue = placeOfIssueComboBox.SelectedText;
            Invoice.PaymentMethod = paymentMethodComboBox.SelectedText;
            Invoice.PaymentForm = paymentFormComboBox.SelectedText;
            Invoice.SubTotal = (subTotalTextBox.Text!=""?Convert.ToDecimal(subTotalTextBox.Text):0);
            Invoice.Total = (totalTextBox.Text!=""?Convert.ToDecimal(totalTextBox.Text):0);
        }

        /// <summary>
        /// Asigna información opcional de la factura
        /// </summary>
        private void SetOptionalInformation()
        {
            Invoice.SerialNumber = serialNumberTextBox.Text;
            Invoice.Folio = (folioTextBox.Text!=""?Convert.ToInt32(folioTextBox.Text):0);
            Invoice.AccountNumber = accountNumberTextBox.Text;
            Invoice.Currency = currencyTextBox.Text;
            Invoice.ExchangeRate = (exchangeRateTextBox.Text!=""?Convert.ToDecimal(exchangeRateTextBox.Text):0);
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

        private string ReceiverToString(Receiver receiver)
        {
            var tags = new Dictionary<string, string>();
            tags.Add("rfc", receiver.Rfc);
            tags.Add("nombre", receiver.Name);
            var address = receiver.Address;
            tags.Add("calle", address.Street);
            tags.Add("noExterior", address.ExternalNumber);
            tags.Add("noInterior", address.InternalNumber);
            tags.Add("colonia", address.Suburb);
            tags.Add("municipio", address.Municipality);
            tags.Add("estado", address.State);
            tags.Add("pais", address.Country);
            tags.Add("cp", address.ZipCode.ToString());
            var tagsString = Concat(tags);
            return tagsString != null ? "<receptor" + tagsString + " />" : "";
        }

        private string ConceptsToString(List<Concept> concepts)
        {
            string result = null;
            if (concepts != null && concepts.Count > 0)
            {
                foreach (var concept in concepts)
                {
                    result += ConceptToString(concept);
                }
            }
            return result != null ? "<conceptos>" + result + "</conceptos>" : null;
        }

        private string ConceptToString(Concept concept)
        {
            var tags = new Dictionary<string, string>();
            tags.Add("cantidad", concept.Quantity.ToString());
            tags.Add("unidad", concept.Unit);
            tags.Add("descripcion", concept.Description);
            tags.Add("precioUnitario", concept.Price.ToString());
            tags.Add("iva", concept.ToString());
            tags.Add("tasaIva", concept.IvaRate.ToString());
            var tagsString = Concat(tags);
            return tagsString != null ? "<concepto" + tagsString + " />" : "";
        }

        private string Concat(Dictionary<string, string> tags)
        {
            string result = null;
            foreach (var tag in tags.Where(t => t.Value != null).ToList())
            {
                result += " " + tag.Key + "='" + tag.Value + "'";
            }
            return result;
        }

        private string InvoiceToString()
        {
            var invoiceString = "<?xml version='1.0' encoding='UTF-8' ?><factura";
            var tags = new Dictionary<string, string>();
            tags.Add("correoCliente", "yehoshua.jsm@live.com.mx");
            tags.Add("noTicket", Invoice.TicketNumber.ToString());
            tags.Add("lugarExpedicion", Invoice.PlaceOfIssue);
            tags.Add("subtotal", Invoice.SubTotal.ToString());
            tags.Add("total", Invoice.Total.ToString());
            tags.Add("tipoComprobante", "ingreso");
            tags.Add("formaDePago", Invoice.PaymentForm);
            tags.Add("metodoDePago", Invoice.PaymentMethod);
            tags.Add("serie", Invoice.SerialNumber);
            tags.Add("folio", Invoice.Folio.ToString());
            tags.Add("numeroCuentaPago", Invoice.AccountNumber);
            tags.Add("moneda", "MXN");
            tags.Add("tipoCambio", Invoice.ExchangeRate != 0 ? Invoice.ExchangeRate.ToString() : null);
            tags.Add("regimenFiscal", Invoice.TaxRegime);
            tags.Add("comentarios", Invoice.Notes);
            var tagsString = Concat(tags);
            invoiceString += tagsString + " />";
            invoiceString += "<emisor><RegimenFiscal Regimen='Regimen General de Ley Personas Morales'/></emisor>";
            invoiceString += ReceiverToString(Invoice.Receiver);
            invoiceString += ConceptsToString(Invoice.Concepts);
            invoiceString += "</factura>";
            return invoiceString;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var cfdi = new CFDIEmite();
            Invoice.SubTotal = Invoice.Concepts != null ? Invoice.Concepts.Sum(c => c.Price) : 0;
            Invoice.Total = Invoice.Concepts != null ? Invoice.Concepts.Sum(c => c.Iva) + Invoice.SubTotal : 0;
            turtle.mx.com.emitefacturacion.emitecfdi.Respuesta respuesta=cfdi.generarCFDI(InvoiceToString(), "AAA010101AAA", "Casa_Tono13");
           
            MessageBox.Show(respuesta.mensaje.ToString(), "Respuesta");
        }
    }
}