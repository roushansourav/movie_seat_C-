using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 10, 6, 4, 3, 15, 20, 17, 11 };
            BubbleSort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine("\n");
        }

        private static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        swap(numbers, i, j);
                    }
                }
            }
        }

        private static void swap(int[] numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
