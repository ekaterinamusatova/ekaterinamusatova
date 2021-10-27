using System;

namespace Задание7
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            static double НазваниеМетода(double x)
            {
                if (x < -2)
                    return Math.Log10(x * x);
                else if (x > 1)
                    return Math.Cos(x);
                else
                    return Math.Pow(Math.E, x);
            }
            Console.WriteLine(НазваниеМетода(x));
            Console.ReadKey();
        }
    }
}
