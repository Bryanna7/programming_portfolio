/*
 * AdventureGame
 * Bryanna Ibarra
 * 2/18/2025
 *  Example/ open source code for a menu from //address
 */

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Map map = new Map();
            map.CreateMap();
            map.ShowMap();

            World world = new World();
            world.Setup();

            
        }
    }
}
