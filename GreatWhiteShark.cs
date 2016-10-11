using System;

namespace Zoolandia.Animals
{
public class Shark : Animal
    {
        // Define simple properties for a Great White Shark//
        public string ScaleSize { get; set; }
        public string TeethNumber { get; set; }
        public double SwimSpeed { get; set; }
        public double FinNumber { get; set; }



//create an override for the method "sleep" that I made "virtual" in Animals.cs//
        public override void sleep ()
        {
//this part calls the sleep method on the base Animal, and then adds the 2nd console.Wrteline statement after it//
            base.sleep();
            Console.WriteLine("Animal is now sleeping, and working on it's tan!");
        }
//this is a CONSTRUCTOR FUNCTION that makes a new instance of the class SHARK.
//they always have the same names as their original class.
        public Shark ()
        {
        this.Name = "Sharkie";
        this.SpeciesName= "Carcharodon carcharias";
        this.ConservationStatus= "Vulnerable";
        }
        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
        public Shark (string Name)
        {
        this.Name = Name;
        this.SpeciesName= "Carcharodon carcharias";
        this.ConservationStatus= "Vulnerable";
        }

    }



}
