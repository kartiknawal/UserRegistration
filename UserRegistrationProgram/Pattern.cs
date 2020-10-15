using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProgram
{
    class Pattern
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
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
    }
}
