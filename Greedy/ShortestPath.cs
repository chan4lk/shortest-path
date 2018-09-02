using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class ShortestPath
    {
        /*
         * 5
            0,0
            7,2
            10,7
            8,20
            4,30
         * 
         */
        public double CalculateLength(Point root, Point point)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(root.X - point.X), 2) + Math.Pow(Math.Abs(root.Y - point.Y), 2));
        }

        public double CalculatePerimeter(List<Point> points)
        {
            double perimeter = 0;
            if (points.Count < 2)
            {
                perimeter = 0;
            }
            else
            {
                var count = points.Count;
                for (int i = 0; i < count - 1; i++)
                {
                    perimeter += CalculateLength(points[i], points[i + 1]);
                }
                if (count > 2)
                    perimeter += CalculateLength(points[count - 1], points[0]);
            }

            return perimeter;

        }
    }
}
