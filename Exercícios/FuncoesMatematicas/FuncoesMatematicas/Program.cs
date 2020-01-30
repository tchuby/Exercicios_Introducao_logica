using System;

namespace FuncoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            Console.WriteLine("Digite a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite c");
            double c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(b,2.0)-4*a*c;

            x1 = (-b + Math.Sqrt(delta)) / 2.0 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2.0 * a;
            Console.Clear();
            Console.WriteLine($"Os possíveis valores de x são: {x1} e {x2}");
            Console.ReadKey();

        }
    }
}
