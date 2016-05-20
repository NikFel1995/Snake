using System;
using System.Collections.Generic;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {
            //  DrawFrame();

            VerticalLine verticalLineLine = new VerticalLine(0, 10, 5, '%');
            HorizontalLine horizontalLine = new HorizontalLine(0, 5, 6, '%');
            Draw(verticalLineLine);
            Draw(horizontalLine);


            Point p = new Point(4, 5, '*');
            Figure fsnake = new Snake(p, 4, Direction.Right);
            Draw(fsnake);
            Snake snake = (Snake)fsnake;

            List<Figure> figures = new List<Figure>
            {
                fsnake,
                verticalLineLine,
                horizontalLine
            };
        
            foreach (var figure in figures)
            {
                figure.Draw();
            }


            Console.ReadKey();
        }

        private static void Draw(Figure figure)
        {
            figure.Draw();
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
