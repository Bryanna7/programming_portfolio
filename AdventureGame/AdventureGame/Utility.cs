using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Utility
    {

        public static Random RandomNumberGenerator = new Random();

        //overloaded method - more than one method with the same name
        public static int GetRandomNumber(int max)
        {
            return RandomNumberGenerator.Next(max);
        }

        public static int GetRandomNumber(int min, int max)
        {
            return RandomNumberGenerator.Next(min, max);

        }

        

        // => acts like a return
        //public static int GetRandomNumber(int max) => RandomNumberGenerator.Next(max);
        //public static int GetRandomNumber(int min, int max) => RandomNumberGenerator.Next(min, max);

        public static void Print(string message)
        {
            Console.WriteLine(message);

        }

       public static void Pause()
        {
            Print("press any key to continue");
            Console.ReadKey();
        }



        public static string[] GetArrayOfTextFromExternalFile(string path)
        {
            string[] output;
            if (File.Exists(path))
            {
                //the sky is bright
                output = File.ReadAllLines(path);
            }
            
            return null;

        }

        //string input = "";
        //input = File.ReadAllText("../../../data/GuideDialog.txt");

        //    string[] lines = File.ReadAllLines("../../../data/GuideDialog.text");
        //    foreach (string line in lines)
        //    {
        //        Console.WriteLine(line);
        //        Console.ReadKey();
        //    }
    }
}
