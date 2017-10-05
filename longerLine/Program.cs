using System;

namespace longerLine
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
        static string LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4 , double y4)
        {
            double minX = 0;
            double minY = 0;
            double minX2 = 0;
            double minY2 = 0;
            if (Math.Abs(Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2)) >=
                Math.Abs(Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4)))
            {
                minX = x1;
                minY = y1;
                minX2 = x2;
                minY2 = y2;
                if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
                {
                    minX = x1;
                    minY = y1;
                    minX2 = x2;
                    minY2 = y2;
                }
                else
                {
                    minX = x2;
                    minY = y2;
                    minX2 = x1;
                    minY2 = y1;
                }
            }
            else
            {
                minX = x3;
                minY = y3;
                minX2 = x4;
                minY2 = y4;
                if (Math.Abs(x3) + Math.Abs(y3) <= Math.Abs(x4) + Math.Abs(y4))
                {
                    minX = x3;
                    minY = y3;
                    minX2 = x4;
                    minY2 = y4;
                }
                else
                {
                    minX = x4;
                    minY = y4;
                    minX2 = x3;
                    minY2 = y3;
                }
            }
                
            string result = "(" + minX + ", " + minY + ")(" + minX2 + ", " + minY2 + ")";
            return result;
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            Console.WriteLine(LongerLine(x1,y1,x2,y2,x3,y3,x4,y4));
        }
    }
}
