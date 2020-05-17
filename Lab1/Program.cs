using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: "); // Просим ввести длину массива
            var arrayLength = ReadNumber(); // Вызываем метод, который прочитает число с консоли (стр. 58)
            var array = GetRandomArray(arrayLength); // Вызываем метод, который создаст массив случайных чисел (стр. 36)
            PrintArray(array); // Вызываем метод, который выведет на консоль массив

            Console.Write("Enter number from 0 to 50: "); // Просим ввести число в диапазоне от 0 до 50 (его будем искать в массиве)
            var number = ReadNumber(); // Вызываем метод, который прочитает число с консоли (стр. 58)

            var numberCountInArray = GetNumberCountInArray(number, array); // Вызываем метод, который посчитает количество указанных цифр в массиве (стр. 21)
            Console.WriteLine($"Number {number} is in array {numberCountInArray} time"); // Выводим результат на консоль
        }

        private static int GetNumberCountInArray(int number, int[] array) // Метод считает количество цифр в массиве (на вход получаем число и массив на выходе число)
        {
            int count = 0; // Инициализируем счетчик

            for (int i = 0; i < array.Length; i++) // Цикл для перебора массива
            {
                if (number == array[i]) // Если данный элемент массива равен указанному числу
                {
                    count++; // Увеличиваем счетчик на 1
                }
            }

            return count; // Возвращаем значение счетчика
        }

        private static int[] GetRandomArray(int arrayLength) // Создаем случайный массив (на вход принимаем длину массива, возвращаем массив)
        {
            var random = new Random(); // Инициализация объекта генерации псевдослучайных чисел
            var array = new int[arrayLength]; // Инициализация массива указанной длины

            for (int i = 0; i < arrayLength; i++) // Цикл перебора массива
            {
                array[i] = random.Next(50); // Присваиваем данному элементу массива случайное число от 1 до 50
            }

            return array; // Возвращаем массив
        }

        private static void PrintArray(int[] array) // Метод печати массива
        {
            for (int i = 0; i < array.Length; i++) // Цикл перебора массива
            {
                Console.Write($"{array[i]} "); // Выводим в одну строку указанный элемент
            }
            Console.WriteLine(); // Перевод курсора на новую строку
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