using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration!");

            string FirstName, LastName,email,PhoneNumber;
            
            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();

            UserRegistration.checkFirstName(FirstName);


            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();
            UserRegistration.checkLastName(LastName);


            Console.Write("Enter your email addresss: ");
            email = Console.ReadLine();
            UserRegistration.checkemail(email);
            

            Console.Write("Enter your  Phone number: ");
            PhoneNumber = Console.ReadLine();
            UserRegistration.checkPhoneNumber(PhoneNumber);
            Console.ReadKey();



        }
    }
}
