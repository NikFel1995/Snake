
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        private Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            PointList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, this.direction);
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
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
