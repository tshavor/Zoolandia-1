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

          Salamander HellbenderSalamander = new Salamander();
            // Console.WriteLine(GreatWhiteShark.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + HellbenderSalamander.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + HellbenderSalamander.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + HellbenderSalamander.ConservationStatus);

          Caribou Caribou = new Caribou();
            // Console.WriteLine(Caribou.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + Caribou.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + Caribou.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + Caribou.ConservationStatus);

          Woodpecker RedHeadedWoodpecker = new Woodpecker();
            // Console.WriteLine(Caribou.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + RedHeadedWoodpecker.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + RedHeadedWoodpecker.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + RedHeadedWoodpecker.ConservationStatus);
        }
    }
}

