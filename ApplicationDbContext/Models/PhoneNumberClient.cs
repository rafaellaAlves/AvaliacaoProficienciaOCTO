using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationDbContext.Models
{
    public class PhoneNumberClient
    {
        public int ClientId { get; set; }
        public string PhoneNumber { get; set; }
        public int TypePhoneNumber { get; set; }
    }
}
