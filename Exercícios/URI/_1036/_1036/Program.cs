using System;
using System.Globalization;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double a = double.Parse(entrada[0],CultureInfo.InvariantCulture);
            double b = double.Parse(entrada[1],CultureInfo.InvariantCulture);
            double c = double.Parse(entrada[2],CultureInfo.InvariantCulture);
            double delta = Math.Pow(b, 2.0) - (4.0 * a * c);
            if (delta < 0 || a==0)
                Console.WriteLine("Impossivel calcular");
            else
            {
                double r1 = (-b + Math.Sqrt(delta)) / (2.0 * a); 
                double r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = "+r1.ToString("F5"));
                Console.WriteLine("R2 = "+r2.ToString("F5"));
            }
            Console.ReadKey();
        }
    }
}
