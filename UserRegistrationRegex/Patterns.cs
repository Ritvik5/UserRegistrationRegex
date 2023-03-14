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
        public static string Regex_Rule = "^[+]?[0-9-]{1,7}[ ][6-9][0-9]{9}$";

        public bool ValidateFirstName(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }
    }
}
