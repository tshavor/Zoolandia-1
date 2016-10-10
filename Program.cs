using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MelanerpesErythrocephalus RedheadedWoodpecker= new MelanerpesErythrocephalus
            {
            Name= "Red-headed Woodpecker",
            Color= "black",
            WingSpan= 27,
            FoodStorageLocation= "railroad ties"
            };

            Console.WriteLine(RedheadedWoodpecker.WingSpan);
            
// Example
Console.WriteLine($"I have a Woodpecker named  {RedheadedWoodpecker.Name}");
Console.WriteLine($"whose color is {RedheadedWoodpecker.Color},");
Console.WriteLine($"who has a Wingspan of  {RedheadedWoodpecker.WingSpan},");
Console.WriteLine($"and stores its food in {RedheadedWoodpecker.FoodStorageLocation}.");

        }
    }
}
