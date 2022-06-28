using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var kv = new Dictionary<string, HashSet<string>>();

            using (var reader = new StreamReader(@"C:\Users\katte\source\repos\ConsoleApp3\synonyms_en.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var input = reader.ReadLine();
                    var spl = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

                    var value = new HashSet<string>();

                    for (int i = 1; i < spl.Length; i++)
                    {
                        value.Add(spl[i]);
                    }

                    if (kv.ContainsKey(spl[0]))
                    {
                        foreach (var item in value)
                        {
                            kv[spl[0]].Add(item);
                        }
                    }
                    else
                    {
                        kv.Add(spl[0], value);
                    }
                }
            }


            Console.WriteLine($"Введите слово:");
            var word = Console.ReadLine();

            if (kv.ContainsKey(word))
            {
                Console.WriteLine(string.Join(",", kv[word]));
            }
            else
            {
                Console.WriteLine($"Слово отсутствует");
            }


            Console.ReadKey();
        }
    }
}
