using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Person
    {
        public string PersonName;
        //list to hold items

        public Person()
        {
                

        
        }
            
        List<Item> Inventory = new List<Item>();    
          
        public void Equip(WearableItem item)
        { 
            //code here tp "equip a wearable item"
        
        }

        public void Use(Item item)
        {
            //code here to "equip a wearable item"
        }


    }
}
