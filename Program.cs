using System;
using System.Linq;

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
            Furniture f1 = new Sofa(1, 3, 7, 25);
            Furniture f2 = new Chair(1, 4, 3, 17);
            Furniture f3 = new Chair(1, 4, 5, 21);

            //  Instantiation of an array of Furniture references
            Furniture[] fArray = new Furniture[] { f1, f2, f3 };

            foreach (Furniture f in fArray)
            {
                // The Furniture references will have different behavior/outputs based on the object type they refer to
                // This proves that C# supports Polymorphism


                Console.WriteLine(f.Identify());
                Console.WriteLine($"The price of the object is: {f.Price} kr. \n");
            }








            //Interface practical Example

            // Lets say I want to put my Furniture objects (that i know implements ISittable)
            // in an array to call Sit method on them
            // and thats the only functionality i need, then we can make an array of ISittable references. 
            // and iterate over them with foreach and call Sit() on each of them  


            Sofa s1 = new Sofa(1);
            Chair c1 = new Chair(2);

            ISittable[] sittableFArray = new ISittable[] { s1, c1 };

            foreach (ISittable sittableF in sittableFArray)
            {

                sittableF.Sit();

                Console.WriteLine($"The object has been sat on: {sittableF.SitCounter} times \n");
            }




            //Linq examples: 


            // LINQ queries can be written with method syntax or with query syntax


            // Query syntax example:

            // Its best practice to use query syntax over method syntax when the query will
            // contain multiple operators ("where" and "select")

            // lets say i only want furniture from fArray that weighs more than 4 kg
            // Then we can utilize LINQ query syntax in the following way:
            var result1 = from furn in fArray
                          where furn.Weight > 4
                          select furn;

            Console.WriteLine("result1 (query syntax): \n");

            //We can access the length of the query result by using Count() method on it
            Console.WriteLine($"There is {result1.Count()} elements in the query result \n");

            // then we can iterate over the query result with foreach like so: 
            foreach (var furn in result1)
            {

                Console.WriteLine($"The furniture object weighs {furn.Weight} kg. \n");

            }







            // Method syntax example:

            // with method syntax we use lamdba expression "=>" 
            // lets say i only want to store the furniture object prices
            // Then we can utilize LINQ method syntax in the following way
            var result2 = fArray.Select(f => f.Price);

            Console.WriteLine("result2: (method syntax) \n");

            // then we can iterate over the query result with foreach like so: 
            foreach (var furnPrice in result2)
            {

                Console.WriteLine($"The furniture object costs {furnPrice} kr. \n");

            }





        }
    }
}
