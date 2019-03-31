using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFurnitureDeals2._0.DataAccess.DataAccessObjects
{
    class User
    {
        private string username;
        private string password;
        private bool isAdmin;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string address;

        public User(string username, bool isAdmin, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            this.username = username;
            this.isAdmin = isAdmin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public User(string username, string password, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
    }
}
