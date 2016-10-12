using System;

namespace Zoolandia.Animals
{   
    // Genus class, inherits from animal class
    public class Rangifer : Animal 
    {
        
    
        //add properties and methods
            public string EarShape { get; set; }
            public string HoofType { get; set; }
            public double RunSpeed { get; set; }
            public string Habitat { get; set; }
    }
    public class Caribou : Rangifer
    {
        // Define simple properties for a Caribou//
        public string CommonName = "Caribou";
        public string ScientificName = "Rangifer tarandus";
        public string CoatType { get; set; }
        public string FurTexture { get; set; }
        public string FoodSource { get; set; }
        public double AntlerSize { get; set; }

        //this is a CONSTRUCTOR FUNCTION that makes a new instance of the class SHARK.
        //they always have the same names as their original class.
        public Caribou ()
        {
        this.name = "Dopey";
        this.conservationStatus= "Plentiful";
        }
        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
         public Caribou (string Name)
        {
        this.name = Name;
        this.conservationStatus= "Plentiful";
        }
    }
}

    