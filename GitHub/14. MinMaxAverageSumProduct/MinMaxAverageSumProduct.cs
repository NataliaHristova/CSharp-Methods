using System;

namespace _14.MinMaxAverageSumProduct
{
    class MinMaxAverageSumProduct
    {  /* Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        Use variable number of arguments.*/

        static int GetMax(params int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 1];
        }

        static int GetMin(params int[] array)
        {
            Array.Sort(array);
            return array[0];
        }

        static double GetAverage(params int[] array)
        {
            double average = GetSum(array);
            average = average / array.Length;
            return average;

        }

        static int GetSum(params int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }
            return sum;
        }

        static long GetProduct(params int[] array)
        {
            long product = 1;
            for (int index = 0; index < array.Length; index++)
            {
                product *= array[index];
            }
            return product;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer number for length of sequence of integers: ");
            int length = int.Parse(Console.ReadLine());
            int[] myArr = new int[length];
            for (int index = 0; index < length; index++)
            {
                Console.Write("Enter value of element {0}: ", index);
                myArr[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Max = " + GetMax(myArr));
            Console.WriteLine("Min = " + GetMin(myArr));
            Console.WriteLine("Average = " + GetAverage(myArr));
            Console.WriteLine("Sum = " + GetSum(myArr));
            Console.WriteLine("Product = " + GetProduct(myArr));

        }
    }
}
