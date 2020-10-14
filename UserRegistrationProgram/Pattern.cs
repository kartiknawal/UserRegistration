using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProgram
{
    class Pattern
    {
        string firstName = "^[A-Z][a-z0-9A-Z]{3,}";
        public void validateFirstName(string fname)
        {
            if (Regex.IsMatch(fname, firstName))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
        }
    }
}
