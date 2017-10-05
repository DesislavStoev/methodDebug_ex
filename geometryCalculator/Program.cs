using System;

namespace geometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;
            if (figureType == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }
            else if (figureType == "square")
            {
                double s = double.Parse(Console.ReadLine());
                area = s * s;
            }
            else if (figureType == "rectangle")
            {
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = w * h;
            }
            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            Console.WriteLine($"{area:f2}");
        }
    }
}
