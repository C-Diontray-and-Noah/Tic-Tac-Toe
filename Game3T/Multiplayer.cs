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
            string playerOne = null;
            string playerTwo = null;
            
            do
            {
                    while (xOrO == false)
                    {
                        Console.WriteLine("Player 1 : X or O?");
                        playerOne = Console.ReadLine();
                        playerOne = playerOne.ToUpper();
                        if (playerOne == "X")
                        {
                            Console.WriteLine("Player 1 is Xs!\nPlayer 2 is Os!");
                            playerTwo = "O";
                            xOrO = true;
                            Board.TTTBoard(placeHolders);
                    }
                        else if (playerOne == "O")
                        {
                            Console.WriteLine("Player 1 is Os!\nPlayer 2 is Xs!");
                            playerTwo = "X";
                            xOrO = true;
                            Board.TTTBoard(placeHolders);
                    }
                        else
                            Console.WriteLine("Not an option");
                    }
               
                if (turns % 2 == 0)
                {
                    //for (int i = 0; i < placeHolders.Length; ++i)
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    placeHolders[userChoice] = playerOne;
                    //xAndO = Convert.ToString(placeHolders[userChoice]);
                    //Console.WriteLine(xAndO);
                    Board.TTTBoard(placeHolders);


                }
                else
                {
                    Console.WriteLine("Player 2's turn : ");
                    // (int i = 0; i < placeHolders.Length; ++i)
                        userChoice = Convert.ToInt32(Console.ReadLine());
                        placeHolders[userChoice] =  playerTwo;
                        Board.TTTBoard(placeHolders);
                }
                ++turns;

            } while (win == false);
        }
    }
}
