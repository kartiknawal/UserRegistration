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
        string mobileNo = "[0-9]{1,3}[ ][1-9]{1}[0-9]{9}";
        string Password = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{6,}$";
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
        public void validateMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, mobileNo))
            {
                Console.WriteLine("mobile number is valid");
            }
            else
            {
                Console.WriteLine("mobile number not valid");
            }
        }
        public void validatePassword(string password)
        {
            if (Regex.IsMatch(password, Password))
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }
    }
}
