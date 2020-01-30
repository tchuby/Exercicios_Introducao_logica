using System;
using System.Globalization;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string saida;

            if (0 <= entrada && entrada <= 25.00)
                saida = "Intervalo [0,25]";
            else if (25.00 < entrada && entrada <= 50.00)
                saida = "Intervalo (25,50]";
            else if (50.00 < entrada && entrada <= 75.00)
                saida = "Intervalo (50,75]";
            else if (75.00 < entrada && entrada <= 100.00)
                saida = "Intervalo (75,100]";
            else
                saida = "Fora de intervalo";
            Console.WriteLine(saida);
        }
    }
}
