using System;
using System.Collections.Generic;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(10, 7, '/');
            Point p4 = new Point(8, 2, '-');


            List<Point> pointList = new List<Point> { p1, p2, p3, p4 };

            foreach (var point in pointList)
            {
                point.Draw();
            }

            Console.ReadKey();
        }




    }
}
