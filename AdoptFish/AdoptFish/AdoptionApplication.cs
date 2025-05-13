/*
 * Adopt A Fish
 * Bryanna Ibarra
 * 1/28/25
 */

using System.Drawing;
using System.Xml.Linq;

namespace AdoptFish
{
    public class AdoptionApplication
    {



        //attributes / properties / fields / variables
        public string Name = "Awesome Adoption Agency";
        private int numFish = 3;
        public Player player = new Player();
        public Fish fish = new Fish();
        

        //A player has a tank
        //A fish lives in a tank

        //start method needs to be public
        public void Start()
        {
            Console.Title = Name;
            //interpolation
            Console.WriteLine($"{player.Name} welcome to {Name}!");



            SetPlayerName();
            RunMainMenu();

            //SetFishProperties();
            //Console.WriteLine(player.Information());*/
            //Console.WriteLine(player.tank.Information());
            //Console.WriteLine(player.tank.fish.Information());

            //concatention

            //Composite formatting
            Console.ReadKey();







        }






        /*
        // The coding from this section is credit by Michael Hadley
        //Youtube link: https://www.youtube.com/watch?v=eBadZxYe6I4
        */

        private void TankTemperature()
        {

            Console.WriteLine(player.Information());
            Pause();
            GameLoop();
        }
        private void Store()
        {
            Console.WriteLine("Welcome to the Fish Adoption Store! A store you can adopt fishes and buy fish food!");
            Console.WriteLine("You currently adopted one fish and have one tank");
            Console.WriteLine("Please enter a name of your fish:");
            Setfishproperties();
            DisplayStoreOptions();
            


        }

        private void DisplayStoreOptions()
        {
            Console.WriteLine("==Buy fish=====");
            Console.WriteLine("==Buy fish food==");
            Console.WriteLine("==Buy tank=======");
            Console.WriteLine("Press any key to return to main menu or Type BuyFish to adopt another fish.");

           



            Pause();
            GameLoop();
        }

        private void RunMainMenu()
        {

            //Method for Menu
            Console.WriteLine($"{player.Name} welcome to {Name}!");
                
            string[] options = { "Rename Yourself", "Store", "Tank Temperature" };
            Menu mainMenu = new Menu(options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    SetPlayerName();
                    break;
                case 1:
                    Store();
                    break;
                case 2:
                    TankTemperature();
                    break;
            }
        }

       


        private void SetPlayerName()
        {
            //print out a request for the player to enter a new name
            Console.WriteLine("Please enter a name:");
            //get whatever the player typed in
            string input = Console.ReadLine();
            player.Name = input;
            Console.WriteLine($"Thank you {player.Name}");
            Pause();    
           GameLoop();
        }

        

        private void SetFishproperties()
        {
            Console.WriteLine("Please enter a name for your fish:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a color for your fish:");
            string color = Console.ReadLine();
            //player.tank.fish.SetFishProperties(name, color);
        }

        private void Setfishproperties()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a color for your fish:");
            string color = Console.ReadLine();
            Console.WriteLine($"My name is {name}. I am {fish.fishAge} years old");




        }

        public void Pause()
        {
            Console.WriteLine("press any key to continue");
            Console.ReadKey();

        }
        private void GameLoop()
        {
            Console.WriteLine("Press any key to return to main menu");
            RunMainMenu();
        }

    }
}
