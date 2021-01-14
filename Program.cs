using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            while (loop)
            {
                Console.Write("Decimal: ");

                int decimalNumber = int.Parse(Console.ReadLine());
                string result = DecToBinary(decimalNumber).ToString();
                Console.WriteLine(result);

                List<string> results = new List<string>(result.Trim().Split(" "));
                List<int> bits = results.ConvertAll(int.Parse);
                foreach(int bit in bits)
                {
                    Console.WriteLine(bit);
                }
            }
        }
        private static System.Text.StringBuilder DecToBinary(int n)
        {
            // Size of an integer is assumed to be 32 bits 
            var result = new System.Text.StringBuilder();
            for (int i = 15; i >= 0; i--)
            {
                int k = n >> i;
                if ((k & 1) > 0)
                    result.Append("1 ");
                else
                    result.Append("0 ");
            }
            return result;
        }
    }
}
