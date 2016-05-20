using System;
using System.Collections.Generic;

namespace Snake
{
    internal class HorizontalLine : Figure
    {

        /// <summary>
        /// Конструктор для формирования горизонтальной линии
        /// </summary>
        /// <param name="xLeft">Координата левой точки по оси Х</param>
        /// <param name="xRight">Координата правой точки по оси Х</param>
        /// <param name="y">Координата по оси Y</param>
        /// <param name="sym">Символ для формирования линии</param>
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            if (xLeft > xRight)
                HelperMethods.Swap(ref xLeft, ref xRight);

            PointList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                PointList.Add(p);
            }

        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
