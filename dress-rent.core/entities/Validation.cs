using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dress_rent.core.entities
{
    public class Validation
    {
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^0[2-9]\d{7}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}