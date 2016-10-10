using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Woodpecker RedheadedWoodpecker= new Woodpecker
            {
            Name= "Red-headed Woodpecker",
            Color= "black",
            WingSpan= 27,
            FoodStorageLocation= "railroad ties"
            };
            
            Shark GreatWhiteShark= new Shark
            {
            Name= "Great White Shark",
            Color= "Grey",
            ScaleSize= "large",
            SwimSpeed= 28
            };
// Example 1:
Console.WriteLine($"I have a Woodpecker named  {RedheadedWoodpecker.Name}");
Console.WriteLine($"whose color is {RedheadedWoodpecker.Color},");
Console.WriteLine($"who has a Wingspan of  {RedheadedWoodpecker.WingSpan},");
Console.WriteLine($"and stores its food in {RedheadedWoodpecker.FoodStorageLocation}.");
      
// Example 2:
Console.WriteLine($"I have a Shark named  {GreatWhiteShark.Name}");
Console.WriteLine($"whose color is {GreatWhiteShark.Color},");
Console.WriteLine($"who has a ScaleSize of  {GreatWhiteShark.ScaleSize},");
Console.WriteLine($"and swims{GreatWhiteShark.SwimSpeed} miles/hour.");
        
        
        }

    }
}

