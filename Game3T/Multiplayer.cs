using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class Multiplayer
    {
        public static void TTTMultiplayer(string[] placeHolders)
        {
            bool win = false;
            bool xOrO = false;
            int turns = 0;
            int userChoice = 0;
            string xAndO = null;
            Board.TTTBoard(placeHolders);
            do
            {
                if (turns % 2 == 0)
                {
                    Console.WriteLine("Player 1's turn : ");
                    while (xOrO == false)
                    {
                        Console.WriteLine("Xs or Os?");
                        xAndO = Console.ReadLine();
                        xAndO.ToUpper();
                        if (xAndO == "X")
                        {
                            Console.WriteLine("Player 1 is Xs!\nPlayer 2 is Os");
                            xOrO = true;
                        }
                        else if (xAndO == "O")
                        {
                            Console.WriteLine("Player 1 is Os!\nPlayer 2 is Xs");
                            xOrO = true;
                        }
                        else
                            Console.WriteLine("Not an option");
                    }
                    

                    for (int i = 0; i < placeHolders.Length; ++i)
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    placeHolders[userChoice] = xAndO;
                    Console.WriteLine(xAndO);
                    Board.TTTBoard(placeHolders);
                    
                }
                else
                {
                    Console.WriteLine("Player 2's turn : ");
                    for (int i = 0; i < placeHolders.Length; ++i)
                        userChoice = Convert.ToInt32(Console.ReadLine());
                        placeHolders[userChoice] =  "O";
                }
                ++turns;

            } while (win == false);
        }
    }
}
