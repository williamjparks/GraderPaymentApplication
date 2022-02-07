using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    public class ClientValue
    {
        private int clientId;
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipCode;

        public int ClientId { get => clientId; set => clientId = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
    }
}
