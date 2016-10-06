using System;

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

            Console.WriteLine("Hello World" + Name);

           // Console.WriteLine("I have a Squirrel named Nutsy who makes a noise that sounds like {0}. I'd rate  his cuteness as a {1}.", nutsy.Noise, nutsy.CutenessLevel);
            
        }
    }
}
