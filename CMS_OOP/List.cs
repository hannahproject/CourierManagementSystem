using System;
using System.Collections.Generic;

namespace CMS_OOP
{
    class List
    {
        private List <Parcel> parcelList = new List <Parcel>();

        public void AddParcel (Parcel parcel)
        {
            parcelList.Add(parcel);
        }

        public List <Parcel> GetList()
        {
            return parcelList;
        }

        /*I TRIED TO CREATE A SEPARATE CLASS KUNG SAAN KO PO PWEDENG ILAGAY ANG MGA METHOD NA NAGDIDISPLAY NG LAMAN NG LIST
        PERO HINDI PO ITO LUMALABAS UNLESS ISAMA KO SILA SA CLASS NA PINAGLALAGYAN NUNG LIST OF OBJECTS*/

        public void ToDisplayPending()
        {
            Console.WriteLine();
            foreach (var item in GetList())
            {
                Console.WriteLine("PARCEL ID:" + item.ParcelID);
                Console.WriteLine("NAME:" + item.clientname);
                Console.WriteLine("ADD:" + item.address);
                Console.WriteLine("CATEGORY:" + item.category);
                Console.WriteLine("CHARGE:" + item.DelFee);
                Console.WriteLine("--------------------");
            }
        }

        public void SearchParcelID()
        {
            Console.Write("\nEnter Parcel ID: ");
            string target = Console.ReadLine().ToUpper();

            Parcel findParcel = GetList().Find(_parcelid => _parcelid.ParcelID.Equals(target));

            if(findParcel != null)
            {
                Console.WriteLine("\n----------------------------");
                Console.WriteLine($"\n{target} is on your list!");
            }

            else
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine($"\n{target} is not on your list!"); 
            }
        }

        public double Total
        {
            get
            {
                return ComputeTotalFee(); //RETURNS WHAT FUNCTION OF THE METHOD
            }
        }

        public double ComputeTotalFee()
        {
            var total = 0.0;
            foreach(var item in GetList())
            {
                total += item.DelFee;
            }
            return total;
        }

        public void DisplayEarnings()
        {
            Console.WriteLine($"Total Earnings: {Total}");
        }
    }
}
