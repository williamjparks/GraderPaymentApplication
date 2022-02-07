using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    //This class provide a method to make a connection 
    public class ClientConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = null; //object
            String connectionString= "Data Source=sql.mccoy.txstate.edu;Initial Catalog=cis3325_students;Persist Security Info=True;User ID=bobcat3325;Password=Ci$404404";
            conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
