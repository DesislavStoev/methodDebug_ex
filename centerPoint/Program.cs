using System;
using System.Collections.Generic;

namespace centerPoint
{
    class Program
    {
        static string ClosestToCenter(double x1, double y1, double x2, double y2)
        {
             double minX = 0;
             double minY = 0;
            
            if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
            {
                minX = x1;
                minY = y1;
            }
            else
            {
                minX = x2;
                minY = y2;
            }
            string result = "(" + minX + ", " + minY + ")";
            return result;
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(ClosestToCenter(x1,y1,x2,y2));
        }
    }
}