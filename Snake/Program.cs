using System;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {
            DrawFrame();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Draw(ConsoleColor.Red);

            for (int i = 0; i < 58; i++)
            {
                snake.Move();
                snake.Draw(ConsoleColor.Red);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Нарисовать рамку
        /// </summary>
        private static void DrawFrame()
        {
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');


            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.Draw(ConsoleColor.Cyan);
            downLine.Draw(ConsoleColor.Cyan);
            leftLine.Draw(ConsoleColor.Cyan);
            rightLine.Draw(ConsoleColor.Cyan);
        }
    }
}
