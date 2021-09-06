using System;

namespace SnakeLadderProblem_CS
{/// <summary>
/// Template for Snake ladder game problem
/// </summary>
    class SnakeLadder
    {
        //Generating a random no using Random method()
        public static void CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 6);
            Console.WriteLine("Dice number:" + CheckDice);
        }

        static void Main(string[] args)
        {
            SnakeLadder.CheckDice();
            Console.ReadLine();
        }
    }
}