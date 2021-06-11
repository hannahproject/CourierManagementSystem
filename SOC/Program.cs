using System;

namespace SOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE PARCEL
            Parcel parcel1 = new Parcel();
            parcel1.clientname="Hannah";
            parcel1.address="Dela Paz";
            parcel1.category = Parcel.Category.Food;

            Parcel parcel2 = new Parcel();
            parcel2.clientname="Aliyah";
            parcel2.address="Dela Paz";
            parcel2.category = Parcel.Category.Clothes;

            Parcel parcel3 = new Parcel();
            parcel3.clientname="Judea";
            parcel3.address="Malaban";
            parcel3.category = Parcel.Category.Furniture;

            Parcel parcel4 = new Parcel();
            parcel4.clientname="Elton";
            parcel4.address="Zapote";
            parcel4.category = Parcel.Category.Gadget;

            Parcel parcel5 = new Parcel();
            parcel5.clientname="Jerrica";
            parcel5.address="Dela Paz";
            parcel5.category = Parcel.Category.Food;

            Parcel parcel6 = new Parcel();
            parcel6.clientname="Erika";
            parcel6.address="San Antonio";
            parcel6.category = Parcel.Category.Appliance;

            //ADD PARCELS TO THE LIST
            ListRegulation lr = new ListRegulation();
            lr.AddParcel(parcel1);
            lr.AddParcel(parcel2);
            lr.AddParcel(parcel3);
            lr.AddParcel(parcel4);
            lr.AddParcel(parcel5);
            lr.AddParcel(parcel6);

            User user = new User();
            user.username = "admin";
            user.password = "test";
            user.ToLogin();

            switch(user.choice)
            {
                case 'A':
                    lr.ToDisplayPendingList();
                break;
                
                case 'B':
                break;

                case 'C':
                    lr.ToDisplayTotalIncome();
                break;

                default:
                    Console.WriteLine($"Invalid input.");
                break;
            }
        }
    }
}
