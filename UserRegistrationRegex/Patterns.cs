using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Patterns
    {
        public static string Regex_Rule = "^[A-Z][a-z]{2,}$";

        public bool ValidateFirstName(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }
    }
}
