using System;
using AtHome.Services.Interfaces;

namespace AtHome.Services
{
    public class AccountService : IAccountService
    {
        public string Login(string username, string password)
        {
            if (username == "Ali19" && password == "Salam1234567")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Successfully login";
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Incorrect username or password";
            }
        }
    }
}

