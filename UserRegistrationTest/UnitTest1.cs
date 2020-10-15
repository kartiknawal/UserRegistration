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
    }
}
