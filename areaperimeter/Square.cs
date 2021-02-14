using System;

namespace areaperimeter
{
    class Square
    {
        public double len;
        
        public Square(int length){
            len = length;
        }
        

        public void Area(){
            Console.WriteLine(Math.Pow(len, 2));
        }



        public static void Perimeter(int r){
            Console.WriteLine(4 * r);
        }



    }
}
