using System;

namespace TwisterGame
{
    class Program
    {
        static void Main(string []args)
        {
            // ввод числа игроков
            Console.WriteLine("--- Welcome to the C#-Twister ---");
            Console.WriteLine("  (Press key 'Esc' to complete)   \n");
            Console.Write("Enter number of players: ");
            int playersNum = Convert.ToInt32(Console.ReadLine());

            // цвета
            string[] colours = { "yellow", "red", "green", "blue" };

            // части тела
            string[] bodyParts = { "hand", "leg" };

            // сторона
            string[] sides = { "left", "right" };

            // переменные для цикла
            int playerNum = 1;
            bool gameEnd = false;

            // цикл игры
            do
            {
                Console.Write("Player {0}: ", playerNum);
                if (playerNum == playersNum)
                    playerNum = 1;
                else
                    playerNum++;

                string currentColor = colours[new Random().Next(0, colours.Length)];

                if (currentColor == "yellow")
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else if (currentColor == "red")
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (currentColor == "green")
                    Console.ForegroundColor = ConsoleColor.Green;
                else 
                    Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("{0} {1} on {2}\n",
                    sides[new Random().Next(0, sides.Length)],
                    bodyParts[new Random().Next(0, bodyParts.Length)],
                    currentColor);

                Console.ResetColor();

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    gameEnd = true;
                }
            }
            while (!gameEnd);

            Console.WriteLine("\n--- Thanks for playing! ---");

            Console.ReadLine();
        }
    }
}