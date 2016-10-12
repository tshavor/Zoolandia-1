using System;
using System.Collections.Generic;

namespace Zoolandia.Animals
{
interface IAquatic
    {
        List<int>swimDistance {get; set;}
        string progenyType {get; set;}
        int avglifespan {get; set;}
        bool nativeSpecies {get; set;}
    }
}
    