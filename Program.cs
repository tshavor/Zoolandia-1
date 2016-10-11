using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //how do I call methods on my shark?

        //  example 1:
        //  Animal animal= new Animal();
        //     animal.sleep();

        // Example 2:
        // Shark shark= new Shark();
        // shark.sleep();

        // Example 3:
        Animal shark = new Shark();
        shark.sleep();

        //  
          Shark GreatWhiteShark  = new Shark();
            // Console.WriteLine(GreatWhiteShark.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + GreatWhiteShark.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + GreatWhiteShark.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + GreatWhiteShark.ConservationStatus);

            //this calls the OVERLOADED CONSTRUCTOR on GreatWhiteShark and replaces the name with SHARKNADO//
          //you have to use a different variable name, so I renamed it GreatWhiteShark1//
          Shark GreatWhiteShark1  = new Shark("SHARKNADO");
          Console.WriteLine(GreatWhiteShark1.Name);


          Salamander HellbenderSalamander = new Salamander();
            // Console.WriteLine(GreatWhiteShark.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + HellbenderSalamander.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + HellbenderSalamander.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + HellbenderSalamander.ConservationStatus);

            //this calls the OVERLOADED CONSTRUCTOR on Caribou.cs and replaces the name with RAMBO//
          //you have to use a different variable name, so I renamed it Caribou1//
        Salamander HellbenderSalamander1 = new Salamander("BADASS");
         Console.WriteLine(HellbenderSalamander1.Name);


          Caribou Caribou = new Caribou();
            // Console.WriteLine(Caribou.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + Caribou.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + Caribou.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + Caribou.ConservationStatus);

          //this calls the OVERLOADED CONSTRUCTOR on Caribou.cs and replaces the name with RAMBO//
          //you have to use a different variable name, so I renamed it Caribou1// 
          Caribou Caribou1 = new Caribou("RAMBO");
          Console.Write(Caribou1.Name);


          Woodpecker RedHeadedWoodpecker = new Woodpecker();
            // Console.WriteLine(Caribou.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + RedHeadedWoodpecker.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + RedHeadedWoodpecker.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + RedHeadedWoodpecker.ConservationStatus);

            //this calls the OVERLOADED CONSTRUCTOR on Caribou.cs and replaces the name with RAMBO//
          //you have to use a different variable name, so I renamed it Caribou1//
          Woodpecker RedHeadedWoodpecker1 = new Woodpecker("SMOKEY");
          Console.WriteLine(RedHeadedWoodpecker1.Name);

        }
    }
}

