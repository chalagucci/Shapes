using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Circle : Shape
    {
        // Fields
        private double r = DefaultRadius;
      
        public double Radius { get; private set; }

        // parameterized constructor
        public Circle(double r)
        {
            Radius = r;
        }

        // copy constructor
        public Circle(Circle c)
        {
            this.r = c.r;
        }

        // default constructor
        public Circle()
        {
            Radius = 0.0;
        }
        public double area()
        {
                return Math.PI * Math.Pow(r,2);
           
        }
        public double perimeter()
        {
         
                return 2 * Math.PI * r;

        }

    }
}
