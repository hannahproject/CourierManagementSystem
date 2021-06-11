using System;

namespace SOC
{
    class User
    {
        public string username{get;set;}
        public string password{get;set;}
        public char choice {get;set;}

        public void ToLogin()
        {
            Console.Write($"Username: ");
            string getUsername = Console.ReadLine();
            Console.Write($"Password: ");
            string getPassword = Console.ReadLine();

            if(getUsername==username || getPassword==password)
            {
                Dashboard();
            }

            else
            {
                Console.WriteLine($"\nInvalid input."); 
            }
        }

        public void Dashboard()
        {
            Console.WriteLine($"Welcome to your account! What feature/s would you like to use? ");
            Console.WriteLine($"A - VIEW PENDING LIST \nB - SEARCH PARCEL ID \nC - VIEW EARNED DEL. FEE \nD - LOGOUT");
            Console.Write("INPUT: ");
            choice = Convert.ToChar(Console.ReadLine());
            choice = Char.ToUpper(choice);
        }

    }
}