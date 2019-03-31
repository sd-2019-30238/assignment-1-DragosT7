using BestFurnitureDeals2._0.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFurnitureDeals2._0.PresentationLayer
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }


        private void signInButton_Click(object sender, EventArgs e)
        {
            var username = this.usernameText.Text;
            var password = this.passwordText.Text;

            string queryString = "SELECT id, username, isadmin FROM dbo.Users where username=@username and password=@password;";
            using (var connection = BestFurnitureDeals2._0.DataAccess.DatabaseConnection.DBConnection.GetConnection)
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar);
                command.Parameters["@username"].Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar);
                command.Parameters["@password"].Value = password;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var isadmin = reader.GetBoolean(2);
                        Utils.userID = reader.GetInt32(0);
                        if (isadmin)
                        {
                            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
                            adminDashboardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            ClientViewForm clientViewForm = new ClientViewForm();
                            clientViewForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        var caption = "Error Detected in Input";
                        MessageBox.Show("User-ul nu a fost gasit in baza de date. Verificati din nou credentialele!", caption, MessageBoxButtons.OK);
                    }
                }
                connection.Close();
            }
            Utils.PrevForm = this;

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            Utils.PrevForm = this;
            this.Hide();
        }
    }
}
