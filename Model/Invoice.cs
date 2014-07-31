using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace turtle.Model
{
    class Invoice
    {

        private String emailCliente;
        private int zipCode;
        private String country;
        private String state;
        private String municipality;
        private String suburb;
        private String internalNumber;
        private String externalNumber;
        private String street;
        private String name;
        private String rfc;
        private String paymentForm;
        private String patmentMethod;
        private int sampling;
        private int totalSampling;
        private String placeOfIssue;
        private String receipType;
        private int ticketNumber;
        private float total;
        private float subTotal;
        private int accountNumber;
        private String notes;
        private String taxRegime;
        private String exchangeRate;
        private String currency;
        private int folio;
        private String serialNumber;

        public String Country
        {
            get { return country; }
            set { country = value; }
        }

        public String State
        {
            get { return state; }
            set { state = value; }
        }

        public String Municipality
        {
            get { return municipality; }
            set { municipality = value; }
        }

        public String Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        public String InternalNumber
        {
            get { return internalNumber; }
            set { internalNumber = value; }
        }

        public String ExternalNumber
        {
            get { return externalNumber; }
            set { externalNumber = value; }
        }

        public String Street
        {
            get { return street; }
            set { street = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public String PaymentForm
        {
            get { return paymentForm; }
            set { paymentForm = value; }
        }

        public String PatmentMethod
        {
            get { return patmentMethod; }
            set { patmentMethod = value; }
        }

        public int Sampling
        {
            get { return sampling; }
            set { sampling = value; }
        }

        public int TotalSampling
        {
            get { return totalSampling; }
            set { totalSampling = value; }
        }

        public String PlaceOfIssue
        {
            get { return placeOfIssue; }
            set { placeOfIssue = value; }
        }

        public String ReceipType
        {
            get { return receipType; }
            set { receipType = value; }
        }

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public int TicketNumber
        {
            get { return ticketNumber; }
            set { ticketNumber = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public float SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public String Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public String TaxRegime
        {
            get { return taxRegime; }
            set { taxRegime = value; }
        }

        public String ExchangeRate
        {
            get { return exchangeRate; }
            set { exchangeRate = value; }
        }

        public String Currency
        {
            get { return currency; }
            set { currency = value; }
        }


        public int Folio
        {
            get { return folio; }
            set { folio = value; }
        }

        public String EmailCliente
        {
            get { return emailCliente; }
            set { emailCliente = value; }
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
    }
}
