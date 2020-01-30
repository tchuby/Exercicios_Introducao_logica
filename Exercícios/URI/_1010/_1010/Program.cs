using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            int a = int.Parse(linha1[0]);
            int b = int.Parse(linha1[1]);
            double c = double.Parse(linha1[2]);
            string[] linha2 = Console.ReadLine().Split(' ');
            int d = int.Parse(linha2[0]);
            int e = int.Parse(linha2[1]);
            double f = double.Parse(linha2[2]);
            double saida = b * c + e * f;
            Console.WriteLine("VALOR A PAGAR: R$ "+saida.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
