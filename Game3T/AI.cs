using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3T
{
    class AI
    {
        public static void TTTAI(string[] placeHolders)
        {
            bool xOrO = false;
            string playerOne = null;
            string playerAI = null;

            while (xOrO == false)
            {
                Console.WriteLine("Player 1 : X or O?");
                playerOne = Console.ReadLine();
                playerOne = playerOne.ToUpper();
                if (playerOne == "X")
                {
                    Console.WriteLine("Player 1 is Xs!\nComputer is Os!");
                    playerAI = "O";
                    xOrO = true;
                    Board.TTTBoard(placeHolders);
                }
                else if (playerOne == "O")
                {
                    Console.WriteLine("Player 1 is Os!\nComputer is Xs!");
                    playerAI = "X";
                    xOrO = true;
                   Board.TTTBoard(placeHolders);
                }
                else
                { 
            Console.WriteLine("Not an option");
                }

                System.Threading.Thread.Sleep(2500);
                Console.WriteLine("computer say goodbye");
            }
        }
    }
}
