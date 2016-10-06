using System;

namespace ConsoleApplication
{
    class Animal
{
    //PROPERTIES to Animal follows://
    public string name { get; set; }
    public double height { get; set; }
    public double weight { get; set; }
    public string color { get; set; }

//METHODS on Animal follows://
    public static void sleep ()
    {
        Console.WriteLine("Animal is now sleeping");
    }

    public static void eat ()
    {
        Console.WriteLine("Animal is now eating");
    }
    public static void move ()
    {
        Console.WriteLine("Animal is now moving");
    }
    public static void breathe ()
    {
        Console.WriteLine("Animal is now breathing");
    }
    //New CLASSES (Species) here:////////////////////

    // The species for a Great White Shark
class CarcharodonCarcharias : Animal
{
    // Define simple properties for a Great White Shark

    public bool scales { get; set; }
    public bool gills { get; set; }
    public  int swimSpeed { get; set; }
    public bool cartilageSkeleton { get; set; }


}


}
}