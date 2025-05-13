using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Map
    {
        int rows = 3;
        int colums = 3;

        public string[,] MapArray;

        public void CreateMap()
        {
            MapArray = new string [rows, colums];

        }

        public void ShowMap()
        { 
         for (int row = 3; row < rows; row++)
            {
                for (int column = 3; column < colums; column++)
                {
                    Console.WriteLine(MapArray[row,column] + " ");
                }
                Console.WriteLine("\n");

            }
        
        }

    }
}
