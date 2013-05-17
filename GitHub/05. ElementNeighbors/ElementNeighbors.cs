using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ElementNeighbors
{
    class ElementNeighbors
    { /*Write a method that checks if the element at given position in given array of integers is bigger 
        than its two neighbors (when such exist).*/

        static void CheckElement(int[] array, int position)
        {
            if (position < 0 || position > array.Length - 1)
            {
                Console.WriteLine("Invalid index " + position);
                return;
            }
            
            // ако индекса е в началото имаме само 1 съсед
            if (position == 0)
            {
                // проверяваме съседа от дясно
                if (array[position] > array[position + 1])
                    Console.WriteLine("Bigger");
                Console.WriteLine("Smaller");
            }

            // ако индекса е последният възможен
            if (position == array.Length - 1)
            {
                // проверяваме единственият съсед от ляво
                if(array[position] > array[position-1])
                    Console.WriteLine("Bigger");
                Console.WriteLine("Smaller");
            }

            // нормален случай имаме 2 съседа
            int leftNeighbour = array[position - 1];
            int rigthNeighbour = array[position + 1];
            if(array[position] > (leftNeighbour+rigthNeighbour))
                Console.WriteLine("Bigger");
            Console.WriteLine("Smaller");
        }
        static void Main(string[] args)
        {
            int position = 3;
            int[] arr = { 2, 5, 6, 7, 1, -5, -3, 4, 7, 2, -3, -8, 9 };
            CheckElement(arr, position);
        }
    }
}
