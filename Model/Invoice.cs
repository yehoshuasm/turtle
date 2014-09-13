using System.Collections.Generic;

namespace turtle.Model
{
    /// <summary>
    /// Modelo para Factura
    /// </summary>
    public class Invoice
    {
        // Required Information
        public string ReceipType { get; set; }
        public int TicketNumber { get; set; }
        public string PlaceOfIssue { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentForm { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        // Optional Information
        public string SerialNumber { get; set; }
        public int Folio { get; set; }
        public string AccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string TaxRegime { get; set; }
        public string Notes { get; set; }
        // Receiver Information
        public Receiver Receiver { get; set; }
        //public List<string> Emails { get; set; }
        public string Emails { get; set; }
        public int Sampling { get; set; }
        public int TotalSampling { get; set; }
        // Concepts
        public List<Concept> Concepts { get; set; }
    }
}