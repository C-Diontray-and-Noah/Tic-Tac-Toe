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

            //Asks the player if they would like to play Tic Tac Toe
            Console.WriteLine("Welcome to Tic Tac Toe! Would you like to play Tic Tac Toe?");
            userInput = Console.ReadLine();

            while (userInput.ToLower() != "yes" || userInput.ToLower() != "no")
            {
                if (userInput.ToLower() == "yes")
                {
                    while (quit == false)
                    {

                        {
                            Console.WriteLine("Would you like to play singleplayer or multiplayer?");
                            userInput = Console.ReadLine();
                            while (userInput != "singleplayer" || userInput != "multiplayer")
                            {
                                if (userInput.ToLower() == "singleplayer")
                                {
                                    AI.TTTAI(placeHolders);
                                }
                                else if (userInput.ToLower() == "multiplayer")
                                {
                                    Multiplayer.TTTMultiplayer(placeHolders);
                                }
                                else
                                {
                                    Console.WriteLine("Not an option. Enter singleplayer or multiplayer.");
                                    userInput = Console.ReadLine();
                                }
                            }

                                Console.WriteLine("Would you like to play again?");
                                userInput = Console.ReadLine();
                                if (userInput.ToLower() == "no")
                                {
                                    quit = true;
                                }
                        }
                    }
                }
                else if (userInput.ToLower() == "no")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("That is not yes or no. Try entering yes or no.");
                    userInput = Console.ReadLine();
                }
            }
        }
    }
}

