using System;
using System.Collections.Generic;

namespace SnakeLadderProblem_CS
{/// <summary>
/// Template for Snake ladder game problem
/// </summary>
    class SnakeLadder
    {
        //UC5 to get exactly 100 position in Snake ladder game
        //initializing instance variable
        public static int start = 0;
        public static int position = 0;
        public static int winPosition = 100;
        public static int diceRollNum = 0;


        //Generating a random no using Random method()
        public static int CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 7);
            Console.WriteLine("Dice number:" + CheckDice);
            return CheckDice;
        }
        public static void CheckOption()
        {
            Random random = new Random();
            int checkOption = random.Next(0, 3);
            int dice = SnakeLadder.CheckDice();
            //switch selection statement
            switch (checkOption)
            {
                case 0:
                    Console.WriteLine("No play");
                    break;
                case 1:
                    Console.WriteLine("Snake");
                    if ((position - dice) < start)
                    {
                        Console.WriteLine("Restart the game");
                        position = start;
                        Console.WriteLine("Player current position" + position);
                    }
                    else
                    {
                        position -= dice;
                        Console.WriteLine("Player current position" + position);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    if ((position + dice) > winPosition)
                    {
                        Console.WriteLine("Player position is above 100");
                        position -= dice;
                        Console.WriteLine("Player current position" + position);
                    }
                    else if ((position + dice) == winPosition)
                    {
                        Console.WriteLine("Wins the game");
                        position = winPosition;
                        Console.WriteLine("Player current position" + position);
                    }
                    else
                    {
                        position += dice;
                        Console.WriteLine("Player current position" + position);
                    }
                    break;
            }
        }

        public static void WinningPosition()
        {
            //Repetation loop till reach winposition
            while (position < winPosition)
            {
                SnakeLadder.CheckOption();
                diceRollNum++;
            }
        }
        static void Main(string[] args)
        {
            SnakeLadder.WinningPosition();
            Console.WriteLine("Number of times dice rolled:" + diceRollNum);
            Console.ReadLine();
        }
    }
}