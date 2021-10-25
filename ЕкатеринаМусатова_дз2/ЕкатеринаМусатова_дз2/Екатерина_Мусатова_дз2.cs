using System;

namespace ЕкатеринаМусатова_дз2
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, k1, k2, c;
            Console.WriteLine("enter the first katet");
            k1 = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the second katet");
            k2 = double.Parse(Console.ReadLine());

            c = Math.Sqrt(k1 * k1 + k2 * k2);
            h = (k1 * k2) / c;

            Console.WriteLine("H = " + h);
        }
    }
}
