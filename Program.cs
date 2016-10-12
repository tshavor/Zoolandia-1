using System;
using Zoolandia.Animals;
using System.Collections.Generic;


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
          // Console.WriteLine(GreatWhiteShark1.name);


          Salamander HellbenderSalamander = new Salamander();
            // Console.WriteLine(GreatWhiteShark.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + HellbenderSalamander.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + HellbenderSalamander.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + HellbenderSalamander.ConservationStatus);

            //this calls the OVERLOADED CONSTRUCTOR on Caribou.cs and replaces the name with RAMBO//
          //you have to use a different variable name, so I renamed it Caribou1//
        Salamander HellbenderSalamander1 = new Salamander("BADASS");
        //  Console.WriteLine(HellbenderSalamander1.name);


          Caribou Caribou = new Caribou();
            // Console.WriteLine(Caribou.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + Caribou.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + Caribou.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + Caribou.ConservationStatus);

          //this calls the OVERLOADED CONSTRUCTOR on Caribou.cs and replaces the name with RAMBO//
          //you have to use a different variable name, so I renamed it Caribou1// 
          Caribou Caribou1 = new Caribou("RAMBO");
          // Console.WriteLine(Caribou1.name);


          Woodpecker RedHeadedWoodpecker = new Woodpecker();
            // Console.WriteLine(Caribou.SpeciesName);  
            // Console.WriteLine($"My pet's name is" + " " + RedHeadedWoodpecker.Name + ".");
            // Console.WriteLine($"His formal name is" +  " " + RedHeadedWoodpecker.SpeciesName);
            // Console.WriteLine($"and his conservation status is" + " " + RedHeadedWoodpecker.ConservationStatus);

            //this calls the OVERLOADED CONSTRUCTOR on Caribou.cs and replaces the name with RAMBO//
          //you have to use a different variable name, so I renamed it Caribou1//
          Woodpecker RedHeadedWoodpecker1 = new Woodpecker("SMOKEY");
          // Console.WriteLine(RedHeadedWoodpecker1.name);

           //** NOw that I've added a new class of Eat to my Animal base class, I can instantiate a new Caribou (Caribou3)
           //and set a new "eat" class to it.  (this was created on Animal, but it was never activated) Since eat.diet is a string variable,
           //we can specify what eat is defined to on line 3 below...  The 4th line outputs the result to the console.
           Caribou Caribou3 = new Caribou();
           Caribou3.eat = new Eat();
           Caribou3.eat.diet= "lichen";
           Caribou3.eat.modeOfEating= "chew";
          //  Console.WriteLine("My animal likes to" + Caribou3.eat.modeOfEating);

           //An example of inserting values into the Genus class:
           Rabbit VolcanoRabbit = new Rabbit();
           VolcanoRabbit.genus = new Genus();
           VolcanoRabbit.genus.commonName= "BLAH BLAH BLAH";
           VolcanoRabbit.genus.scientificName= "MORE BLAH BLAH BLAH";
          //  Console.WriteLine(VolcanoRabbit.genus.commonName);
          //  Console.WriteLine(VolcanoRabbit.genus.scientificName);
           
          //creating a list of integers to use for "distance", which is set equal to "swimDistance".  
          // Creating a variable "someVariable" to read values from after loop runs... 
           int someVariable= 0;
           List<int>distance= new List<int>();
          {
           distance.Add(42);
           distance.Add(30);
           distance.Add(41);
           distance.Add(54);
           distance.Add(39);
          } 
//////////////////////////////////////////////////////////////

           Shark GreatWhiteShark2 = new Shark()
           {
            ScaleSize = "large",
            TeethStyle = "Serrated",
            SwimSpeed = 30,
            FinNumber = 4,
        //adding properties from IAquatic//
            swimDistance = distance,
            progenyType = "motile",
            avglifespan = 25,
            nativeSpecies= true,

           };
            Console.WriteLine(GreatWhiteShark2.ScaleSize);
            Console.WriteLine(GreatWhiteShark2.progenyType);

            //here is a loop that accesses the count of values within the list "distance"//
            for (int i = 0; i < distance.Count; i++)
            //to access all items in list...
            // Console.WriteLine(distance[i]);
            //to access index 0 from list..//
            someVariable= distance[0];
            // Console.WriteLine(someVariable);
            //to access the total numbers of list members...//
            Console.Write("Total elements: {0}", distance.Count);



        }
    }
}

