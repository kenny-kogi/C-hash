using System;

namespace areaperimeter
{
    class Circle
    {
        public double radius;
        
        public Circle(int radi){
            radius = radi;
        }
        

        public void Area(){
            Console.WriteLine(Math.PI * Math.Pow(radius, 2));
        }



        public static void Perimeter(int r){
            Console.WriteLine(2 * Math.PI * r);
        }



    }
}
