using System;

namespace SnakeLadderProblem_CS
{/// <summary>
/// Template for Snake ladder game problem
/// </summary>
    class SnakeLadder
    {
        //UC3 snake ladder problem 
        //Generating a random no using Random method()
        public static int CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 6);
            Console.WriteLine("Dice number:" + CheckDice);
            return CheckDice;
        }
        public static void CheckOption()
        {
            Random random = new Random();
            int CheckOption = random.Next(0, 3);
            int position = 0;
            int dice = SnakeLadder.CheckDice();
            //switch selection statement
            switch (CheckOption)
            {
                case 0:
                    Console.WriteLine("No play");
                    break;
                case 1:
                    Console.WriteLine("Snake");
                    position -= dice;
                    Console.WriteLine("Player current position" + position);
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    position += dice;
                    Console.WriteLine("Player current position" + position);
                    break;
            }
        }

        static void Main(string[] args)
        {
            SnakeLadder.CheckOption();
            Console.ReadLine();
        }
    }
}