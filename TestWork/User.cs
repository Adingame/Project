using System;
using System.Collections.Generic;
using System.Text;

namespace TestWork
{
    public class User
    {
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string fullName, string phoneNumber, string email, string password)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
        }
    }
}
