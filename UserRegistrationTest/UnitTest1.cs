using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProgram;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void when_all_DetailsAreCorrect_should_return_Valid()
        {
            Pattern pattern = new Pattern();
            string firstNameTest = pattern.validateName("Kartik");
            string lastNameTest = pattern.validateName("Nawal");
            string mobileTest = pattern.validateMobile("91 8209685692");
            string emailTest = pattern.validateEmail("kartiknawal233@gmail.com");
            string passwordTest = pattern.validatePassword("Bdety@236");

            Assert.AreEqual("Valid", firstNameTest);
            Assert.AreEqual("Valid", lastNameTest);
            Assert.AreEqual("Valid", mobileTest);
            Assert.AreEqual("Valid", emailTest);
            Assert.AreEqual("Valid", passwordTest);
        }

        [TestMethod]
        public void when_all_DetailsAreIncorrect_format_should_return_Invalid()
        {
            Pattern pattern = new Pattern();
            string firstNameTest = pattern.validateName("Ka");
            string lastNameTest = pattern.validateName("k");
            string mobileTest = pattern.validateMobile("91 342");
            string emailTest = pattern.validateEmail("kaffds");
            string passwordTest = pattern.validatePassword("ssda");

            Assert.AreEqual("Invalid", firstNameTest);
            Assert.AreEqual("Invalid", lastNameTest);
            Assert.AreEqual("Invalid", mobileTest);
            Assert.AreEqual("Invalid", emailTest);
            Assert.AreEqual("Invalid", passwordTest);
        }

        [TestMethod]

        [DataRow("abc@gmail.com")]
        [DataRow("ac33@gmail.com")]
        [DataRow("abc123ssw@gmail.com")]
        [DataRow("abc.123@gmail.co.in")]
        [DataRow("abc123@gil.com")]
        [DataRow("abc+23@gil.com")]
        public void Multiple_Email_Enteries(string email)
        {
            Pattern pattern = new Pattern();
            string result = pattern.validateEmail(email);
            Assert.AreEqual("Valid", result);
        }
        [TestMethod]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string name = string.Empty;
                Pattern pattern = new Pattern();
                string result = pattern.validateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string name = null;
                Pattern pattern = new Pattern();
                string result = pattern.validateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string name = string.Empty;
                Pattern pattern = new Pattern();
                string result = pattern.validateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string name = null;
                Pattern pattern = new Pattern();
                string result = pattern.validateName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Name should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string email = string.Empty;
                Pattern pattern = new Pattern();
                string result = pattern.validateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                string email = null;
                Pattern pattern = new Pattern();
                string result = pattern.validateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email should not be null", e.Message);
            }
        }
        public void Given_Empty_Mobile_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string mobile = string.Empty;
                Pattern pattern = new Pattern();
                string result = pattern.validateMobile(mobile);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Mobile Number should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Mobile_Should_Throw_UserRegistrationException()
        {
            try
            {
                string mobile = null;
                Pattern pattern = new Pattern();
                string result = pattern.validateMobile(mobile);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Mobile Number should not be null", e.Message);
            }
        }
        public void Given_Empty_Password_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string password = string.Empty;
                Pattern pattern = new Pattern();
                string result = pattern.validatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Password_Should_Throw_UserRegistrationException()
        {
            try
            {
                string password = null;
                Pattern pattern = new Pattern();
                string result = pattern.validatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password should not be null", e.Message);
            }
        }
    }
}
