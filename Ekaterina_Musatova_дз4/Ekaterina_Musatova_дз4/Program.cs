using System;

namespace Ekaterina_Musatova_дз4
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = XY1(0, XY1(1, XY1(2, 3 + Math.Sqrt(5))));
            Console.WriteLine(Math.Round(x,3));
        }
        static double XY1(double n1, double n2)
        {
            return n1 + (1/n2);
        }
    }
}
