using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class Startup
    {
        static void Main(string[] args)
        {
            string userInput = null;
            bool quit = false;
            string[] placeHolders = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Console.WriteLine("Welcome to Tic Tac Toe! Would you like to play Tic Tac Toe?");
            userInput = Console.ReadLine();

            while (quit == false)
                if (userInput.ToLower() == "yes")
                {
                   
                    Console.WriteLine("Would you like to play singleplayer or multiplayer?");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "singleplayer")
                    {
                        Multiplayer.TTTMultiplayer(placeHolders);
                    }
                    else if (userInput.ToLower() == "multiplayer")
                    {
                        AI.TTTAI(placeHolders);
                    }
                    quit = true;
                }
                else if (userInput.ToLower() == "no")
                {
                    quit = true;
                }
        }
    }
}
