
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    internal class Walls
    {
        private readonly List<Figure> _wallList;

        /// <summary>
        /// Конструктор для инициализации границ (рамки)
        /// </summary>
        /// <param name="mapWidth">Ширина рамки</param>
        /// <param name="mapHeight">Высота рамки</param>
        public Walls(int mapWidth, int mapHeight)
        {
            // Инициализация стенок
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            _wallList = new List<Figure> { upLine, downLine, leftLine, rightLine };

        }

        /// <summary>
        /// Было ли столкновение с фигурой
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>True - если столкнулись, иначе - false</returns>
        internal bool IsHit(Figure figure)
        {
            return _wallList.Any(wall => wall.IsHit(figure));
        }

        /// <summary>
        /// Отрисовка стен
        /// </summary>
        public void Draw()
        {
            foreach (var wall in _wallList)
                wall.Draw();
        }
    }
}
