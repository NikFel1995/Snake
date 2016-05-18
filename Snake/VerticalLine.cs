
using System.Collections.Generic;

namespace Snake
{
    class VerticalLine : Figure
    {

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
