using System;

namespace Задание8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = 0;
            while ((m * m * m + m + 1) < n)
                m++;
            Console.WriteLine(m * m * m + m + 1);
            Console.ReadKey();
        }
    }
}
