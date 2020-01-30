using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());
            double distancia = tempo * velocidade;
            double combustivel = distancia / 12;
            Console.WriteLine(combustivel.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
