using System;

namespace Zoolandia
{
    public class Animal
    {
        //PROPERTIES to Animal follows://
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

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
    }
        //New CLASSES (Species) here:////////////////////

        // The species for a Great White Shark
    public class CarcharodonCarcharias : Animal
    {
        // Define simple properties for a Great White Shark//
        public string ScaleSize { get; set; }
        public string TeethNumber { get; set; }
        public double SwimSpeed { get; set; }
        public double FinNumber { get; set; }
    }

    // The species for a Hellbender Salamander//
    public class CryptobranchusAlleganiensis : Animal
    {
        // Define simple properties for a Hellbender Salamander//
        public string RespirationType { get; set; }
        public string Diet { get; set; }
        public string NativeEnvironment { get; set; }
        public double MaximumLength { get; set; }
    }
    // The species for a Red-headed Woodpecker
    public class MelanerpesErythrocephalus : Animal
    {
        // Define simple properties for a Red-headed Woodpecker//
        public string HeadColor { get; set; }
        public string WingPatchColor { get; set; }
        public double WingSpan { get; set; }
        public string FoodStorageLocation { get; set; }
    }
    // The species for a Caribou
    public class RangiferTarandus : Animal
    {
        // Define simple properties for a Caribou//
        public string CoatType { get; set; }
        public string FurTexture { get; set; }
        public double RunSpeed { get; set; }
        public double AntlerSize { get; set; }
    }
    ////////////////////////////////////////////////////////
}