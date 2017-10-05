using System;

namespace maxMethod
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(a,b),c));
        }
    }
}
