using System;

namespace cubeProperties
{
    class Program
    {
        static double CubeProperties(double side, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {
                result = Math.Sqrt(2) * side;
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3) * side;
            }
            else if (parameter == "volume")
            {
                result = side * side * side;
            }
            else if (parameter == "area")
            {
                result = 6 * side * side;
            }
            return result;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Console.WriteLine("{0:f2}",CubeProperties(side, parameter));
        }
    }
}
