using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            var arrayLength = ReadNumber();
            var array = GetRandomArray(arrayLength);
            PrintArray(array);

            Console.Write("Enter number from 0 to 50: ");
            var number = ReadNumber();

            var numberCountInArray = GetNumberCountInArray(number, array);
            Console.WriteLine($"Number {number} is in array {numberCountInArray} time");
        }

        private static int GetNumberCountInArray(int number, int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    count++;
                }
            }

            return count;
        }

        private static int[] GetRandomArray(int arrayLength)
        {
            var random = new Random();
            var array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(50);
            }

            return array;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        
        private static int ReadNumber()
        {
            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("You must enter number, try again");
            }

            return number;
        }
    }
}