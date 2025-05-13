using System;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Console;
namespace AdoptFish
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
           

            // The colored graphics code from Programmingisfun.com
            //Content © 2025 Programming is Fun
            //Code licensed under the Creative Commons Attribution 4.0 International License
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            
            
            Console.Title = "Supper Awesome Adopt A Fish App";
            AdoptionApplication adoptionAgency = new AdoptionApplication(); 
            adoptionAgency.Start();

            //WriteLine("Hello, World!");
            
            
            
            
        }
    }
}
