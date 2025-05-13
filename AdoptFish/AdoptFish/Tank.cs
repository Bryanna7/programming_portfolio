using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdoptFish
{
    public class Tank
    {
        public string tankName = "First tank";
       public Fish fish = new Fish();
        public double Temperature;

        public List<Fish> Fishes = new List<Fish>();

        public Tank()
        {
            //Fishes.Add(new Fish());
            SetUpFishes();
        }
        private void SetUpFishes()
        {
            //new intance of fish - random name, random color
            //add fish to list of fishes
            Fishes.Add(new Fish());
        }

        public void ChangeTemperature(double Temperature)
        {
            //Write the current and ideal temperature
            // the line below is the same as Temperature = Temperature;
            //Temperature += Temperature;
        }

       
        //public string Information()
        //{
        //    string output = "   Tank information:\n";
        //    //output += $"{tankName} has one fish name {fish.fishName} that is the color {fish.fishColor}. {Environment.NewLine}";

        //    foreach (Fish fish in Fishes)
        //    {
        //        output += $"   *{fish.fishName} is {fish.fishColor}\n";
        //    }

        //    return output;


            
        //}

        public string Information()
        {
            string output = "Tank temperature is 75 Fahrenheit ";
            

            


            return output;
        }
        
    }
}