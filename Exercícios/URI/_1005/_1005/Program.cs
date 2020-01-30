using System;
using System.Globalization;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double MEDIA, N1, N2;
            N1 = double.Parse(Console.ReadLine());
            N2 = double.Parse(Console.ReadLine());
            MEDIA = ((N1 * 3.5) + (N2 * 7.5)) / 11;
            Console.WriteLine($"MEDIA = {MEDIA.ToString("N5", CultureInfo.InvariantCulture)}");
        }
    }
}
