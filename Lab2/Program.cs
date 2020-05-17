using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = ReadArray(); // Читаем массив (стр. 31)
            var range = ReadRange(); // Читаем диапазон для суммирования (стр. 46)
            var summ = GetSummOnRangeInArray(range, array); // Считаем сумму (стр. 16)

            Console.WriteLine($"Summ = {summ}"); // Выводим результат на  экран
        }

        private static int GetSummOnRangeInArray(int[] range, int[] array) // Метод будет считать сумму элементов массива в указанном диапазоне (на входе диапазон и массив)
        {
            int summ = 0; // Инициализируем переменную для суммы

            for (int i = 0; i < array.Length; i++) // Метод перебора массива
            {
                if (array[i] >= range[0] && array[i] <= range[1]) // Если данный элемент массива находится в указанном диапазоне
                {
                    summ += array[i]; // Увеличиваем значение суммы на значение текущего элемента массива
                }
            }

            return summ; // Возвращаем сумму
        }
        
        private static int[] ReadArray()
        {
            Console.Write("Enter array length: "); // Просим ввести длину массива
            var arrayLength = ReadNumber(); // Вызываем метод чтения числа (стр. 61)
            var array = new int[arrayLength]; // Инициализируем массив указанной длины

            for (int i = 0; i < arrayLength; i++) // Перебираем массив
            {
                Console.Write($"Enter array[{i}]: "); // Просим ввести указанный элемент массива
                array[i] = ReadNumber(); // Вызываем метод чтения числа (стр. 61)
            }

            return array; // Возвращаем массив
        }

        private static int[] ReadRange() // Метод чтения диапазона
        {
            var range = new int[2]; // Инициализируем массив в 2 элемента
            Console.Write("Enter low bound: "); // Просим ввести нижнюю граница диапазона
            range[0] = ReadNumber(); // Вызываем метод чтения числа (стр. 61)
            
            Console.Write("Enter upper bound: "); // Просим ввести верхнюю границу диапазона
            while ((range[1] = ReadNumber()) < range[0]) // Пока пользователь вводит число меньше нижней границы
            {
                Console.WriteLine($"Upper bound can't be less {range[0]}, try again!"); // Ругаемся на него и просим ввести заново
            }

            return range; // Возвращаем полученный диапазон
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