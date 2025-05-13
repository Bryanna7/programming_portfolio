using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    internal class World
    {
        //Set of locations
        List<Location> locations = new List<Location>();
        Location[,] map; //2D array
        int x = 0;
        int Y = 0; //show player location


        //Players
        Person player = new Person();

        public World()
        {
            int numberLocations = GetRandomNumber(4, 6);

            //4 locations
            for (int i = 0; i < numberLocations; i++)
            {
                locations.Add(new Location());  
            }

        }

        //method
        public void Setup()
        {

            
            //set up tasks
            GameLoop();

        }

        private void GameLoop()
        {
            Console.Clear();
            Print("Where would you like to go? Enter the number next to a Location:");
            Print(GetLocationList());

            string choice = Console.ReadLine();
            
            if (int.TryParse(choice, out int result))
            {
                //&& - and, || - or, ! - not !=
                if (result >0 && result < locations.Count)
                {
                    

                    //number--
                    locations[result - 1].Visit();

                }
              else
                {
                    Print("Please eneter a valid number of a location.");
                    Pause();
                    GameLoop();
                }

            }

            GameLoop();
        }

        private string GetLocationList()
        {
            string output = "Location in the world:\n";
            int number = 1;
            foreach (Location location in locations)
            {
                output += $"{number} {location.LocationName}\n";
                number++;
            }

            return output;
        }

        private void StartMap()
        {


        }
    }
}
