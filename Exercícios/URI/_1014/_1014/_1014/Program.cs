using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double s = a / b;
            Console.WriteLine(s.ToString("F3",CultureInfo.InvariantCulture)+" km/l");
        }
    }
}
