using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExampleFurniture
{
    // Subclass of Furniture
    // the colon ":" followed by Furniture, ISittable means inherits from Furniture and implements ISittable interface
    class Chair : Furniture, ISittable
    {
        public int SitCounter { get; set; }

        // LegCount is specific to this type of Furniture
        public int LegCount { get; private set; }

        // Constructors 
        public Chair(int sitCounter = 0, int legCount = 1) : base()
        {
            SitCounter = sitCounter;
            LegCount = legCount;
        }



        public void Sit()
        {
            SitCounter++;
        }

        // overrides the Furniture class´s Identify method with appropriate info
        public override string Identify()
        {
            return "This is a Chair object!";
        }
    }
}
