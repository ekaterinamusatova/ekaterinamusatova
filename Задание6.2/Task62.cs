using System;

namespace Задание6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            static bool НазваниеМетода(double x, double y)
            {
                return ((x <= -2) && (y >= 1));
            }
            Console.WriteLine(НазваниеМетода(x, y));
            Console.ReadKey();
        }
    }
}
