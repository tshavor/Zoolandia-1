using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        //**An example of AGGRAGATION, this creates a "has-a" relationship between Animal-Eat, and Animal-Locomotion, and Anmial-Genus
        // this is an Eat class which will house some properties related to eating on all Animals//
        public Eat eat { get; set; }
        //**this is an Locomotion class which will house all things related to eating on all Animals//
        public Locomotion locomotion { get; set; }

        public Genus genus { get; set; }

        //Some PROPERTIES to Animal follows://
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string color { get; set; }
        public string conservationStatus { get; set; }
        

    //Some METHODS on Animal follows://
        public virtual void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
        // public static void eat ()
        // {
            Console.WriteLine("Animal is now eating");
        // }
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