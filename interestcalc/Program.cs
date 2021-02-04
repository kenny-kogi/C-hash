using System;

namespace interestcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.Write("Enter the Principal: ");
            Double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate in %: ");
            Double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Time per annum: ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose what to calculate");
            Console.WriteLine("1. Simple Interest: ");
            Console.WriteLine("2. Compound Interest: ");

            int det = Convert.ToInt32(Console.ReadLine());
            
            switch(det){
                case 1:
                    Double simpleinterest;
                    simpleinterest = principal * (rate/100) * time;
                    Console.WriteLine("Simple Interest = " + simpleinterest);
                    break;

                case 2:
                    Console.Write("number of times that interest is compounded per unit time: ");
                    Double n = Convert.ToDouble(Console.ReadLine());
                    Double compoundinterest;
                    compoundinterest = Math.Pow((1 + (rate/100)/n), (n * time));
                    Console.WriteLine("Compound Interest = " + principal * compoundinterest);
                    break;



            }



        }
    }
}
