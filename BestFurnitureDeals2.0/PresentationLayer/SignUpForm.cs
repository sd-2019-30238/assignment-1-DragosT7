using BestFurnitureDeals2._0.Commons;
using BestFurnitureDeals2._0.DataAccess.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFurnitureDeals2._0.PresentationLayer
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var username = this.usernameText.Text;
            var password = this.passwordText.Text;
            var repeatPassword = this.repeatPasswordText.Text;
            var firstName = this.firstNameText.Text;
            var lastName = this.lastNameText.Text;
            var phoneNumber = this.phoneNumberText.Text;
            var email = this.emailText.Text;
            var address = this.addressRichText.Text;

            StringBuilder stringBuilder = new StringBuilder();

            if (!Validators.ValidateText(username))
            {
                stringBuilder.Append("Username required.\n");
            }
            if (!Validators.ValidateText(password))
            {
                stringBuilder.Append("Password required.\n");
            }
            if (!Validators.ValidateText(repeatPassword))
            {
                stringBuilder.Append("Repeat password required.\n");
            }
            if (!Validators.ValidateText(firstName))
            {
                stringBuilder.Append("First Name required.\n");
            }

            if (!Validators.ValidateText(lastName))
            {
                stringBuilder.Append("Last Name required.\n");
            }

            if (!Validators.ValidateEmail(email))
            {
                stringBuilder.Append("Email address is in invalid format.\n");
            }

            if (!Validators.ValidatePhoneNumber(phoneNumber))
            {
                stringBuilder.Append("Phone number is in invalid format.\n");
            }

            if (!Validators.ValidateText(address))
            {
                stringBuilder.Append("Address required.\n");
            }

            if (stringBuilder.Length != 0)
            {
                string caption = "Error detected in input. Try again!";
                MessageBox.Show(stringBuilder.ToString(), caption, MessageBoxButtons.OK);
                return;
            }

            User user = new User(username.ToString(), password.ToString(), firstName.ToString(), lastName.ToString(),
                email.ToString(), phoneNumber.ToString(), address.ToString());
            var userController = Utils.UserController;
            userController.CreateUser(user);

            Utils.PrevForm.Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Utils.PrevForm.Show();
        }
    }
}
