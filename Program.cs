using System;
using System.Collections.Generic;

namespace MergeIntoOneCollection
{
    class Program
    {
        static void Main()
        {
            int[] firstArray = { 1, 2, 3, 4, 4, 4 };
            int[] secondArray = { 5, 2, 6, 2 };
            List<int> uniqueNumbers = new List<int>();

            SelectUniqueValue(firstArray,  uniqueNumbers);
            SelectUniqueValue(secondArray,  uniqueNumbers);
            PrintNumbers(uniqueNumbers);

        }

        private static void SelectUniqueValue(int[] arrayNumbers, List<int> numbers
)
        {
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int value= arrayNumbers[i];

                if (numbers.Contains(value)==false)
                {
                    numbers.Add(value);
                }
            }
        }
        private static void PrintNumbers(List<int> numbers)
        {
            for(int i = 0;i < numbers.Count; i++)
            {
                Console.WriteLine($"число {numbers[i]} под номером {i+1}");
            }
        }
    }
}