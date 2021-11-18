using System;

namespace Ekaterina_Musatova_дз5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";

            str = "саксофон"; //с-0 а-1 к-2 с-3 о-4 ф-5 о-6 н-7
            Console.WriteLine(str);

            string result = str.Substring(7);
            str.Substring(6, 1);
            str.Substring(3, 2);
            str.Substring(2, 1);


            Console.WriteLine(result);
            string resalt = str.Substring(5, 1);
            str.Substring(1, 1);
            str.Substring(0, 1);
            str.Substring(4, 1);
            str.Substring(7, 1);

            Console.WriteLine(resalt);
            Console.ReadKey();
        }
    }
}
