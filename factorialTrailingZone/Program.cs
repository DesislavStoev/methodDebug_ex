using System;
using System.Numerics;

namespace factorialTrailingZone
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            BigInteger lastDigit = 0;
            int zeroCount = -1;
            BigInteger testFact = factorial;
            do
            {
                lastDigit = testFact % 10;
                testFact = testFact / 10;
                zeroCount++;
            } while (lastDigit == 0);
            Console.WriteLine(zeroCount);
        }
    }
}
