using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProgram
{
    class Pattern
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        public void validateName(string name)
        {
            if (Regex.IsMatch(name, Name))
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid name");
            }
        }
        public void validateEmail(string email)
        {
            if (Regex.IsMatch(email, EmailId))
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("invalid email");
            }
        }
    }
}
