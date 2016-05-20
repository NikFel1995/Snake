using System;
using System.Collections.Generic;

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
        public virtual void Draw()
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
        public virtual void Draw(ConsoleColor color)
        {
            foreach (var point in PointList)
            {
                point.Draw(color);
            }
        }
    }
}
