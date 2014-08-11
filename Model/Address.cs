using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace turtle.Model
{
    class Address
    {
        public string Street { get; set; }
        public int ExternalNumber { get; set; }
        public int InternalNumber { get; set; }
        public string Suburb { get; set; }
        public string Municipality { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
    }
}