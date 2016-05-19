
using System;

namespace Snake
{
    class FoodCreator
    {
        private readonly int _mapWidth;
        private readonly int _mapHeight;
        private readonly char _sym;

        private readonly Random _random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            _mapWidth = mapWidth;
            _mapHeight = mapHeight;
            _sym = sym;
        }

        public Point CreateFood()
        {
            int x = _random.Next(2, _mapWidth - 2);
            int y = _random.Next(2, _mapHeight - 2);

            return new Point(x, y, _sym);
        }

    }
}
