
using System;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {
            Point p1 = new Point
            {
                x = 1,
                y = 3,
                sym = '*'
            };
            p1.Draw();

            Point p2 = new Point
            {
                x = 4,
                y = 5,
                sym = '#'
            };
            p2.Draw();

            Console.ReadKey();
        }




    }
}
