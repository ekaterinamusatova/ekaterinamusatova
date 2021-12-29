using System;

namespace Задание8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = 0.0;
            for (var i = 0; i < n; i++)
                a += double.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
