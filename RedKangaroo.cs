using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
public class Macropus : Animal 
{
    //add properties and methods
        public string EarShape { get; set; }
        public string Muzzle { get; set; }
        public double JumpDistance { get; set; }
        public string Habitat { get; set; }

}
    public class RedKangaroo : Macropus
    {
        // Define simple properties for a RedKangaroo//
        public string CommonName = "Red Kangaroo";
        public string ScientificName = "Osphranter rufus";
        public string CoatType { get; set; }
        public string FurTexture { get; set; }
        
        //this is a CONSTRUCTOR FUNCTION that makes a new instance of the class RedKangaroo.
        //they always have the same names as their original class.
        public RedKangaroo ()
        {
        this.Name = "Dopey";
        this.ConservationStatus= "Plentiful";
        }
        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
         public RedKangaroo (string Name)
        {
        this.Name = Name;
        this.ConservationStatus= "Plentiful";
        }
    }
}