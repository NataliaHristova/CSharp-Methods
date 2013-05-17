using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggerThanNeighbors
{
    class BiggerThanNeighbors
    {/*Write a method that returns the index of the first element in array that is bigger than its neighbors, 
        or -1, if there’s no such element.*/


        static string CheckElement(int[] array, int position)
        {
            if (position < 0 || position > array.Length - 1)
            {
                return "Invalid index ";
            }

            // ако индекса е в началото имаме само 1 съсед
            if (position == 0)
            {
                // проверяваме съседа от дясно
                if (array[position] > array[position + 1])
                { return "Bigger"; }
                return "Smaller";
            }

            // ако индекса е последният възможен
            if (position == array.Length - 1)
            {
                // проверяваме единственият съсед от ляво
                if (array[position] > array[position - 1])
                { return "Bigger"; }
                return "Smaller";
            }

            // нормален случай имаме 2 съседа
            int leftNeighbour = array[position - 1];
            int rigthNeighbour = array[position + 1];
            if (array[position] > (leftNeighbour + rigthNeighbour))
            {
                return "Bigger";
            }
            return "Smaller";
        }
        static void GetIndex(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                string result = CheckElement(array, index);
                if (result == "Bigger")
                {
                    Console.WriteLine("The index of the first element in array that is bigger than its neighbors is: {0}", index);
                    break;//Прекъсване на цикъла при намиране на първия, отговарящ на условията елемент
                }
                else if (index == array.Length - 1)//Ако сме стигнали до последния елемент и не сме открили елемента, който търсим 
                {
                    Console.WriteLine("-1");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 6, 7, 1, -5, -3, 4, 7, 2, -3, -8, 9 };
            GetIndex(array);
        }
    }
}

