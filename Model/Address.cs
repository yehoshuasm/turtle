namespace turtle.Model
{
    /// <summary>
    /// Modelo para Dirección
    /// </summary>
    public class Address
    {
        public string Street { get; set; }
        public string ExternalNumber { get; set; }
        public string InternalNumber { get; set; }
        public string Suburb { get; set; }
        public string Municipality { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
    }
}