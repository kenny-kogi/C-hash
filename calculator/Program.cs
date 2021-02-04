using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1: ");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Operator: ");
            string oper = Console.ReadLine();
            Console.Write("Enter Number 2: ");
            Double num2 = Convert.ToDouble(Console.ReadLine());


            switch (oper){
                case "x":
                    Console.WriteLine(num1 * num2);
                    break;
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }
    }
}
