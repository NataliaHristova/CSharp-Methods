using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MethodReversesDigits
{
    class MethodReversesDigits
    {//Write a method that reverses the digits of given decimal number. Example: 256  652

        static void ReversesDigits(string num)
        {
            Console.Write("The number {0} after reversing its digits: ", num);
            for (int index = num.Length-1; index >= 0; index--)//Отпечатва стринга отзад напред
            {
                Console.Write(num[index]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            string myNum = Console.ReadLine(); //Взимам стойността на числото като стринг
            ReversesDigits(myNum);
        }
    }
}
