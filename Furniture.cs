using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExampleFurniture
{
    // Super class
    class Furniture
    {
        //Properties

        //using private set to protect it from accidently getting modified
        // private means only code inside class (Furniture) can modify it
        // get remains public because the Weight is information that all should be allowed to acces
        public int Weight
        { get; private set; }


        public int Price
        { get; private set; }

        //Constructors

        public Furniture(int weight = 0, int price = 0)
        {
            Weight = weight;
            Price = price;
        }


        //Methods

        public int UpdatePrice(int price)
        {
            Price = price;
            return Price;
        }



        // virtual enables it to be overridden in subclasses
        public virtual string Identify()
        {
            return "This is a Furniture object!";
        }
    }
}
