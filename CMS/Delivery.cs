using System;
using System.Collections.Generic;

namespace CMS
{
    class Delivery
    {
        private List<Parcel> ParcelList = new List<Parcel>();
        
        //TO ADD ITEMS TO THE PRIVATE LIST
        public void AddParcel(Parcel parcel)
        {
            ParcelList.Add(parcel);
        }

        //TO MAKE THE LIST ACCESSIBLE
        public List<Parcel> GetList()
        {
            return ParcelList;
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

        //CALL THIS METHOD TO DISPLAY THE LIST
        public void DisplayPending()
        {
            Console.WriteLine();
            foreach(var item in GetList())
            {
                Console.WriteLine("PARCEL ID:" + item.ParcelID);
                Console.WriteLine("NAME:" + item.clientname);
                Console.WriteLine("ADD:" + item.address);
                Console.WriteLine("CATEGORY:" + item.category);
                Console.WriteLine("CHARGE:" + item.DelFee);
                Console.WriteLine("--------------------");
            }
        }

        //CALL THIS METHOD TO DISPLAY THE TOTAL OF DEL. FEE
        public void Wallet()
        {
            Console.WriteLine($"\nTOTAL FEE: {Total}");
            
        }
    }
}