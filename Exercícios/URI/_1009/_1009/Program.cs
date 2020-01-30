using System;
using System.Globalization;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salarioBase = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());
            double total = salarioBase + (vendas * 0.15);
            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
