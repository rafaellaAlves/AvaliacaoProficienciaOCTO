using DTO.Shared;
using DTO.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Client
{
    public class ClientViewModel 
    {
        public int ClientId { get; set; }        [Update]
      
        public string Name { get; set; }
        [Update]
        public string Email { get; set; }
        public string CpfCnpjDocument { get; set; }      
        public int TypeClient { get; set; }
        
    }
}
