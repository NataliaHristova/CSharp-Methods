using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastDigit
{
    class LastDigit
    { /*Write a method that returns the last digit of given integer as an English word. 
        Examples: 512  "two", 1024  "four", 12309  "nine".*/

        static string GetLastDigit(int num)
        {
            int lastDigit = num % 10;
            switch (lastDigit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid digit!";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int myNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit of {0} is: {1} ", myNumber, GetLastDigit(myNumber));
        }
    }
}
