using System;
using System.Globalization;

namespace SaidaDeDados
{
    public class Program
    {
        static void Main(string[] args)
        {
            string a;
            int b;
            double c;
            char d;

            a = Console.ReadLine();
            b = int.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = char.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
