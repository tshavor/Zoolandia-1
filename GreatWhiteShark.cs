using System;
using System.Collections.Generic;

namespace Zoolandia.Animals
{
    public class Carcharodon : Animal 
    {
        //add properties and methods
            public string FinShape { get; set; }
            public string HeadShape { get; set; }
            public double Lifespan { get; set; }
            public string Habitat { get; set; }

    }
public class Shark : Carcharodon, IAquatic
    {
        // Define simple properties for a Great White Shark//
        public string CommonName = "Great White Shark";
        public string ScientificName = "Carcharodon carcharias";
        public string ScaleSize { get; set; }
        public string TeethStyle { get; set; }
        public double SwimSpeed { get; set; }
        public double FinNumber { get; set; }
        //adding properties from IAquatic//
        public List<int> swimDistance {get; set;}
        public string progenyType {get; set;}
        public int avglifespan {get; set;}
        public bool nativeSpecies {get; set;}
////////////////////////////////////////////////////////////////////////


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
        this.name = "Sharkie";
        this.conservationStatus= "Vulnerable";
        }
        // this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        // use of a string NAME as an argument.//
        public Shark (string Name)
        {
        this.name = Name;
        this.conservationStatus= "Vulnerable";
        }

    }



}
