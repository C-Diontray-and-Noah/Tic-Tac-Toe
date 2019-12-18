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
            Console.WriteLine("Welcome to Tic Tac Toe! Would you like to play Tic Tac Toe?");
            userInput = Console.ReadLine();
            while (quit == false)
                if (userInput.ToLower() == "yes")
                {

                }
                else if (userInput.ToLower() == "no")
                {
                    quit = true;
                }
        }
    }
}
