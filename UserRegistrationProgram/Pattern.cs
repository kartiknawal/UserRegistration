using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProgram
{
    public class Pattern
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        string mobileNo = "[0-9]{1,3}[ ][1-9]{1}[0-9]{9}";
        string Password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()]){1}[a-zA-Z0-9]{5,}";

        public string validateName(string name)
        {
            if (Regex.IsMatch(name, Name))
            {
                Console.WriteLine("Valid name");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Invalid name");
                return "Invalid";
            }
        }
        public string validateEmail(string email)
        {
            if (Regex.IsMatch(email, EmailId))
            {
                Console.WriteLine("Valid email");
                return "Valid";
            }
            else
            {
                Console.WriteLine("invalid email");
                return "Invalid";
            }
        }
        public string validateMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, mobileNo))
            {
                Console.WriteLine("mobile number is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("mobile number not valid");
                return "Invalid";
            }
        }
        public string validatePassword(string password)
        {
            if (Regex.IsMatch(password, Password))
            {
                Console.WriteLine("Valid password");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Invalid password");
                return "Invalid";
            }
        }
    }
}
