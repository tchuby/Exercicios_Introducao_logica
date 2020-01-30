using System;
using System.Globalization;

namespace LeituraDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int b;
            double c;
            char d;

            /*
            Console.WriteLine("Digite um nome:");
            a = Console.ReadLine();
            Console.WriteLine("Digite idade em numeral:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite altura em numeral:");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite Y ou N:");
            d = char.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.ReadKey();
            
            Console.WriteLine("Digite Nome, Idade, altura  e Y ou N:");
            string[] vet = Console.ReadLine().Split(' ');

            a = vet[0];
            b = int.Parse(vet[1]);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            d = char.Parse(vet[3]);

            Console.Clear();
            Console.WriteLine($"{a} tem {b} anos de idade, {c}m de altura e {d}.");
            Console.ReadKey();
            */

            Console.WriteLine("String,Int,Double,Char.");
            string[] vet = Console.ReadLine().Split(',');

            a = vet[0];
            b = int.Parse(vet[1]);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            d = char.Parse(vet[3]);

            Console.Clear();
            Console.WriteLine($"String {a}, Int {b}, Double {c}, Char {d}.");
            Console.ReadKey();
        }
    }
}
