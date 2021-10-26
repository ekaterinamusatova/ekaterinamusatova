using System;

namespace Ekaterina_Musatova_дз3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x, x2;
            Console.WriteLine("enter x:");
            x = double.Parse(Console.ReadLine());
            x2 = Math.Pow(x, 2);
            y = (3 + (2 + 1 / (x2 + 1) / (x2 + 2))) / x2 + 3;
            Console.WriteLine("y ="+ y);
        }
    }
}
