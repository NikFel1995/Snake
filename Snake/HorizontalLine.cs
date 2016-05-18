using System;
using System.Collections.Generic;

namespace Snake
{
    internal class HorizontalLine
    {
        private List<Point> _pointList;

        /// <summary>
        /// Конструктор для формирования горизонтальной линии
        /// </summary>
        /// <param name="xLeft">Координата левой точки по оси Х</param>
        /// <param name="xRight">Координата правой точки по оси Х</param>
        /// <param name="y">Координата по оси Y</param>
        /// <param name="sym">Символ для формирования линии</param>
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {


            _pointList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                _pointList.Add(p);
            }

        }


        public void Draw()
        {
            foreach (var point in _pointList)
            {
                point.Draw();
            }
        }

        public void Draw(ConsoleColor color)
        {
            foreach (var point in _pointList)
            {
                point.Draw(color);
            }
        }
    }
}
