
using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        private Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            PointList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, this._direction);
                PointList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = PointList.First();
            PointList.Remove(tail);
            Point head = GetNextPoint();
            PointList.Add(head);

            tail.Clear();
            head.Draw();
        }

        /// <summary>
        /// Получить координату следующей точки
        /// </summary>
        /// <returns>Координата следующей точки</returns>
        private Point GetNextPoint()
        {
            Point head = PointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        public void Move(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = Direction.Left;

            if (key == ConsoleKey.RightArrow)
                _direction = Direction.Right;

            if (key == ConsoleKey.UpArrow)
                _direction = Direction.Up;

            if (key == ConsoleKey.DownArrow)
                _direction = Direction.Down;
        }
    }
}
