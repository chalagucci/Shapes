using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Square : Shape
    {
        private double side = DefaultLength;

        public Square()
        {
        }

        public Square(String s, double side)
        {
            this.side = side;
        }

        public double area()
        {
            return this.side * this.side;
        }

        public double perimeter()
        {
            return 4d * this.side;
        }
    }
}
