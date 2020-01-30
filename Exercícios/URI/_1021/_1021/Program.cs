using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double montante = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota100 = montante / 100;
            double resto100 = montante % 100;
            double nota50 = resto100 / 50;
            double resto50 = resto100 % 50;
            double nota20 = resto50 / 20;
            double resto20 = resto50 % 20;
            double nota10 = resto20 / 10;
            double resto10 = resto20 % 10;
            double nota5 = resto10 / 5;
            double resto5 = resto10 % 5;
            double nota2 = resto5 / 2;
            double resto2 = resto5 % 2;
            double moeda1r;
            double resto1;
            if (resto2 >= 1)
            {
                moeda1r = 1;
                resto1 = resto2 - 1;
            }
            else
            {
                moeda1r = 0;
                resto1 = resto2;
            }
            double moeda50 = (resto1*100) / 50;
            double troco50 = (resto1*100) % 50;
            double moeda25 = troco50 / 25;
            double troco25 = troco50 % 25;
            double moeda10 = troco25 / 10;
            double troco10 = troco25 % 10;
            double moeda5 = troco10 / 5;
            double troco5 = troco10 % 5;
            double moeda1c = troco5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(@"{0:0} nota(s) de R$ 100.00", Math.Floor(nota100));
            Console.WriteLine(@"{0:0} nota(s) de R$ 50.00", Math.Floor(nota50));
            Console.WriteLine(@"{0:0} nota(s) de R$ 20.00", Math.Floor(nota20));
            Console.WriteLine(@"{0:0} nota(s) de R$ 10.00", Math.Floor(nota10));
            Console.WriteLine(@"{0:0} nota(s) de R$ 5.00", Math.Floor(nota5));
            Console.WriteLine(@"{0:0} nota(s) de R$ 2.00", Math.Floor(nota2));
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(@"{0:0} moeda(s) de R$ 1.00", Math.Floor(moeda1r));
            Console.WriteLine(@"{0:0} moeda(s) de R$ 0.50", Math.Floor(moeda50));
            Console.WriteLine(@"{0:0} moeda(s) de R$ 0.25", Math.Floor(moeda25));
            Console.WriteLine(@"{0:0} moeda(s) de R$ 0.10", Math.Floor(moeda10));
            Console.WriteLine(@"{0:0} moeda(s) de R$ 0.05", Math.Floor(moeda5));
            Console.WriteLine(@"{0:0} moeda(s) de R$ 0.01", Math.Floor(moeda1c));
            Console.ReadKey();
        }
    }
}
