using System;

namespace CMS
{
    class User
    {
        public string username{get;set;}
        public string password{get;set;}
        public char choice {get;set;}

        public void ToLogin()
        {
            Console.Write("USERNAME: ");
            string getusername = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string getpassword = Console.ReadLine();

            if(username==getusername && password==getpassword)
            {
                Dashboard();
            }

            else
            {
                Console.WriteLine("\nIncorrect username of password."); 
            }
        }

        public void Dashboard()
        {
            Console.WriteLine("\nWelcome to your account! What feature would you like to use? ");
            Console.WriteLine("A - VIEW PENDING LIST \nB - UPDATE LIST \nC - SEARCH FOR A PARCEL \nD - VIEW WALLET");
            Console.Write("INPUT: ");
            
            choice = Convert.ToChar(Console.ReadLine());
            choice = Char.ToUpper(choice);
        }
    }
}