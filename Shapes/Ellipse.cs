using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Ellipse : Shape
    {
        private double ax = DefaultMajor;
        private double ay = DefaultMinor;


     public Ellipse()
        {
             
        }

    public Ellipse(double ax, double ay)
        {
            this.ax = ax;
            this.ay = ay;
        }
    public double area()
        {
            return (Math.PI * ax * ay);
        }

    public double perimeter()
        {
            return (Math.PI * (3 * (ax + ay) - Math.Sqrt((3 * ax + ay) * (ax + 3 * ay))));
        }
    }
}
