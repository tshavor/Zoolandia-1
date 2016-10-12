using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
public class Romerolagus : Animal 
{
    //add properties and methods
        public string BodySize { get; set; }
        public string EarShape { get; set; }
        public double JumpDistance { get; set; }
        public string Habitat { get; set; }

}
    public class Rabbit : Romerolagus
    {
        // Define simple properties for a VolcanoRabbit//
        public string CommonName = "Volcano Rabbit";
        public string ScientificName = "Romerolagus diazi";
        public string CoatType { get; set; }
        public string FurTexture { get; set; }
        public double RunSpeed { get; set; }

        //this is a CONSTRUCTOR FUNCTION that makes a new instance of the class VolcanoRabbit.
        //they always have the same names as their original class.
        // public Rabbit ()
        // {
        // this.Name = "Furry";
        // this.ConservationStatus= "Endangered";
    
        // }

        //this is an OVERLOADING Function that uses the same format as the original VolcanoRabbit method but allows for the 
        //use of a string NAME as an argument.//
        //  public Rabbit (string Name)
        // {
        // this.Name = Name;
        // this.ConservationStatus= "Endangered";
    
        // }
    }
}