using System;

namespace CMS_OOP
{
    class User
    {
        public string username {get;set;}
        public string password {get;set;}
        public char choice {get;set;}

        public void ToLogin()
        {
            Console.Write("Username: ");
            string getusername = Console.ReadLine();
            Console.Write("Password: ");
            string getpassword = Console.ReadLine();

            if(username==getusername && password==getpassword)
            {
                Dashboard();
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void Dashboard()
        {
            Console.WriteLine("\nWelcome to your account! What feature/s would you like to use? ");
            Console.WriteLine("A - VIEW PENDING LIST \nB - SEARCH PARCEL ID \nC - VIEW EARNINGS \nD - LOGOUT");
            Console.Write("\nINPUT: ");
            choice = Convert.ToChar(Console.ReadLine());
            choice = Char.ToUpper(choice);
        }
    }
}
