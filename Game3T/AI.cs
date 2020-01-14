﻿using System;
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
            bool win = false;
            bool acceptableResponse = false;
            string playerOne = null;
            string playerAI = null;
            string winner = null;
            int userChoice = 0;
            int turns = 0;
            int randomNumber = 0;
            Random random = new Random();
            do
            {

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
                }
                if (turns % 2 == 0)
                {
                    Console.WriteLine("Player 1's turn : ");
                    userChoice = Convert.ToInt32(Console.ReadLine());

                    while (turns % 2 == 0)
                    {
                        //Evaluates whether the space chosen by player one is already taken
                        if (placeHolders[userChoice] == "X" || placeHolders[userChoice] == "O")
                        {
                            Console.WriteLine("Already taken. Choose another.");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        //Evaluates whether the space chosen by the user is a real value available
                        else if (placeHolders[userChoice] == "1" || placeHolders[userChoice] == "2" || placeHolders[userChoice] == "3" ||
                            placeHolders[userChoice] == "4" || placeHolders[userChoice] == "5" || placeHolders[userChoice] == "6" || placeHolders[userChoice] == "7"
                            || placeHolders[userChoice] == "8" || placeHolders[userChoice] == "9")
                        {
                            placeHolders[userChoice] = playerOne;
                            ++turns;
                        }
                        else
                        {
                            Console.WriteLine("That is not an answer. Choose 1 through 9.");
                            userChoice = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                Board.TTTBoard(placeHolders);
                //Runs computer's choice by 
                Console.WriteLine("Computer's turn : ");
                System.Threading.Thread.Sleep(1000);
                acceptableResponse = false;
                if (placeHolders[1] == playerOne)
                {
                    while (acceptableResponse == false)
                    {
                        randomNumber = random.Next(1, 4);
                        if (randomNumber == 1 && placeHolders[3] != playerOne || placeHolders[3] != playerAI)
                        {
                            placeHolders[3] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 2 && placeHolders[7] != playerOne || placeHolders[7] != playerAI)
                        {
                            placeHolders[7] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 2 && placeHolders[9] != playerOne || placeHolders[9] != playerAI)
                        {
                            placeHolders[9] = playerAI;
                            acceptableResponse = true;
                        }
                    }
                }
                else if (placeHolders[2] == playerOne)
                {
                    while (acceptableResponse == false)
                    {
                        randomNumber = random.Next(1, 3);
                        if (placeHolders[1] == playerOne)
                        {
                            if (randomNumber == 1 && placeHolders[1] != playerOne || placeHolders[1] != playerAI)
                            {
                                placeHolders[1] = playerAI;
                                acceptableResponse = true;
                            }
                            else if (randomNumber == 2 && placeHolders[3] != playerOne || placeHolders[3] != playerAI)
                            {
                                placeHolders[3] = playerAI;
                                acceptableResponse = true;
                            }
                        }
                        else if (placeHolders[5] == playerOne || placeHolders[8] == playerOne)
                        {
                            if (randomNumber == 1 && placeHolders[5] != playerOne || placeHolders[5] != playerAI)
                            {
                                placeHolders[5] = playerAI;
                                acceptableResponse = true;
                            }
                            else if (randomNumber == 3 && placeHolders[8] != playerOne || placeHolders[8] != playerAI)
                            {
                                placeHolders[8] = playerAI;
                                acceptableResponse = true;
                            }
                        }
                    }
                }
                else if (placeHolders[3] == playerOne)
                {
                    while (acceptableResponse == false)
                    {
                        randomNumber = random.Next(1, 3);
                        if (placeHolders[4] == playerOne)
                        {
                            if (randomNumber == 1 && placeHolders[5] != playerOne || placeHolders[5] != playerAI)
                            {
                                placeHolders[5] = playerAI;
                                acceptableResponse = true;
                            }
                            else if (randomNumber == 2 && placeHolders[7] != playerOne || placeHolders[7] != playerAI)
                            {
                                placeHolders[7] = playerAI;
                                acceptableResponse = true;
                            }
                        }
                        else if (placeHolders[7] == playerOne)
                        {
                        else if (randomNumber == 1 && placeHolders[5] != playerOne || placeHolders[5] != playerAI)
                            {
                                placeHolders[5] = playerAI;
                                acceptableResponse = true;
                            }
                            else if (randomNumber == 4 && placeHolders[9] != playerOne || placeHolders[9] != playerAI)
                            {
                                placeHolders[9] = playerAI;
                                acceptableResponse = true;
                            }
                        }
                    }
                }
                else if (placeHolders[4] == playerOne)
                {
                    while (acceptableResponse == false)
                    {
                        randomNumber = random.Next(1, 3);
                        if (randomNumber == 1 && placeHolders[1] != playerOne || placeHolders[1] != playerAI)
                        {
                            placeHolders[1] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 2 && placeHolders[5] != playerOne || placeHolders[5] != playerAI)
                        {
                            placeHolders[5] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 3 && placeHolders[6] != playerOne || placeHolders[6] != playerAI)
                        {
                            placeHolders[6] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 4 && placeHolders[7] != playerOne || placeHolders[7] != playerAI)
                        {
                            placeHolders[9] = playerAI;
                            acceptableResponse = true;
                        }
                    }
                }
                else if (placeHolders[5] == playerOne)
                {
                    while (acceptableResponse == false)
                    {
                        randomNumber = random.Next(1, 8);
                        if (randomNumber == 1 && placeHolders[1] != playerOne || placeHolders[1] != playerAI)
                        {
                            placeHolders[1] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 2 && placeHolders[2] != playerOne || placeHolders[2] != playerAI)
                        {
                            placeHolders[2] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 3 && placeHolders[3] != playerOne || placeHolders[3] != playerAI)
                        {
                            placeHolders[3] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 4 && placeHolders[7] != playerOne || placeHolders[7] != playerAI)
                        {
                            placeHolders[4] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 5 && placeHolders[7] != playerOne || placeHolders[7] != playerAI)
                        {
                            placeHolders[6] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 6 && placeHolders[7] != playerOne || placeHolders[7] != playerAI)
                        {
                            placeHolders[7] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 7 && placeHolders[8] != playerOne || placeHolders[8] != playerAI)
                        {
                            placeHolders[8] = playerAI;
                            acceptableResponse = true;
                        }
                        else if (randomNumber == 8 && placeHolders[9] != playerOne || placeHolders[9] != playerAI)
                        {
                            placeHolders[9] = playerAI;
                            acceptableResponse = true;
                        }
                    }
                }
                Board.TTTBoard(placeHolders);



                //Win outcomes for player one
                if (placeHolders[0] == playerOne && placeHolders[1] == playerOne && placeHolders[2] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[3] == playerOne && placeHolders[4] == playerOne && placeHolders[5] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[6] == playerOne && placeHolders[7] == playerOne && placeHolders[8] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[0] == playerOne && placeHolders[3] == playerOne && placeHolders[6] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[1] == playerOne && placeHolders[4] == playerOne && placeHolders[7] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[2] == playerOne && placeHolders[5] == playerOne && placeHolders[8] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[2] == playerOne && placeHolders[4] == playerOne && placeHolders[6] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }
                if (placeHolders[0] == playerOne && placeHolders[4] == playerOne && placeHolders[8] == playerOne)
                {
                    win = true;
                    winner = "Player 1";
                }

                //Win outcomes for the computer
                if (placeHolders[1] == playerAI && placeHolders[2] == playerAI && placeHolders[3] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }
                if (placeHolders[3] == playerAI && placeHolders[4] == playerAI && placeHolders[5] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }
                if (placeHolders[6] == playerAI && placeHolders[7] == playerAI && placeHolders[8] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }
                if (placeHolders[0] == playerAI && placeHolders[3] == playerAI && placeHolders[6] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }
                if (placeHolders[1] == playerAI && placeHolders[4] == playerAI && placeHolders[7] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }
                if (placeHolders[2] == playerAI && placeHolders[5] == playerAI && placeHolders[8] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }
                if (placeHolders[2] == playerAI && placeHolders[4] == playerAI && placeHolders[6] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }
                if (placeHolders[0] == playerAI && placeHolders[4] == playerAI && placeHolders[8] == playerAI)
                {
                    win = true;
                    winner = "Computer";
                }

                ++turns;
            } while (win == false);
            Console.WriteLine("{0} wins!", winner);
        } 
            
    } 
            
} 
