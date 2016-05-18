
using System;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            new Point(10,6,'P').Draw();

            Console.ReadKey();
        }




    }
}
