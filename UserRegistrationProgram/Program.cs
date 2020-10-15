using System;

namespace UserRegistrationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regex User Registration Problem");
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter the first name");
            string fname = Console.ReadLine();
            pattern.validateName(fname);
            Console.WriteLine("Enter the Last name");
            string lastName = Console.ReadLine();
            pattern.validateName(lastName);
        }
    }
}
