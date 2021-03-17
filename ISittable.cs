namespace CodeExampleFurniture
{
    // infterface is like a blueprint and it defines a contract.
    // all classes that implements it must also then implement the members from the interface

    internal interface ISittable
    {
        int SitCounter { get; set; }

        void Sit();

    }
}