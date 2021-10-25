using System;

namespace Екатерина_Мусатова.дз
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Анна Ахматова <<А мы?>>");
            {
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Yellow;
                {
                    Console.WriteLine("А мы?");
                    Console.ReadKey();
                    Console.WriteLine("Не так же ль мы");
                    Console.ReadKey();
                    Console.WriteLine("Сошлись на краткий миг для переклички?");
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Анна Ахматова <<А мы?>>");
                        Console.WriteLine("А мы?");
                        Console.WriteLine("Не так же ль мы");
                        Console.WriteLine("Сошлись на краткий миг для переклички?");
                    }
                }
            }
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        }
    }
}
