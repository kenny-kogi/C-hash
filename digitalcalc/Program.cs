using System;

namespace digitalcalc
{
    class Program
    {
  // Function To Convert Decimal Number to Binary Number
        static void toBinary(int n)
        {

            int[] binaryNumber = new int[32];

     
            int i = 0;
            while (n > 0)
            {
  
                binaryNumber[i] = n % 2;
                n = n / 2;
                i++;
            }
   
            Console.WriteLine("Binary of the given number = ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(binaryNumber[j]);
        }
        // Function To Convert Decimal Number to Octal Number
        static void toOctal(int n)
        {
  
            int[] octalNum = new int[100];
  
            int i = 0;
            while (n != 0)
            {
      
                octalNum[i] = n % 8;
                n = n / 8;
                i++;
            }
   
            Console.WriteLine("\nOctal of the given number = ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(octalNum[j]);
        }

        // Function To Convert Decimal Number to Hexadecimal Number
        static void toHexa(int n)
        {
    
            char[] hexaDeciNum = new char[100];

   
            int i = 0;
            while (n != 0)
            {
          
                int temp = 0;

                temp = n % 16;

                if (temp < 10)
                {
                    hexaDeciNum[i] = (char)(temp + 48);
                    i++;
                }
                else
                {
                    hexaDeciNum[i] = (char)(temp + 55);
                    i++;
                }
                n = n / 16;
            }
            // Printing Hexadecimal Number Array In Reverse Order
            Console.WriteLine("\nHexadecimal of the given number = ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(hexaDeciNum[j]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number of your choice : ");
            int n = Convert.ToInt32(Console.ReadLine());

            toBinary(n);
            toOctal(n);
            toHexa(n);
        }
    }
}
