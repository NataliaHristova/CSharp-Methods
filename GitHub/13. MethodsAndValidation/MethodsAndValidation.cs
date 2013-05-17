using System;

namespace _13.MethodsAndValidation
{
    class MethodsAndValidation
    {
        /*Write a program that can solve these tasks:
            +Reverses the digits of a number
            +Calculates the average of a sequence of integers
            +Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
            +The decimal number should be non-negative
            +The sequence should not be empty
            +a should not be equal to 0
*/
        static void ReversesDigits(string num)
        {
            Console.Write("The number {0} after reversing its digits: ", num);
            for (int index = num.Length - 1; index >= 0; index--)//Отпечатва стринга отзад напред
            {
                Console.Write(num[index]);
            }
            Console.WriteLine();
        }
        static void CalculateAverage(int[] arr)
        {
            double average = 0;
            for (int index = 0; index < arr.Length; index++)//Събира всички елементи на подадената редица от числа
            {
                average = average + (double)arr[index];
            }
            average = average / arr.Length;
            Console.Write("The average of the sequence ");
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("is: " + average);

            Console.WriteLine();
        }
        static void SolveLinearEquation(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("{0} * x + {1} = 0 =>   each x", a, b);//EN?
                }
                else
                {
                    Console.WriteLine("{0} * x + {1} = 0 =>  no solution", a, b);
                }
            }
            else
            {
                double result = ((-1) * b) / a;
                Console.WriteLine("{0} * x + {1} = 0 => x = {2} ", a, b, result);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which task to solve:");
            Console.WriteLine("Press 1 for Reverses the digits of a number");
            Console.WriteLine("Press 2 for Calculates the average of a sequence of integers");
            Console.WriteLine("Press 3 for Solves a linear equation a * x + b = 0");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter a positive integer number: ");
                string myNum = Console.ReadLine(); //Взимам стойността на числото като стринг

                int inputNumber;
                var isValidInteger = int.TryParse(myNum,out inputNumber); 
                if(!isValidInteger || inputNumber < 0)
                {
                    Console.WriteLine("Entered number is not valid. Should be positive.");
                }

                ReversesDigits(myNum);
            }
            else if (choice == 2)
            {
                Console.Write("Enter a positive integer number for length of sequence of integers: ");
                int length = int.Parse(Console.ReadLine());
                if (length == 0)
                {
                    Console.WriteLine("Length of sequence cannot be equal to 0!");
                    return;
                }
                int[] myArr = new int[length];
                for (int index = 0; index < length; index++)
                {
                    Console.Write("Enter value of element {0}: ", index);
                    myArr[index] = int.Parse(Console.ReadLine());
                }
                CalculateAverage(myArr);
            }
            else if (choice == 3)
            {
                Console.Write("Enter  a value of a: ");
                double a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Parameter a cannot be equal to 0!");
                    return;
                }

                Console.Write("Enter  a value of b: ");
                double b = double.Parse(Console.ReadLine());
                SolveLinearEquation(a, b);
            }
            else
            {
                Console.WriteLine("There's no such task!");
            }
        }
    }
}
