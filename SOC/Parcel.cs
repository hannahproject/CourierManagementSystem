using System;

namespace SOC
{
    class Parcel
    {
        //CONSTRUCTOR
        public Parcel()
        {
            parcelcounter++; //INCREMENTS EVERYTIME PARCEL INSTATIATES
            this.parcelid = "PRCL" + parcelcounter; //ASSIGNS VALUE TO THE parcelid PROPERTY
            this.delfee = 40.00; //ASSIGNS THE FEE PER PARCEL
        }

        static int parcelcounter;
        private string parcelid;
        private double delfee;
        public string clientname {get;set;}
        public string address { get; set; }
        

        public Category category {get;set;}

        public enum Category
        {
            Food, Beverage, Clothes, Accessory, Appliance, Furniture, Gadget
        }

        //MAKES PARCEL ID/DEL FEE ACCESSIBLE OUTSIDE THE CLASS
        public string ParcelID
        {   
            get
            {
                return parcelid;
            }
        }

        public double DelFee
        {   
            get
            {
                return delfee;
            }
        }
    }
}