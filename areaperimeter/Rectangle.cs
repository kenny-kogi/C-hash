using System;

namespace areaperimeter
{
    class Rectangle
    {
        public double width, len;
        
        public Rectangle(int wdth, int ln){
            width = wdth;
            len = ln;
        }
        

        public void Area(){
            Console.WriteLine(width * len);
        }



        public static void Perimeter(int wd, int lnr ){
            Console.WriteLine((wd + lnr) * 2);
        }



    }
}
