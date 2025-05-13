using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    enum AverageTemperatureClimate: byte
    {
        mountain = 20,
        forest = 50,
        grassland = 75,
        desert = 90,
        volcano = 128

    }
       
    internal class Location
    {
        public string LocationName;
        public AverageTemperatureClimate TemperatureClimate = AverageTemperatureClimate.volcano;
        //items to be found
        //NPCs will be here too
        List<Person> People = new List<Person>();
        public Location()
        {
            People.Add(new NPC());
            


            List<string> prefix = new List<string>(){ "Mount","Castle", "Village of", "Lake", "Valley of", "Desert", "Realm of", "Land of" };
            List<string> names = new List<string>() { "Awesome", "Superior", "Fabulous", "Purpleness", "Lattes", "Coffee", "Sourdough Bread", "Cupcake", "Tiramisu", "Candycane" };
            LocationName = $"{prefix[GetRandomNumber(prefix.Count)]} {names[GetRandomNumber(names.Count)]}";

        }

        public void Visit()
        {
            //oprint out name where they are
            Utility.Print($"You have arrived at {LocationName}.");

            //NPC apper (random or dedicated?)

            //NPC has a request?

            //Find a randon item?

            //Activity?

            //Special event based on?

            Pause();

        
        }
    }
}
