using System;
using System.Collections.Generic;
using Zoolandia.Animals;



namespace Zoolandia.Habitats
{
public class Habitat
  {
      // Instantiates a new list, which will contain animals.
      // You will add animals at run time (i.e. in `static void Main()
      // `)
      public List<Animal> inhabitants = new List<Animal>();
      public string public_name { get; set; }
  }
//the first of my 2 habitats: Water
public class Water : Habitat
  {
      private bool _saltwater = true;
      public double pHLevel { get; set; }
      public double temperatureinCelcius {get; set;}

      //the purpose of the below method "empty" is to set a placeholder for us to write another method later.  
      // This way, it does not throw an error.
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
      }
      // private List<Employee> scubaCrew = new List<Employee>();

      // // `public_name`, and `saltwater` properties can only be set when habitat is created
      // public Aquarium (string name, bool isSaltwater)
      // {
      //     _saltwater = isSaltwater;
      //     this.public_name = name;
      // }
  }
// the second of my 2 habitats: Land //////////////////////////////////////
public class Land : Habitat
  {
      private bool _desert = false;
      public double temperatureinCelcius { get; set; }
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
      }
      // private List<Employee> scubaCrew = new List<Employee>();

      // // `public_name`, and `saltwater` properties can only be set when habitat is created
      // public Aquarium (string name, bool isSaltwater)
      // {
      //     _saltwater = isSaltwater;
      //     this.public_name = name;
      // }
////////////////////////////////////////////////////////////////////////////////////

  }
}

