using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class Multiplayer
    {
        public static void TTTMultiplayer(string[] placeHolders, int[,,] winOutcomes)
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
                    Console.WriteLine("Player 1's turn : ");
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
                    while (turns % 2 != 0)
                    
                    if (placeHolders[userChoice] == playerOne)
                    {
                        Console.WriteLine("Already taken. Choose another.");
                    }
                    else
                    {
                            placeHolders[userChoice] = playerTwo;
                            ++turns;
                    }
                    Board.TTTBoard(placeHolders);
                }
                    /*for (int i = 0; i < 3; i++)
                    {
                    if (placeHolders[winOutcomes[i, 0, 0]] == "X")
                    { 
                        for (int j = 0; j < 3; j++)
                        {
                            if (placeHolders[winOutcomes[0, j, 0]] == "X")
                            {
                                for (int k = 0; k < 1; k++)
                            {
                                    if (placeHolders[winOutcomes[0, 0, k]] == "X")
                                    {
                                        win = true;
                                    }

                                }
                            }
                        }
                    }
                }
                */
            } while (win == false);
        }
    }
}
