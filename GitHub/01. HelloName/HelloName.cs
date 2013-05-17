using System;

namespace _01.HelloName
{
    class HelloName
    {/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
       Write a program to test this method.*/
        static void SayHello()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            //Test
            SayHello();
            Console.Write(" Nice to meet you :)");
            Console.WriteLine();
        }
    }
}