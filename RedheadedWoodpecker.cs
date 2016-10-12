using System;

namespace Zoolandia.Animals
{
     public class Melanerpes : Animal 
    {
        //add properties and methods
            public string EarShape { get; set; }
            public string WingColor { get; set; }
            public double WingSpan { get; set; }
            public string Habitat { get; set; }

    }
public class Woodpecker : Melanerpes
    {
        // Define simple properties for a Red-headed Woodpecker//
        public string CommonName = "Red-headed Woodpecker";
        public string ScientificName = "Melanerpes erythrocephalus";
        public string HeadColor { get; set; }
        public string WingPatchColor { get; set; }
        
        public string FoodStorageLocation { get; set; }

        public Woodpecker ()
        {
        this.Name = "Pecker";
        this.ConservationStatus= "Near Threatened";
        }
        //this is an OVERLOADING Function that uses the same format as the original Caribou method but allows for the 
        //use of a string NAME as an argument.//
        public Woodpecker (string Name)
        {
        this.Name = Name;
        this.ConservationStatus= "Near Threatened";
        }

    }

}
