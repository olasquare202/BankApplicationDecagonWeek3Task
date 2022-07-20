using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankApplication.Utilities
{
    public static class Validation
    {
        public static bool IsValidEmail(string email)
        {
            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            return regex.IsMatch(email);
        }
        public static bool IsValidPhoneNumber(string phone)
        {
            Regex regex = new Regex("/((^090)([23589]))|((^070)([1-9]))|((^080)([2-9]))|((^081)([0-9]))(d{7})");
            return regex.IsMatch(phone) && phone.Length == 11;

        }

        public static bool IsValidPassword(string password)
        {
            Regex regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$");
            return regex.IsMatch(password);
        }

        public static bool IsValidName(string name)
        {
            Regex isValid = new Regex("^[A-Z][a-zA-Z]*$");
            return isValid.IsMatch(name);
        }

        public static bool IsComfirmedPassword(string password1, string password2)
        {
            return password1 == password2;
        }

        public static bool IsValidAmount(string amount)
        {
           return Decimal.TryParse(amount, out decimal amountt);
        }

        public static bool IsValidCommand(string command)
        {
            return Int32.TryParse(command, out int cm);
        }
        
    }

    
}
