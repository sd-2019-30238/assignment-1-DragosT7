using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BestFurnitureDeals2._0.DataAccess.DatabaseConnection
{
    class DBConnection
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public static SqlConnection GetConnection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
