using System;
using System.Globalization;

namespace MediaDeIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada1 = Console.ReadLine().Split(' ');
            string[] entrada2 = Console.ReadLine().Split(' ');
            int _1 = int.Parse(entrada1[1]);
            int _2 = int.Parse(entrada2[1]);
            double media = (double)(_1 + _2) / 2; //uso do casting para forçar a leitura como um double, pois quando há operações só com números inteiros a IDE compreende que o resultado será um número inteiro.
            Console.WriteLine($"A idade média de {entrada1[0]} e {entrada2[0]} é de {media.ToString("F1",CultureInfo.InvariantCulture)} anos");
            Console.ReadKey();
        }
    }
}
