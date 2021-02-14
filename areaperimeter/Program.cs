using System;

namespace areaperimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area and Perimeter of Circle");
           Circle myCircler = new Circle(32);
            myCircler.Area();
            Circle.Perimeter(5);

            Console.WriteLine("Area and Perimeter of Rectangle");
           Rectangle rect = new Rectangle(32, 4);
            rect.Area();
            Rectangle.Perimeter(32, 4);

            Console.WriteLine("Area and Perimeter of Square");
           Square sqr = new Square(32);
            sqr.Area();
            Square.Perimeter(5);            
        }
    }
}
