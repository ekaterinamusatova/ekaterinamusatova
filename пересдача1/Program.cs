using System;

namespace пересдача1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 4; i < 10000000; i++)
                if (IsHalfPrimeNumbers(i))
                    count++;
            Console.WriteLine($"Количество полупростых чисел, меньших 10000000, равно { count}");
            Console.ReadKey();
        }
        static bool IsHalfPrimeNumbers(int n)
        {
            int i = 2;
            if (IsPrimeNumbers(n))
                return false;
            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    n /= i;
                    if (IsPrimeNumbers(n))
                    {
                        Console.WriteLine(n * i);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else 
                {
                    i++;
                }
            }
            return true;
        }
        static bool IsPrimeNumbers(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
