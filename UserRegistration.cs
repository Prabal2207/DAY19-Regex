using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistration
    {

        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public static string Regex_email = "^[A-Za-z]{1,}[@][A-Za-z0-9]{3,}[.][A-Za-z]{3,}$";
        public static string Regex_PhoneNumber = "^([9][1])[ ]^[6-9][0-9]{9}$";
        public static string Regex_Password = "^[A-Za-z]{1,}([.!#$%&+-_][A-Za-z0-9]{1,})*[@][A-Za-z0-9]{1,}[.][A-Za-z]{2,}([.][A-Za-z]{2,})*$";

        public static bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }


        public static void checkFirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
            {
                Console.WriteLine("Enter valid First name. It should Start with capital letters and minimum 3 letters!");
            }
            else
            {
                Console.WriteLine("It is Valid!");
            }
        }


        public static bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }

        public static void checkLastName(string LastName)
        {
            if (Regex.IsMatch(LastName, Regex_LastName) == false)
            {
                Console.WriteLine("Enter valid Last name. It should Start with capital letters and minimum 3 letters!");
            }
            else
            {
                Console.WriteLine("It is Valid!");
            }
        }
        public static bool Validateemail(string email)
        {
            return Regex.IsMatch(email, Regex_email);
        }

        public static void checkemail(string email)
        {
            if (Regex.IsMatch(email, Regex_email) == false)
            {
                Console.WriteLine("Enter valid email");
            }
            else
            {
                Console.WriteLine("It is Valid!");
            }
        }

        public static bool ValidatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);
        }

        public static void checkPhoneNumber(string PhoneNumber)
        {
            if (Regex.IsMatch(PhoneNumber, Regex_PhoneNumber) == false)
            {
                Console.WriteLine("Enter valid PhoneNumber");
            }
            else
            {
                Console.WriteLine("It is Valid!");
            }
        }

        public static bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password,Regex_Password);
        }

        public static void checkPassword(string Password)
        {
            if (Regex.IsMatch(Password,Regex_Password) == false)
            {
                Console.WriteLine("Enter valid Password");
            }
            else
            {
                Console.WriteLine("It is Valid!");
            }
        }


    }
}
