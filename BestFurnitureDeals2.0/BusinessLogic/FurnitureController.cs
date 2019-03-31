using BestFurnitureDeals2._0.DataAccess.DataAccessObjects;
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
    class FurnitureController
    {
        public DataTable DisplayAllFurniture()
        {
            using (var connection = DBConnection.GetConnection)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id as 'Furniture ID', namefurniture as 'Furniture Name', descriptionfurniture as 'Description', typefurniture as 'Type of Furniture', price as 'Price', seller as 'Seller', nrofproducts as 'Number of products' FROM dbo.Furnitures";
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void CreateFurniture(Furniture furniture)
        {
            string queryString = "INSERT INTO dbo.Furnitures(namefurniture, descriptionfurniture, typefurniture, price, seller, nrofproducts)" +
                "values(@namefurniture, @descriptionfurniture, @typefurniture, @price, @seller, @nrofproducts);";
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@namefurniture", SqlDbType.VarChar);
                command.Parameters["@namefurniture"].Value = furniture.NameFurniture;
                command.Parameters.Add("@descriptionfurniture", SqlDbType.VarChar);
                command.Parameters["@descriptionfurniture"].Value = furniture.DescriptionFurniture;
                command.Parameters.Add("@typefurniture", SqlDbType.VarChar);
                command.Parameters["@typefurniture"].Value = furniture.TypeFurniture;
                command.Parameters.Add("@price", SqlDbType.Float);
                command.Parameters["@price"].Value = furniture.Price;
                command.Parameters.Add("@seller", SqlDbType.VarChar);
                command.Parameters["@seller"].Value = furniture.Seller;
                command.Parameters.Add("@nrofproducts", SqlDbType.VarChar);
                command.Parameters["@nrofproducts"].Value = furniture.NumberOfProducts;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateFurniture(Furniture furniture)
        {
            string queryString = "UPDATE dbo.Furnitures SET namefurniture = @namefurniture, descriptionfurniture = @descriptionfurniture, " +
                "typefurniture = @typefurniture, price = @price, seller = @seller, nrofproducts = @nrofproducts where id = @id;";
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = furniture.FurnitureID;
                command.Parameters.Add("@namefurniture", SqlDbType.VarChar);
                command.Parameters["@namefurniture"].Value = furniture.NameFurniture;
                command.Parameters.Add("@descriptionfurniture", SqlDbType.VarChar);
                command.Parameters["@descriptionfurniture"].Value = furniture.DescriptionFurniture;
                command.Parameters.Add("@typefurniture", SqlDbType.VarChar);
                command.Parameters["@typefurniture"].Value = furniture.TypeFurniture;
                command.Parameters.Add("@price", SqlDbType.Float);
                command.Parameters["@price"].Value = furniture.Price;
                command.Parameters.Add("@seller", SqlDbType.VarChar);
                command.Parameters["@seller"].Value = furniture.Seller;
                command.Parameters.Add("@nrofproducts", SqlDbType.VarChar);
                command.Parameters["@nrofproducts"].Value = furniture.NumberOfProducts;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteFurniture(int furnitureID)
        {
            string queryString = "DELETE FROM dbo.Furnitures where id = @id;";
            using (var connection = DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = furnitureID;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}