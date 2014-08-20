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
            /*int internalNumber=0;
            if (internalNumberTextBox.Text != null && !internalNumberTextBox.Text.Equals(""))
            {
                internalNumber = Convert.ToInt32(internalNumberTextBox.Text);
            }*/
            Invoice.Client = new Client
            {
                Rfc = rfcTextBox.Text,
                Name = nameTextBox.Text,
                //Email
                Address = new Address
                {
                    Street = streetTextBox.Text,
                    ExternalNumber = (externalNumberTextBox.Text!=""?Convert.ToInt32(externalNumberTextBox.Text):0),

                    InternalNumber = (internalNumberTextBox.Text != "" ? Convert.ToInt32(internalNumberTextBox.Text) : 0),
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

        private string GenerateInvoice()
        {
            string invoice = @"<?xml version='1.0' encoding='UTF-8' ?> <factura tipoComprobante='ingreso' serie='ZR' folio='19463' subtotal='" + Invoice.SubTotal + @"' 
                            total='" + Invoice.Total + @"' formaDePago='Pago en una sola exhibicion' correoCliente='yehoshua.jsm@live.com.mx'
                            noTicket='" + Invoice.TicketNumber + @"' lugarExpedicion='Mexico' metodoPago='No Identificado' numeroCuentaPago='1111' 
                            moneda='MXN' tipoCambio='1.0' comentario='Baila como Juana la cubana'>
                            <emisor><RegimenFiscal Regimen='Regimen General de Ley Personas Morales'/></emisor>
                           <receptor rfc='INE0804164Z7' nombre='INSTITUTO NACIONAL DE ESTADISTICA Y GEOGRAFIA' calle='AV. HEROE DE NACOZARI SUR'
                            noExterior='2301' noInterior='2' colonia='Col. JARDINES DEL PARQUE' municipio='AGUASCALIENTES' estado='AGUASCALIENTES' 
                            cp='20276' pais='Mexico'/>
                            <conceptos>
                                <concepto cantidad='1' unidad='Pieza' descripcion='Articulo de muestrario' precioUnitario='220.6900' iva='35.3104' tasaIva='16'/>
                            </conceptos>
                            </factura>";
            return invoice;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var cfdi = new CFDIEmite();
                         
            turtle.mx.com.emitefacturacion.emitecfdi.Respuesta respuesta=cfdi.generarCFDI(GenerateInvoice(),
                "AAA010101AAA", "Casa_Tono13");
           
            MessageBox.Show(respuesta.mensaje.ToString(), "Respuesta");
        }
    }
}