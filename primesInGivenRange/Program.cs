using System;
using System.Collections.Generic;

namespace primesInGivenRange
{
    class Program
    {
        static List<int> IsPrime(int firstNum, int secondNum)
        {
            List<int> primeNum = new List<int>();
            bool isPrime = true;
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i < 2)
                {
                    isPrime = false;
                }
                else 
                {
                    for (int k = 2; k * k <= i; k++)
                    {
                        if (i % k == 0)
                        {
                            isPrime = false;
                        }
                    }
                }
                if (isPrime)
                {
                    primeNum.Add(i);
                }
                isPrime = true;
            }
            return primeNum;

        }
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            List<int> test = IsPrime(first, sec);
            Console.WriteLine(string.Join(", ", test));
        }
    }
}
