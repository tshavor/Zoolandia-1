using System;

namespace Zoolandia.Animals

{
public class Woodpecker : Animal
    {
        // Define simple properties for a Red-headed Woodpecker//
        public string HeadColor { get; set; }
        public string WingPatchColor { get; set; }
        public double WingSpan { get; set; }
        public string FoodStorageLocation { get; set; }

        public Woodpecker ()
        {
        this.Name = "Birdey";
        this.SpeciesName= "Some really cool Latin name here";
        this.ConservationStatus= "Plentiful";
        }
        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
        public Woodpecker (string Name)
        {
        this.Name = Name;
        this.SpeciesName= "Some really cool Latin name here";
        this.ConservationStatus= "Plentiful";
        }

    }

}
