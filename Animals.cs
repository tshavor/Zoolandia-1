using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        //PROPERTIES to Animal follows://
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string ConservationStatus { get; set; }
        

    //METHODS on Animal follows://
        public virtual void sleep ()
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
}