using System;

namespace SnakeLadderProblem_CS
{/// <summary>
/// Template for Snake ladder game problem
/// </summary>
    class SnakeLadder
    {
        //UC7 Two player in Snake ladder game
        //initializing instance variable
        public static int start = 0;
        public static int position = 0;
        public static int winPosition = 100;

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
            }
        }

        public static void TwoPlayer()
        {
            while (true)
            {
                Random random = new Random();
                int checkTurn = random.Next(1, 3);
                if (checkTurn == 1)
                {
                    SnakeLadder.WinningPosition();
                    if (position == winPosition)
                    {
                        Console.WriteLine("Player1 Won");
                        break;
                    }
                }
                if (checkTurn == 2)
                {
                    SnakeLadder.WinningPosition();
                    if (position == winPosition)
                    {
                        Console.WriteLine("Player2 Won");
                        break;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            SnakeLadder.TwoPlayer();
            Console.ReadLine();
        }
    }
}