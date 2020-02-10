using System;
using System.Globalization;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, per, area;

            string[] entrada = Console.ReadLine().Split(' ');

            a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (a < b + c && b < a + c && c < a + b)
            {
                per = a + b + c;
                Console.WriteLine("Perimetro = " + per.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
