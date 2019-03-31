using BestFurnitureDeals2._0.DataAccess.DataAccessObjects;
using BestFurnitureDeals2._0.DataAccess.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFurnitureDeals2._0.BusinessLogic
{
    class UserController
    {
        public void CreateUser(User user)
        {
            string queryString = "INSERT INTO dbo.Users(username, password, firstname, lastname, email, phonenumber, address)" +
                "values(@username, @password, @firstname, @lastname, @email, @phonenumber, @address)";

            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar);
                command.Parameters["@username"].Value = user.Username;
                command.Parameters.Add("@password", SqlDbType.VarChar);
                command.Parameters["@password"].Value = user.Password;
                command.Parameters.Add("@firstname", SqlDbType.VarChar);
                command.Parameters["@firstname"].Value = user.FirstName;
                command.Parameters.Add("@lastname", SqlDbType.VarChar);
                command.Parameters["@lastname"].Value = user.LastName;
                command.Parameters.Add("@email", SqlDbType.VarChar);
                command.Parameters["@email"].Value = user.Email;
                command.Parameters.Add("@phonenumber", SqlDbType.VarChar);
                command.Parameters["@phonenumber"].Value = user.PhoneNumber;
                command.Parameters.Add("@address", SqlDbType.VarChar);
                command.Parameters["@address"].Value = user.Address;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
