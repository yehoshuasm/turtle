namespace turtle.Model
{
    /// <summary>
    /// Modelo para Cliente
    /// </summary>
    public class Receiver
    {
        public string Rfc { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}