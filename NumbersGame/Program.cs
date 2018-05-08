using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int current, index, first;
            bool playerTurn;
            bool win = false;

            Console.WriteLine("Welcome, what is your name?");
            playerName = Console.ReadLine();

            Random ran = new Random();
            Robot opponent = new Robot("Computer");
            Robot player = new Robot(playerName);

            current = ran.Next(1000000, 9999999);

            Console.WriteLine("Generating new game...");
            Console.WriteLine($"The starting number is {current}");

            first = ran.Next();

            if (first % 2 == 0)
            {
                playerTurn = true;
            }
            else
            {
                playerTurn = false;
            }

            do
            {
                if (playerTurn)
                {
                    Console.WriteLine($"Current number is: {current} \nPlease type in the index you would like to remove.");
                    int.TryParse(Console.ReadLine(), out index);
                    current = player.PlayerMakeMove(index, current);
                    win = player.IsVictorious(current);
                    playerTurn = false;
                }
                else
                {

                }
            }
            while (!win);

            if (player.IsVictorious(current))
            {

            }
            else
            {

            }
        }
    }
}
