using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdoptFish
{
    internal class Menu
    {
        /*
        // The coding from this Menu class is credit by Michael Hadley
        //Youtube link: https://www.youtube.com/watch?v=eBadZxYe6I4
        */
        private int SelectedIndex;
        private String[] Options;
        public Player player = new Player();
        public string Name = "Awesome Adoption Agency";

       


        public Menu(string[] options)
        {
          
            Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions()
        {
            //Console.Title = Name;
            ////interpolation
            //Console.WriteLine($"Welcome {player.Name} to the {Name}!");
            //Console.WriteLine(Prompt);

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if (i == SelectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix}<<{currentOption}>>");

            }
            Console.ResetColor();

        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                //update selectedIndex based on arrow keys
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;   

            
        }
    }
}
