using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal RedheadedWoodpecker= new MelanerpesErythrocephalus
            {
            Name= "Red-headed Woodpecker",
            Color= "black",
            WingSpan= 27,
            FoodStorageLocation= "railroad ties"
            };

            Console.WriteLine($"Hello World" + RedheadedWoodpecker.Name);
            // Console.WriteLine($"I have a Squirrel named {squirrel.name} who makes a 
// noise that sounds like {squirrel.signatureNoise}. I'd rate its cuteness 
// at {squirrel.cutenessFactor}.");

        }
    }
}

// Example
// Console.WriteLine($"I have a Squirrel named {squirrel.name} who makes a 
// noise that sounds like {squirrel.signatureNoise}. I'd rate its cuteness 
// at {squirrel.cutenessFactor}.");