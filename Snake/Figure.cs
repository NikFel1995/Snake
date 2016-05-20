using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    internal class Figure
    {
        /// <summary>
        /// Список точек
        /// </summary>
        protected List<Point> PointList;

        /// <summary>
        /// Вывод вертикальной линии на экран
        /// </summary>
        public void Draw()
        {
            foreach (var point in PointList)
            {
                point.Draw();
            }
        }

        /// <summary>
        /// Вывод вертикальной линии на экран
        /// <param name="color">Цвет линии</param>
        /// </summary>
        public void Draw(ConsoleColor color)
        {
            foreach (var point in PointList)
            {
                point.Draw(color);
            }
        }

        public bool IsHit(Figure figure)
        {
            return PointList.Any(figure.IsHit);
        }

        private bool IsHit(Point point)
        {
            return PointList.Any(p => p.IsHit(point));
        }
    }
}
