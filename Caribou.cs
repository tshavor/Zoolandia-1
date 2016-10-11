using System;

namespace Zoolandia.Animals
{
    public class Caribou : Animal
    {
        // Define simple properties for a Caribou//
        public string CoatType { get; set; }
        public string FurTexture { get; set; }
        public double RunSpeed { get; set; }
        public double AntlerSize { get; set; }

        //this is a CONSTRUCTOR FUNCTION that makes a new instance of the class SHARK.
        //they always have the same names as their original class.
        public Caribou ()
        {
        this.Name = "Dopey";
        this.SpeciesName= "Some really cool Latin name here";
        this.ConservationStatus= "Plentiful";
    
        }

        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
         public Caribou (string Name)
        {
        this.Name = Name;
        this.SpeciesName= "Some really cool Latin name here";
        this.ConservationStatus= "Plentiful";
    
        }
    }
}

    