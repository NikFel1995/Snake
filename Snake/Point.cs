using System;

namespace Snake
{
    internal class Point
    {
        private int _x;
        private int _y;
        private char _sym;

        public Point(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _sym = sym;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public char Sym
        {
            get { return _sym; }
            set { _sym = value; }
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(_sym);
        }
    }
}
