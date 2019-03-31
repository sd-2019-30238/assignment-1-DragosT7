using BestFurnitureDeals2._0.DataAccess.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFurnitureDeals2._0.BusinessLogic
{
    class OrderController
    {

        public static string ORDER_CREATING = "CREATING ORDER";
        public static string ORDER_PROCESSING = "PROCESSING ORDER";
        public static string ORDER_DELIVERING = "DELIVERING ORDER";
        public static string DELIVERED = "ORDER DELIVERED";

        public string RetrieveStatusCreating
        {
            get
            {
                return ORDER_CREATING;
            }
        }

        public string RetrieveStatusProcessing
        {
            get
            {
                return ORDER_PROCESSING;
            }
        }

        public string RetrieveStatusDelivering
        {
            get
            {
                return ORDER_DELIVERING;
            }
        }

        public string RetrieveStatusDelivered
        {
            get
            {
                return DELIVERED;
            }
        }



        public void AddToCart(int itemID, int userID)
        {
            int orderID = this.LastOrder(userID);
            string queryString = "INSERT INTO dbo.OrderItems(orderID, furnitureID) values(@orderID, @furnitureID);";

            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@orderID", SqlDbType.Int);
                command.Parameters["@orderID"].Value = orderID;
                command.Parameters.Add("@furnitureID", SqlDbType.Int);
                command.Parameters["@furnitureID"].Value = itemID;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private int LastOrder(int userID)
        {
            string queryString = "SELECT id, userID FROM dbo.Orders where statusorder = @statusorder and userID = @userID;";
            int orderID;

            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@statusorder", SqlDbType.VarChar);
                command.Parameters["@statusorder"].Value = ORDER_CREATING;
                command.Parameters.Add("@userID", SqlDbType.Int);
                command.Parameters["@userID"].Value = userID;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        orderID = reader.GetInt32(0);
                    }
                    else
                    {
                        orderID = this.CreateOrder(userID);
                    }
                }
                connection.Close();

                return orderID;
            }
        }

        private int CreateOrder(int userID)
        {
            string queryString = "INSERT INTO dbo.Orders(userID, totalprice, statusorder) values(@userID, @totalprice, @statusorder);";
            int orderID;
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@userID", SqlDbType.Int);
                command.Parameters["@userID"].Value = userID;
                command.Parameters.Add("@totalprice", SqlDbType.Float);
                command.Parameters["@totalprice"].Value = 0;
                command.Parameters.Add("@statusorder", SqlDbType.VarChar);
                command.Parameters["@statusorder"].Value = ORDER_CREATING;

                connection.Open();
                orderID = command.ExecuteNonQuery();
                connection.Close();

                return orderID;
            }
        }

        public void UpdateOrderStatusAfterCheckout(int userID)
        {
            int orderID = this.LastOrder(userID);
            string queryString = "UPDATE dbo.Orders set statusorder = @statusorder, totalprice = @totalprice where id = @orderID";
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@statusorder", SqlDbType.VarChar);
                command.Parameters["@statusorder"].Value = ORDER_PROCESSING;
                command.Parameters.Add("@totalprice", SqlDbType.Float);
                command.Parameters["@totalprice"].Value = float.Parse(this.CalculateCartPrice(orderID));
                command.Parameters.Add("@orderID", SqlDbType.VarChar);
                command.Parameters["@orderID"].Value = orderID;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateOrderStatusByAdmin(string status, int id)
        {
            string queryString = "UPDATE dbo.Orders set statusorder = @statusorder where id = @id";
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@statusorder", SqlDbType.VarChar);
                command.Parameters["@statusorder"].Value = status;
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = id;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public string CalculateCartPrice(int orderID)
        {
            string cartPrice;
            string queryString = "SELECT SUM(dbo.Furnitures.price) FROM dbo.Furnitures INNER JOIN dbo.OrderItems " +
                "on dbo.Furnitures.id = dbo.OrderItems.furnitureID and orderID = @orderID;";
            var connection = DBConnection.GetConnection;
            var command = new SqlCommand(queryString, connection);
            command.Parameters.Add("@orderID", SqlDbType.Int);
            command.Parameters["@orderID"].Value = orderID;

            connection.Open();
            var result =  command.ExecuteScalar();
            if (result != null)
            {
                cartPrice = result.ToString();
                return cartPrice;
            }
            connection.Close();
            return null;
            
        }


        public void DeleteItemFromCart(int orderID, int furnitureID, int id)
        { 
            string queryString = "DELETE FROM dbo.OrderItems where orderID = @orderID and furnitureID = @furnitureID and id = @id;";
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@orderID", SqlDbType.Int);
                command.Parameters["@orderID"].Value = orderID;
                command.Parameters.Add("@furnitureID", SqlDbType.Int);
                command.Parameters["@furnitureID"].Value = furnitureID;
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = id;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable DisplayAllCartItems(int userID)
        {
            using (var connection = DBConnection.GetConnection)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("SELECT id as 'Order Item ID', orderID as 'Order ID', furnitureID as 'Furniture ID'" +
                    "FROM dbo.OrderItems WHERE orderID = {0};", this.LastOrder(userID));
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable DisplayAllOrdersInClientDash(int userID)
        {
            using (var connection = DBConnection.GetConnection)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("SELECT id as 'Order ID', totalprice as 'Order Price', statusorder as 'Order Status', orderfeedback as 'Feedback'" +
                    "FROM dbo.Orders WHERE userID = {0} and statusorder NOT LIKE @statusorder;", userID);
                cmd.Parameters.Add("@statusorder", SqlDbType.VarChar);
                cmd.Parameters["@statusorder"].Value = ORDER_CREATING;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        public int GetOrderID(int userID)
        {
            using (var connection = DBConnection.GetConnection)
            {
                int result;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("SELECT orderID from dbo.OrderItems WHERE orderID = {0};", this.LastOrder(userID));
                result = (int)cmd.ExecuteScalar();
                return result;
            }
        }

        public DataTable DisplayAllOrdersInAdminDash()
        {
            using (var connection = DBConnection.GetConnection)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT dbo.Orders.id as 'Order Number', userID as 'User Identifier', dbo.Users.username as 'Client Username', CONCAT(dbo.Users.firstname, ' ', dbo.Users.lastname) as 'Client Name', totalprice as 'Order price', statusorder as 'Order Status' " +
                    "FROM dbo.Orders INNER JOIN dbo.Users on dbo.Orders.userID = dbo.Users.id where statusorder NOT LIKE @statusorder;";
                cmd.Parameters.Add("@statusorder", SqlDbType.VarChar);
                cmd.Parameters["@statusorder"].Value = ORDER_CREATING;
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void GiveFeedbackToOrder(int orderID, string orderfeedback)
        {
            string queryString = "UPDATE dbo.Orders set orderfeedback = @orderfeedback where id = @id";
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@orderfeedback", SqlDbType.VarChar);
                command.Parameters["@orderfeedback"].Value = orderfeedback;
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = orderID;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
