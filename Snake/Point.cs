using System;

namespace Snake
{
    internal class Point
    {
        private readonly int _x;
        private readonly int _y;
        private readonly char _sym;

        public Point(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(_sym);
        }
    }
}
