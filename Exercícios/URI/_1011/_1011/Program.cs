using System;
using System.Globalization;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double s = (4.0 / 3.0) * 3.14159 * Math.Pow(r, 3);
            Console.WriteLine("VOLUME = "+s.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
