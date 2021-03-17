using System;

namespace CodeExampleFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism Example:  

            // f1 and f2 are both Furniture type references, but because
            // they are instantiated differently, they can have different behavior (f1 points to a Sofa object in memory and f2 points to a Chair object in memory)
            // 
            Furniture f1 = new Sofa(0, 3);
            Furniture f2 = new Chair(0, 4);

            //  Instantiation of an array of Furniture references
            Furniture[] fArray = new Furniture[] { f1, f2 };

            foreach (Furniture f in fArray)
            {
                // The Furniture references will have different behavior/outputs based on the object type they refer to
                // This proves that C# supports Polymorphism
                Console.WriteLine(f.Identify());
            }








            //Interface practical Example

            // Lets say I want to put my Furniture objects (that i know implements ISittable)
            // in an array to call Sit method on them
            // and thats the only functionality i need, then we can make an array of ISittable references. 
            // and iterate over them with foreach and call Sit() on each of them  


            Sofa s1 = new Sofa();
            Chair c1 = new Chair();

            ISittable[] sittableFArray = new ISittable[] { s1, c1 };

            foreach (ISittable sittableF in sittableFArray)
            {

                sittableF.Sit();

                Console.WriteLine(sittableF.SitCounter);
            }


        }
    }
}
