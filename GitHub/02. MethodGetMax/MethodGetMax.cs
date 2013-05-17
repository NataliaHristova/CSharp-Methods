using System;

namespace _02.MethodGetMax
{
    class MethodGetMax
    {/*Write a method GetMax() with two parameters that returns the bigger of two integers.
        Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/


        //This method compares 2 int numbers and returns the biggest one
        static int GetMax(int n, int m)
        {
            int biggestNum = n;
            if (m > n)
            {
                biggestNum = m;
            }
            return biggestNum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the third integer number: ");
            int thirdNum = int.Parse(Console.ReadLine());

            //Comparing the biggest number of the first two numbers with the third 
            int bestNum = GetMax(GetMax(firstNum, secondNum), thirdNum);
            Console.WriteLine("The biggest number is: {0}", bestNum);
        }
    }
}