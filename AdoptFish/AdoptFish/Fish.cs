using static AdoptFish.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdoptFish
{
    public class Fish
    {
        public string fishName;
        
        //private int fishFoodAmount;
        public string fishColor;
        //public int fishAge;
        public int fishAge = 2;
        public string BuyFish;
        public int HungerLevel = 0;
        private int maxLevel = 10;
        private int minLevel = 0;

        public Fish(string name, string color)
        { 
        
        }
        
        

        public Fish()
        {
            //new instance of fish - random name, random color
            //fishName = GetRandomName();
            //fishColor = GetRandomColor();
            //Console.WriteLine($"My name is {fishName}, I am a {fishColor} fish and I am{fishAge} years old");
        }
        private string GetRandomName()
        {
            string[] names = { "Ann", "Bob", "Carol", "Dustin", "Ella", "Frank", "Gary", "Heather"};

            return names[GetRandomNumber(names.Length)];
            
        }
        private string GetRandomColor()
        {
            string[] colors =
            {
                "blue", "green", "purple", "orange","yellow"
            };

            return colors[GetRandomNumber(colors.Length)];
        }
        public void Eat()
        {
            // HungerLevel = HungerLevel - 1;
            if (HungerLevel > minLevel+1)
            {
                HungerLevel--;
            }
        }

        public void Setfishproperties(string name, string color)
        {
            //allow player to change the name and the color
            fishName = name;
            fishColor = color;

            Console.WriteLine($"My name is {fishName}. I am {fishAge} years old");
        }

        public void SetFishproperties(string name, string color)
        {
            //allow player to change the name and the color
            fishName = name;
            fishColor = color;

            Console.WriteLine($"My name is {fishName}. I am {fishAge} years old");
        }

        public string FishInfo()
        {
            string output = "Fish information:\n";
            output += $"{fishName} is 2 years old. {Environment.NewLine}";

            return output;
        }
    }
}