using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Client
{
    public class AddressClientViewModel
    {
        public int ClientId { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Neigborhood { get; set; }
        public string AddressComplement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int TypeAddress { get; set; }
    }
}
