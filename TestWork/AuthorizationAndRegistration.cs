using System;
using System.Collections.Generic;
using System.Text;

namespace TestWork
{
    static class AuthorizationAndRegistration
    {
        public static void checkIn(User[] authorizationsUsers)
        {
            string fullName, email, password, phoneNumber;

            string reenterPassword;

            bool passwordChecker = false;

            Console.WriteLine("Enter your full name: ");
            fullName = Console.ReadLine();

            Console.WriteLine("Enter your email: ");
            email = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();

            Console.WriteLine("Enter your phone number: ");
            phoneNumber = Console.ReadLine();

            while (!passwordChecker)
            {
                Console.WriteLine("Re-enter Password");
                reenterPassword = Console.ReadLine();
                if (reenterPassword == password)
                {
                    Console.WriteLine("Ok, you registered");
                    passwordChecker = true;
                }
            }

            var newUser = new User(fullName, phoneNumber, email, password);

        }

        public static bool LoginToAccount(User userAccount, string password, string login)
        {
            if (userAccount.Email == login && userAccount.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
