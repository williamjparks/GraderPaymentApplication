using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    public class ClientDB
    {

        public static bool DeleteClient(ClientValue client)
        {
            bool deleted = false;
            //Get a connection object
            SqlConnection connection = ClientConnection.GetConnection();
            //Create a command
            String sqlString = "DELETE FROM clients " + //a space after clients
                                "WHERE @ClientId = ClientID ";
            SqlCommand command = new SqlCommand(sqlString, connection);
            command.Parameters.AddWithValue("@ClientId", client.ClientId);

            try
            {
                //Execute the command
                connection.Open();
                int count = command.ExecuteNonQuery();

                if (count > 0)
                {
                    deleted = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return deleted;
        }
        public static void AddClient(ClientValue client)
        {
            //Get a connection object
            SqlConnection connection = ClientConnection.GetConnection();
            //Create a command
            String sqlString = "INSERT INTO clients " + //a space after clients
                                "VALUES(@ClientId, @Name, @Address, @City, @State, @ZipCode) ";
            SqlCommand command = new SqlCommand(sqlString, connection);
            
            //Set parameter values
            command.Parameters.AddWithValue("@ClientId", client.ClientId);
            command.Parameters.AddWithValue("@Name", client.Name);
            command.Parameters.AddWithValue("@Address", client.Address);
            command.Parameters.AddWithValue("@City", client.City);
            command.Parameters.AddWithValue("@State", client.State);
            command.Parameters.AddWithValue("@ZipCode", client.ZipCode);

            try
            {
                //Execute the command
                connection.Open();
                command.ExecuteNonQuery();
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<ClientValue> GetAllClients()
        {
            List<ClientValue> clientValues = new List<ClientValue>();

            cis3325_ClientsEntities container = new cis3325_ClientsEntities();
            var listClient = from c in container.Clients select c;
            foreach (var c in listClient)
            {
                ClientValue value = new ClientValue
                {
                    ClientId = c.ClientID,
                    Name = c.Name,
                    Address = c.Address,
                    City = c.City,
                    State = c.State,
                    ZipCode = c.ZipCode
                };
                clientValues.Add(value);
            }


            return clientValues;
        }
        public static ClientValue GetClient(int id)
        {
            ClientValue c = null;

            //Get a connection object
            SqlConnection connection = ClientConnection.GetConnection();
            
            //Create a command
            String sqlString = "SELECT ClientID, Name, Address, City, State, ZipCode " +
                                "FROM Clients WHERE ClientID = @cid";
            SqlCommand command = new SqlCommand(sqlString,connection);

            //Set parameter values
            command.Parameters.AddWithValue("@cid", id);
            try
            {
                //Execute the command
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    c = new ClientValue();
                    c.ClientId = (int)reader["ClientID"];
                    c.Name = reader["Name"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.City = reader["City"].ToString();
                    c.State = reader["State"].ToString();
                    c.ZipCode = reader["ZipCode"].ToString();

                }
            } 
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return c;

        }
    }
}
