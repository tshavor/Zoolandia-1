using System;

namespace Zoolandia.Animals
{
    public class Cryptobranchus : Animal 
    {
        //add properties and methods
            public string RespirationMethod { get; set; }
            public string EyeLocation { get; set; }
            public double SwimSpeed { get; set; }
            public string Habitat { get; set; }

    }
public class Salamander : Cryptobranchus
    {
        // Define simple properties for a Hellbender Salamander//
        public string CommonName = "Hellbender Salamander";
        public string ScientificName = "Cryptobranchus alleganiensis";
        public string RespirationType { get; set; }
        public string Diet { get; set; }
        public string NativeEnvironment { get; set; }
        public double MaximumLength { get; set; }

//this is a CONSTRUCTOR FUNCTION that makes a new instance of the class SHARK.
//they always have the same names as their original class. (Done BEFORE I added Genus above)
        public Salamander ()
        {
        this.name = "Sal";
        this.conservationStatus= "Near Threatened";
        }
        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
        public Salamander (string Name)
        {
        this.name = Name;
        this.conservationStatus= "Near Threatened";
        }


    }

}

