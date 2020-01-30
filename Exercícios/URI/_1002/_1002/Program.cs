using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            string A = (3.14159 * (Math.Pow(raio, 2))).ToString("F4",CultureInfo.InvariantCulture);
            Console.WriteLine($"A={A}");
            Console.ReadKey();
        }
    }
}
