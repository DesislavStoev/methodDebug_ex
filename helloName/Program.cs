using System;

namespace helloName
{
    class Program
    {
        static void printHello (string name)
        {
            Console.WriteLine($"Hello, {name}!");
           
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            printHello(name);
        }
    }
}
