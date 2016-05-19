using System;

namespace Snake
{
    internal class Point
    {
        private int _x;
        private int _y;
        private char _sym;

        /// <summary>
        /// Конструктор для формирования точки
        /// </summary>
        /// <param name="x">Координата по оси X</param>
        /// <param name="y">Координата по оси Y</param>
        /// <param name="sym">Символ для формирования точки</param>

        public Point(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _sym = sym;
        }

        /// <summary>
        /// Конструктор для формирования точки
        /// </summary>
        /// <param name="p">Точка</param>
        public Point(Point p)
        {
            _x = p.X;
            _y = p.Y;
            _sym = p.Sym;
        }

        /// <summary>
        /// Перемещение точку на заданное число шагов в выбранном направлении
        /// </summary>
        /// <param name="offset">Смещение</param>
        /// <param name="direction">Направление</param>
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
                _x += offset;

            if (direction == Direction.Left)
                _x -= offset;

            if (direction == Direction.Up)
                _y -= offset;

            if (direction == Direction.Down)
                _y += offset;
        }

        /// <summary>
        /// Получить и/или установить значение координаты X
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        /// <summary>
        /// Получить и/или установить значение координаты Y
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Получить и/или установить символ Sym
        /// </summary>
        public char Sym
        {
            get { return _sym; }
            set { _sym = value; }
        }

        /// <summary>
        /// Вывод точки на экран
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(_sym);
        }

        /// <summary>
        /// Вывод точки на экран
        /// </summary>
        /// <param name="color">Цвет точки</param>
        public void Draw(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(_sym);
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        /// <summary>
        /// Перегруженный метод ToString
        /// </summary>
        /// <returns>Строку с данными о точке (координата по х и y, символ точки)</returns>
        public override string ToString()
        {
            return String.Format("x = {0}, y = {1}, sym = {2}", X, Y, Sym);

        }

        /// <summary>
        /// Стирание точки
        /// </summary>
        public void Clear()
        {
            _sym = ' ';
            Draw();
        }
    }
}
