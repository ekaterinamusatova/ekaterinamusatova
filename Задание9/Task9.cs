using System;

namespace Задание9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            array[0] = 1;
            for (var i = 1; i < array.Length; i++)
                array[i] = array[i - 1] * 2;
            int b = int.Parse(Console.ReadLine());
            for (var i = 0; i < array.Length; i++)
                array[i] -= b;
            static void PrintArray(int[] array)
            {
                Console.WriteLine(String.Join("; ", array));
                return;
            }
            static int[] ChangeArraySigns(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                    if (i % 2 != 0)
                        array[i] = -array[i];
                return array;
            }
            static double GetAverage(int[] array)
            {
                var summa = 0;
                for (int i = 0; i < array.Length; i++)
                    summa += array[i];
                return (summa / array.Length);
            }
            static int[] GetArrayOfModulos(int[] array)
            {
                int[] newArray = new int[array.Length];
                int k = int.Parse(Console.ReadLine());
                for (int i = 0; i < array.Length; i++)
                    newArray[i] = array[i] % k;
                return newArray;
            }
            PrintArray(array);
            PrintArray(ChangeArraySigns(array));
            Console.WriteLine("{0:0.000}", GetAverage(array));
            PrintArray(GetArrayOfModulos(array));
            Console.ReadKey();
        }
    }
}
