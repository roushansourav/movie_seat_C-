using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 10, 6, 4, 3, 15, 20, 17, 11 };
            SelecionSort(numbers);

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + "/t");
        }

        private static void SelecionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int small_index = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[small_index] > numbers[j])
                    {
                        small_index = j;
                    }
                }
                Swap(numbers, i, small_index);
            }
        }

        private static void Swap(int[] numbers, int i, int small_index)
        {
            int temp = numbers[i];
            numbers[i] = numbers[small_index];
            numbers[small_index] = temp;
        }
    }
}
