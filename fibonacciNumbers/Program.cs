using System;

namespace fibonacciNumbers
{
    class Program
    {
        static int FiboNum(int n)
        {
            int fiboThird = 0;
            int fiboFirst = 1;
            int fiboSecond = 1;
            for (int i = 0; i <= n; i++)
            {
                fiboFirst = fiboSecond;
                fiboSecond = fiboThird;
                fiboThird = fiboFirst + fiboSecond;
            }
            return fiboThird;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FiboNum(n));
        }
    }
}
