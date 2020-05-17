using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = ReadArray();
            var range = ReadRange();
            var summ = GetSummOnRangeInArray(range, array);

            Console.WriteLine($"Summ = {summ}");
        }

        private static int GetSummOnRangeInArray(int[] range, int[] array)
        {
            int summ = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= range[0] && array[i] <= range[1])
                {
                    summ += array[i];
                }
            }

            return summ;
        }
        
        private static int[] ReadArray()
        {
            Console.Write("Enter array length: ");
            var arrayLength = ReadNumber();
            var array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter array[{i}]: ");
                array[i] = ReadNumber();
            }

            return array;
        }

        private static int[] ReadRange()
        {
            var range = new int[2];
            Console.Write("Enter low bound: ");
            range[0] = ReadNumber();
 
            Console.Write("Enter upper bound: ");
            while ((range[1] = ReadNumber()) < range[0])
            {
                Console.WriteLine($"Upper bound can't be less {range[0]}, try again!");
            }

            return range;
        }

        private static int ReadNumber() // Метод считывающий число с консоли
        {
            int number; // Инициализация переменной
            while (!int.TryParse(Console.ReadLine(), out number)) // Пробуем привести введеное значение к числу
            {
                Console.WriteLine("You must enter number, try again"); // Пока не получим число, будем писать ошибку
            }

            return number; // Возвращаем полученное число
        }
    }
}