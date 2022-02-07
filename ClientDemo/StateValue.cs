using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    public class StateValue
    {
        private string stateCode;
        private string stateName;

        public string StateCode { get => stateCode; set => stateCode = value; }
        public string StateName { get => stateName; set => stateName = value; }
    }
}
