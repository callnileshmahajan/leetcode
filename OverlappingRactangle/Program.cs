using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingRactangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Rectangle
            {
                BottomLeft = new Point
                {
                    X = 2,
                    Y = 1
                },

                TopRight = new Point
                {
                    X = 5,
                    Y = 3
                }
            };

            var r2 = new Rectangle
            {
                BottomLeft = new Point
                {
                    X = 3,
                    Y = 2
                },

                TopRight = new Point
                {
                    X = 6,
                    Y = 5
                }
            };

            int result = OverlappingRectangleArea(r1, r2);
            Console.Write(result);

            Console.Read();
        }

        public static int OverlappingRectangleArea(Rectangle r1, Rectangle r2)
        {
            Point p1 = new Point();
            p1.X = r1.BottomLeft.X;
            p1.Y = r2.BottomLeft.X;

            Point p2 = new Point();
            p2.X = r1.TopRight.X;
            p2.Y = r2.TopRight.X;

            int width = GetHeightWidth(p1, p2);
            if (width <= 0) return -1;

            p1 = new Point();
            p1.X = r1.BottomLeft.Y;
            p1.Y = r2.BottomLeft.Y;

            p2 = new Point();
            p2.X = r1.TopRight.Y;
            p2.Y = r2.TopRight.Y;

            int height = GetHeightWidth(p1, p2);
            if (height <= 0) return -1;

            return width * height;
        }

        private static int GetHeightWidth(Point p1, Point p2)
        {
            int diff1 = Math.Max(p1.X, p1.Y);
            int diff2 = Math.Min(p2.X, p2.Y);

            return diff2 - diff1;
        }        
    }

    public struct Rectangle
    {
        public Point BottomLeft;
        public Point TopRight;
    }

    public struct Point
    {
       public  int X;
       public int Y;
    }
}
