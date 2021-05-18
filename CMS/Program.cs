using System;

namespace CMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE PARCEL
            Parcel parcel1 = new Parcel("Hannah", "Dela Paz");
            parcel1.category = Parcel.Category.Food;
            Parcel parcel2 = new Parcel("Aliyah", "San Antonio");
            parcel2.category = Parcel.Category.Clothes;
            Parcel parcel3 = new Parcel("Kate", "San Jose");
            parcel3.category = Parcel.Category.Furniture;
            Parcel parcel4 = new Parcel("Elton", "Malaban");
            parcel4.category = Parcel.Category.Gadget;
            Parcel parcel5 = new Parcel("Judea", "San Vicente");
            parcel5.category = Parcel.Category.Food;
            Parcel parcel6 = new Parcel("Erika", "Sto Domingo");
            parcel6.category = Parcel.Category.Appliance;

            //ADD PARCELS TO THE LIST
            Delivery addtolist = new Delivery();
            addtolist.AddParcel(parcel1);
            addtolist.AddParcel(parcel2);
            addtolist.AddParcel(parcel3);
            addtolist.AddParcel(parcel4);
            addtolist.AddParcel(parcel5);
            addtolist.AddParcel(parcel6);

            //DISPLAYS LOGIN FORM
            User user = new User();
            user.username = "admin";
            user.password = "test";

            user.ToLogin();
    
            switch(user.choice)
            {
                case 'A':
                    addtolist.DisplayPending(); //DISPLAYS PENDING LIST
                    user.Dashboard();
                break;

                case 'B':
                    Console.WriteLine("This feature is under maintenance.");
                break;

                case 'C':
                    //SEARCH
                break;

                case 'D':
                    addtolist.Wallet(); //DISPLAYS TOTAL OF DELIVERY FEE
                break;

                default:
                    Console.WriteLine("Invalid input.");
                break;
            }
        }
    }
}
