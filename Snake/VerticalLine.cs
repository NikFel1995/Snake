
using System.Collections.Generic;

namespace Snake
{
    class VerticalLine : Figure
    {
        /// <summary>
        /// Конструктор для формирования вертикальной линии
        /// </summary>
        /// <param name="yUp">Координата верхней точки по оси Y</param>
        /// <param name="yDown">Координата нижней точки по оси Y</param>
        /// <param name="x">Координата по оси Y</param>
        /// <param name="sym">Символ для формирования линии</param>
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            PointList = new List<Point>();
            if (yUp > yDown)
                HelperMethods.Swap(ref yUp, ref yDown);
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                PointList.Add(p);
            }
        }
    }
}
