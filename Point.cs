using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Point
    {
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY:{_y}");
        }
    }
}
