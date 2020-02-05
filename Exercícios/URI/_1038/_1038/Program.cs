using System;
using System.Globalization;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int codigo = int.Parse(entrada[0]);
            int quantidade = int.Parse(entrada[1]);
            double valor;
            switch (codigo) 
            {
                case 1:
                    valor = 4.00 * quantidade;
                    break;
                case 2:
                    valor = 4.50 * quantidade;
                    break;
                case 3:
                    valor = 5.00 * quantidade;
                    break;
                case 4:
                    valor = 2.00 * quantidade;
                    break;
                case 5:
                    valor = 1.50 * quantidade;
                    break;
                default:
                    valor = 0;
                    break;
            } 
            Console.WriteLine($"Total: R$ {valor.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
