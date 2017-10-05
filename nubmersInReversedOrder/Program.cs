using System;

namespace nubmersInReversedOrder
{
    class Program
    {
        static void NumbersReverse (double n)
        {
            char [] arr =  n.ToString().ToCharArray();
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            NumbersReverse(num);
        }
    }
}
