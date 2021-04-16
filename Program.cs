using System;

namespace Courier_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string riderFName, riderLName, riderContactNum, senderContactNum, senderItem, senderAddress;
            char choice;
            int addClient, contactLength;

            Console.WriteLine("Welcome to iDrop! Log into your account now!");

            Console.Write("First Name: ");
            riderFName = Console.ReadLine();

            Console.Write("Last Name: ");
            riderLName = Console.ReadLine();

            Console.Write("Contact Number (Enter an 11 digit phone number): ");
            riderContactNum = Console.ReadLine();
            contactLength = riderContactNum.Length;

            if(contactLength==11){

                Console.WriteLine("\nWelcome to your iDrop Account, " + riderFName + " " + riderLName + "!");
                Console.WriteLine("A - Enter Client Details \nB - View my Profile");
                Console.Write("What iDrop Services would you like to use? " + "\n");
                choice = Convert.ToChar(Console.ReadLine());
                choice = Char.ToUpper(choice);

                switch(choice){
                    case 'A':
                        Console.Write("How many clients would you like to add?: ");
                        addClient = Convert.ToInt32(Console.ReadLine());

                        string [] storeClient = new string[addClient];
                        
                        for(int i=0; i < storeClient.Length; i++){
                            Console.Write("\nClient Name: ");
                            storeClient[i]=Console.ReadLine();
                            Console.Write("Address: ");
                            senderAddress = Console.ReadLine();
                            Console.Write("Contact Number: ");
                            senderContactNum = Console.ReadLine();
                            Console.Write("Item: ");
                            senderItem = Console.ReadLine();
                            Console.WriteLine("\nNew Client Added!");
                        }

                        if(storeClient.Length==addClient){
                            Console.WriteLine("\nYou've reached the limit.");
                            Console.WriteLine("Items Waiting to be Delivered: " + storeClient.Length);
                        }
                        break;

                    case 'B':
                        Console.WriteLine("\nRider Information: ");
                        Console.WriteLine("Rider Name: " + riderFName + " " + riderLName);
                        Console.WriteLine("Contact Number: " + riderContactNum);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

            else{
                Console.WriteLine("Sorry, the number you provided is invalid. You cannot to proceed.");
            }
        }
    }
}
