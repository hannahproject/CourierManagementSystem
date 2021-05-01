using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string userID = "000K1";
            string userPassword = "test";
            string userName = "Hannah Liwanag";
            string getID, getPassword, getName;

            Console.WriteLine("Welcome to Katok Rider Hub! Login to your account now!");
            Console.Write("\nName: ");
            getName = Console.ReadLine();
            Console.Write("User ID: ");
            getID = Console.ReadLine();
            Console.Write("Password: ");
            getPassword = Console.ReadLine();

            if(getName == userName && getID == userID && getPassword == userPassword){
                Home();
            }

            else{
                Console.WriteLine("\nInvalid input.");
            }
        }
        static void Home(){
            Console.WriteLine("\n What Katok feature would you like to use? \nA - View Client List \nB - Find a Client \nC - Logout");
            char choice = Convert.ToChar(Console.ReadLine());
            choice = Char.ToUpper(choice);

            switch(choice){

                case 'A':
                    DisplayClients();
                break;

                case 'B':
                    FindClient();
                break;

                case 'C':
                    Logout();
                break;

                default:
                    Console.WriteLine("Invalid Input. Restart the Program.");
                break;
            }

        }
        static List<string> ClientDB(){
            var clientList = new List<string>(){"Judea","Aliyah","Elton","Erika","Jerrica","Jing","Ren"};
            return clientList;
        }
        static void DisplayClients(){
            Console.WriteLine($"\nList of Clients:");
            foreach (var client in ClientDB()){
                Console.WriteLine(client);
            }
            Home();
        }
        static void FindClient(){
            string find;

            Console.WriteLine("\nSearch Client Name: ");
            find = Console.ReadLine();

            if(ClientDB().Contains(find)){
                Console.WriteLine($"\nClient {find} is already in your client list.");
                Home();
            }

            else{
                Console.WriteLine($"\nClient {find} is not in your client list.");
                Home();
            }
        }

        static void Logout(){
            Console.WriteLine("\nLogging out now...");
            System.Environment.Exit(0);
        }
    }
}
