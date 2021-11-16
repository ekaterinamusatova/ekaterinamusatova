using System;

namespace Ekaterina_Musatova_дз3
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = XY1(0, XY1(3, XY1(2, 1, Math.Pow(x, 2) + 1), Math.Pow(x, 2) + 2), Math.Pow(x, 2) + 3);
            Console.WriteLine;
        }
        static double XY1(double n1, double n2, double n3)
        {
            return n1 + (n2/n3);
        }
    }
}
