using System;
namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива, используя числа от 5 до 20");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m, n];
            Random rand = new Random();
            for (var i = 0; i < array.GetLength(0); i++)
                for (var j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rand.Next(0, 99);
            PrintArray(array);
            Console.WriteLine("Введите необходимый диапазон");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            IsInRange(array, a, b);
            GetMax(array);
            Console.ReadKey();
        }
        static void PrintArray(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t");
                Console.WriteLine();
            }
            return;
        }
        static void IsInRange(int[,] array, int a, int b)
        {
            for (var i = 0; i < array.GetLength(0); i++)
                for (var j = 0; j < array.GetLength(1); j++)
                    if ((array[i, j] <= a) || (array[i, j] >= b))
                    {
                        Console.WriteLine($"Элемент, находящийся в {i + 1} строке {j + 1} столбце, нарушает указанное условие");
                        return;
                    }
            Console.WriteLine($"Элементы массива находятся в заданном интервале");
            return;
        }
        static void GetMax(int[,] array)
        {
            int max;
            for (var i = 0; i < array.GetLength(1); i++)
            {
                max = 0;
                for (var j = 0; j < array.GetLength(0); j++)
                    if (array[j, i] > max)
                        max = array[j, i];
                Console.WriteLine($"Максимальный элемент в {i + 1} столбце равен {max}");
            }
            return;
        }
    }
}
