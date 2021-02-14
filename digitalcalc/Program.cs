using System;

namespace digitalcalc
{
    class Program
    {
  // Function To Convert Decimal Number to Binary Number
        static void toBinary(int n)
        {
            // Array To Store Binary Number 
            int[] binaryNumber = new int[32];

            // Counter For Binary Array 
            int i = 0;
            while (n > 0)
            {
                // Storing Remainder In Binary Array 
                binaryNumber[i] = n % 2;
                n = n / 2;
                i++;
            }
            // Printing Binary Array In Reverse Order
            Console.WriteLine("Binary of the given number = ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(binaryNumber[j]);
        }
        // Function To Convert Decimal Number to Octal Number
        static void toOctal(int n)
        {
            // Array To Store Octal Number
            int[] octalNum = new int[100];
            // Counter For Octal Number Array
            int i = 0;
            while (n != 0)
            {
                // Storing Remainder In Octal Array
                octalNum[i] = n % 8;
                n = n / 8;
                i++;
            }
            // Printing Octal Number Array In Reverse Order
            Console.WriteLine("\nOctal of the given number = ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(octalNum[j]);
        }

        // Function To Convert Decimal Number to Hexadecimal Number
        static void toHexa(int n)
        {
            // char Array To Store Hexadecimal Number 
            char[] hexaDeciNum = new char[100];

            // Counter For Hexadecimal Number Array 
            int i = 0;
            while (n != 0)
            {
                // Temporary Variable To Store Remainder 
                int temp = 0;

                // Storing Remainder In Temp Variable. 
                temp = n % 16;

                // Checks If temp < 10 
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
