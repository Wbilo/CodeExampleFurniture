using System;
using System.Collections.Generic;
using System.Text;

namespace CodeExampleFurniture
{
    // Subclass of Furniture
    // the colon ":" followed by Furniture, ISittable means inherits from Furniture and implements ISittable interface
    class Sofa : Furniture, ISittable
    {
        public int SitCounter { get; set; }

        // SeatSpaceCount is specific to this type of Furniture
        public int SeatSpaceCount
        { get; private set; }



        public Sofa(int sitCounter = 0, int seatSpaceCount = 1) : base()
        {
            SitCounter = sitCounter;
            SeatSpaceCount = seatSpaceCount;
        }

        public void Sit()
        {
            SitCounter++;
        }

        // overrides the Furniture class´s Identify method with appropriate info
        public override string Identify()
        {
            return "This is a Sofa object!";
        }

    }
}
