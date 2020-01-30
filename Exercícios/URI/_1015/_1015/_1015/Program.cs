using System;
using System.Globalization;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada1 = Console.ReadLine().Split(' ');
            string[] entrada2 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(entrada1[0]);
            double y1 = double.Parse(entrada1[1]);
            double x2 = double.Parse(entrada2[0]);
            double y2 = double.Parse(entrada2[1]);
            double z = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            Console.WriteLine(z.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
