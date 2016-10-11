using System;

namespace Zoolandia.Animals
{
public class Salamander : Animal
    {
        // Define simple properties for a Hellbender Salamander//
        public string RespirationType { get; set; }
        public string Diet { get; set; }
        public string NativeEnvironment { get; set; }
        public double MaximumLength { get; set; }

//this is a CONSTRUCTOR FUNCTION that makes a new instance of the class SHARK.
//they always have the same names as their original class.
        public Salamander ()
        {
        this.Name = "Sal";
        this.SpeciesName= "Some really cool Latin name here";
        this.ConservationStatus= "Endangered";
        }
        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
        public Salamander (string Name)
        {
        this.Name = Name;
        this.SpeciesName= "Some really cool Latin name here";
        this.ConservationStatus= "Endangered";
        }


    }

}

