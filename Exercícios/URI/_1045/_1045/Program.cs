using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double a, b, c, x, y, z;
            a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            double[] ladosEntrada = { a, b, c};
            double[] ladosDecrescentes = ladosEntrada.OrderByDescending(l => l).ToArray();
            x = ladosDecrescentes[0];
            y = ladosDecrescentes[1];
            z = ladosDecrescentes[2];

            List<string> saida = new List<string>();

            if (x >= y + z)
                saida.Add("NAO FORMA TRIANGULO");
            else
            {
                if (Math.Pow(x, 2) == Math.Pow(y, 2) + Math.Pow(z, 2))
                    saida.Add("TRIANGULO RETANGULO");
                if (Math.Pow(x, 2) > Math.Pow(y, 2) + Math.Pow(z, 2))
                    saida.Add("TRIANGULO OBTUSANGULO");
                if (Math.Pow(x, 2) < Math.Pow(y, 2) + Math.Pow(z, 2))
                    saida.Add("TRIANGULO ACUTANGULO");
                if (x == y && y == z)
                    saida.Add("TRIANGULO EQUILATERO");
                if (x == y && y != z)
                    saida.Add("TRIANGULO ISOSCELES");
                if (x != y && y == z)
                    saida.Add("TRIANGULO ISOSCELES");
            }

            int n = saida.Count();
            if (n == 1)
                Console.WriteLine(saida[0]);
            else
            {
                Console.WriteLine(saida[0]);
                Console.WriteLine(saida[1]);
            }
            Console.ReadLine();
         }
    }
}
