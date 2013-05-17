using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaximalElementInPortionOfArray
{
    class MaximalElementInPortionOfArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 6,3,8,4};
            SortArr(arr);
        }

        static void SortArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // намираме позицията на най-големия елемент до края на масива
                int maxElementIndex = GetMaxElementIndex(arr, i+1);
                // Ако сме намерили елемент, който е по-голям от елемента на текущата позиция i ги разменяме
                if (arr[i] < arr[maxElementIndex])
                {
                    int buff = arr[i];
                    arr[i] = arr[maxElementIndex];
                    arr[maxElementIndex] = buff;
                }
            }
            // принтим сортираният масив
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }

        // Връща индекса на най-големия елемент, от подадената позиция до края на масива
        static int GetMaxElementIndex(int[] arr, int startPosition)
        {
            int maxElementPosition = startPosition;
            for (int i = startPosition; i < arr.Length ; i++)
            {
                if (arr[i] > arr[maxElementPosition])
                {
                    maxElementPosition = i;
                }
            }
            return maxElementPosition;
        }
    }
}
