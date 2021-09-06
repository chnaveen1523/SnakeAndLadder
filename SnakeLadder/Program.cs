using System;

namespace SnakeLadderProblem_CS
{
    class SnakeLadder
    {
        public static void Position()
        {
            int position = 0;
            Console.WriteLine("Player is at start position:" + position);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Single player");
            SnakeLadder.Position();
            Console.ReadLine();
        }
    }
}