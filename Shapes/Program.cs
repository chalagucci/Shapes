using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
    class Program : Shape 
    {

        static void Main(string[] args)
        {
            var square = new Square();
            Console.WriteLine();

            var rectangle = new Rectangle();
            Console.WriteLine();

            var circle = new Circle();
            Console.WriteLine();

            var pentagon = new Pentagon();
            Console.WriteLine();

            var ellipse = new Ellipse();
            
            Console.WriteLine();


            Console.WriteLine("The area of square is: " + square.area());
            Console.WriteLine("The perimeter of square is: " + square.perimeter());
            Console.WriteLine();

            Console.WriteLine("The area of rectangle is: " + rectangle.area());
            Console.WriteLine("The perimeter of rectangle is: " + rectangle.perimeter());
            Console.WriteLine();

            Console.WriteLine("The area of circle is: " + circle.area());
            Console.WriteLine("The perimeter of circle is: " + circle.perimeter());
            Console.WriteLine();

            Console.WriteLine("The area of pentagon is: " + pentagon.area());
            Console.WriteLine("The perimeter of pentagon is: " + pentagon.perimeter());
            Console.WriteLine();


            Console.WriteLine("The area of ellipse is: " + ellipse.area());
            Console.WriteLine("The perimeter of ellipse is: " + ellipse.perimeter());
            

           


        }
    }
}
