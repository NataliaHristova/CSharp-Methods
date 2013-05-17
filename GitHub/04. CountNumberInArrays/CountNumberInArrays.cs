using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountNumberInArrays
{
    class CountNumberInArrays
    {   /* Write a method that counts how many times given number appears in given array. 
         Write a test program to check if the method is working correctly.*/

        static void CountNumber(int num, params int[] numbers)
        {
            int count = 0;
            //Проверка на всеки елемент от подадения масив дали е равен на подаденото число, чието повторение търсим
            for (int index = 0; index < numbers.Length; index++)
            {

                if (numbers[index] == num)//Ако стойността на текущия елемнт е равна на числото, което търсим броячът се увеличава
                {
                    count++;
                }
            }
            Console.WriteLine("Number {0} appears {1} times in the given array.", num, count);
        }
        static void Main(string[] args)
        {
            //Test
            int inputNumber = 5;
            CountNumber(inputNumber, 4, 5, 1, 2, 9, 5, 5, 5, 3, 2, 5, 8, 5, 9, 5);
        }
    }
}
