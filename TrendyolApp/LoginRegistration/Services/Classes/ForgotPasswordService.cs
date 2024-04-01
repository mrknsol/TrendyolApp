using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace TrendyolApp.Services.Classes
{
    public class ForgotPasswordService
    {
        public bool IsPasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        }

        public bool IsInputValid(string password)
        {
            return IsPasswordValid(password);
        }

        public string ValidateInput(string password, string confirmNewPassword)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.");
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 8 characters.");
                password = "";
                confirmNewPassword = "";
            }

            return null;
        }

    }
}
