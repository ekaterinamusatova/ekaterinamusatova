using System;

namespace Задание8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            for (var i = 2; i < 10; i++)
                Console.WriteLine($"{i} * {k} = {i * k}");
            Console.ReadKey();
        }
    }
}
