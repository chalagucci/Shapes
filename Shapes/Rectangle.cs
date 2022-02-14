using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Rectangle : Shape
    {
        private double width = Defaultwidth; 
        private double height = Defaultheight;
        public Rectangle()
        {
           
        }

        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
         
        }

        public double area()
        {
                return width * height;
        }

        public double perimeter()
        {
            return 2 * (width + height);
        }
        
    }
}

