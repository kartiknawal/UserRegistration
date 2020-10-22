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
            try
            {
                if (name.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Name should not be empty");
                }

                else if (Regex.IsMatch(name, Name))
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
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Name should not be null");
            }

        }
        public string validateEmail(string email)
        {
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Email should not be empty");
                }
                else if (Regex.IsMatch(email, EmailId))
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
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Name should not be null");
            }
        }
        public string validateMobile(string mobile)
        {
            try
            {
                if (mobile.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Mobile Number should not be empty");
                }
                else if (Regex.IsMatch(mobile, mobileNo))
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
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Email should not be null");
            }
        }
        public string validatePassword(string password)
        {
            try
            {
                if (password.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                else if (Regex.IsMatch(password, Password))
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
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }

        }
        public bool ValidateNameUsingLambda(string name) => Regex.IsMatch(name, Name) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_NAME, "Invalid Name");
        public bool ValidateEmailUsingLambda(string email) => Regex.IsMatch(email, EmailId) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        public bool ValidateMobileUsingLambda(string mob) => Regex.IsMatch(mob, mobileNo) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        public bool ValidatePasswordUsingLambda(string pw) => Regex.IsMatch(pw, Password) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
    }
}
