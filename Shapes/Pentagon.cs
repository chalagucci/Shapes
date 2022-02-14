using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Pentagon : Shape
    {
        private double s = DefaultLength2;
        private double a = DefaultLength;
        
        public Pentagon()
        {

        }


        // creates a pentagon object
        public Pentagon(double s, double a)
        {
            this.s = s;
            this.a = a;
        }


        public double area()
        {
            double p = perimeter();
            return (p / a) * 2;

        }


        public double perimeter()
        {
            return 5 * s;
            
        }
    }
}
