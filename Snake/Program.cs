using System;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');


            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.Draw(ConsoleColor.Cyan);
            downLine.Draw(ConsoleColor.Cyan);
            leftLine.Draw(ConsoleColor.Cyan);
            rightLine.Draw(ConsoleColor.Cyan);



            Console.ReadKey();
        }




    }
}
