using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPatternValidationDemo
{
    public class Patterns
    {
        public static string REGEX_PINCODE = "^[1-9][0-9]{5}";
        public bool validationPincode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}
