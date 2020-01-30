using System;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int notas100 = valor / 100;
            int troco100 = valor % 100;
            int notas50 = troco100 / 50;
            int troco50 = troco100 % 50;
            int notas20 = troco50 / 20;
            int troco20 = troco50 % 20;
            int notas10 = troco20 / 10;
            int troco10 = troco20 % 10;
            int notas5 = troco10 / 5;
            int troco5 = troco10 % 5;
            int notas2 = troco5 / 2;
            int troco2 = troco5 % 2;
            int notas1 = troco2;
            Console.WriteLine(valor);
            Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{notas1} nota(s) de R$ 1,00");
        }
    }
}
