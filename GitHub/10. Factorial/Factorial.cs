using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Factorial
{   //Write a program to calculate n! for each n in the range [1..100]. 
    class Factorial
    {
        static void CalculateFactorial()
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= 100; i++)
            {
                factorial *= i;
                Console.WriteLine("{0}! = {1} ", i,  factorial);
            }
        }
        static void Main(string[] args)
        {
            CalculateFactorial();
        }
    }
}
