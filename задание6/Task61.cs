using System;

namespace Задание6.1
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            static bool НазваниеМетода(int m, int n)
            {
                return ((m + n) % 2 == 0) && ((m * n) % 3 == 0);
            }
            Console.WriteLine(НазваниеМетода(m, n));
            Console.ReadKey();
        }
    }
}
