using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    public class StateDB
    {
        public static List<StateValue> GetAllStates()
        {
            List<StateValue> states = new List<StateValue>();

            cis3325_ClientsEntities container = new cis3325_ClientsEntities();
            var listState = from s in container.States select s;
            foreach (var s in listState)
            {
                //StateValue value = new StateValue();
                //value.StateCode = s.StateCode;
                //value.StateName = s.StateName;
                //
                StateValue value = new StateValue
                {
                    StateCode = s.StateCode,
                    StateName = s.StateName
                };
                states.Add(value);
            }
            return states;
        }
    }
}
