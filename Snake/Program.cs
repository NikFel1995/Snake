using System;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {
            HorizontalLine horizontalLine = new HorizontalLine(5, 10, 8, ':');

            horizontalLine.Draw(ConsoleColor.Cyan);


            Console.ReadKey();
        }




    }
}
