using System;

namespace primeChecker
{
    class Program
    {
        static bool IsPrime(long n)
        {
            if (n < 2)
                return false;
            {
                for (long i = 2; i*i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
            
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
    }
}
