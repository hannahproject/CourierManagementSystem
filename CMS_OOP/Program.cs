using System;

namespace CMS_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.username = "admin";
            user1.password = "test";

            user1.ToLogin(); 

            Parcel parcel1 = new Parcel();
            parcel1.clientname = "Hannah";
            parcel1.address = "Dela Paz";
            parcel1.category = Parcel.Category.Food;

            Parcel parcel2 = new Parcel();
            parcel2.clientname = "Jerrica";
            parcel2.address = "Malaban";
            parcel2.category = Parcel.Category.Gadget;

            Parcel parcel3 = new Parcel();
            parcel3.clientname = "Aliyah";
            parcel3.address = "San Jose";
            parcel3.category = Parcel.Category.Furniture;

            List list1 = new List();
            list1.AddParcel(parcel1);
            list1.AddParcel(parcel2);
            list1.AddParcel(parcel3);

            // Earnings earned = new Earnings();
            UI ui = new UI();

            switch (user1.choice)
            {
                case 'A':
                    list1.ToDisplayPending();
                break;

                case 'B':
                    list1.SearchParcelID();
                break;

                case 'C':
                    list1.DisplayEarnings();
                break;

                case 'D':
                    ui.ToLogout();
                break;

                default:
                    Console.WriteLine("Wrong input. Please try again.");
                break;
            }
        }
    }
}
