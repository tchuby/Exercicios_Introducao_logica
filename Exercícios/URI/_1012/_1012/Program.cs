using System;
using System.Globalization;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double A = double.Parse(entrada[0]);
            double B = double.Parse(entrada[1]);
            double C = double.Parse(entrada[2]);
            double sT = A * C / 2;
            double sC = Math.Pow(C, 2) * 3.14159;
            double sTra = (A + B) / 2 * C;
            double sQ = Math.Pow(B, 2);
            double sR = A * B;
            Console.WriteLine("TRIANGULO: "+sT.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+sC.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+sTra.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+sQ.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+sR.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
