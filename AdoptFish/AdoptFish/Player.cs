using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace AdoptFish
{
    public class Player
    {
        //attributes - C# fields of properties

        public string Name = "Anonymous Player";
        public Tank tank = new Tank();
        public Tank[] tanks = new Tank[1];

        public Fish fish = new Fish();

        public double Currency;

        //operations - C# methods

        public Player(string name) 
        {
            Name = name;
            //adding instances to an arry one by one
            //tanks[0] = new Tank();

            //add instance using a loop
          
            //for(int i=0; i<tanks.Length; i++)
            //{
            //    tanks[i] = new Tank();
            //}

        }
        public Player()
        {
            SetUpTanks();
        }
        private void SetUpTanks()
        {
            int i = 0;
            foreach (Tank tank in tanks)
            {

                tanks[i] = new Tank() { tankName = $"tank #{i + 1}" };
                i++;
            }
            tanks[tanks.Length - 1].Fishes.Remove(tanks[tanks.Length - 1].Fishes[tanks[tanks.Length - 1].Fishes.Count - 1]);
        }
        public string Information()
        {
            string output = "";
            //output += $"{Name}, you have one tank. Inside the tank is a {tank.fish.fishColor} colored fish named {tank.fish.fishName}";
            foreach (Tank tank in tanks)
            {
                output += $"{tank.tankName}\n{tank.Information()}";
            }
            return output;
        }
        
    }
}