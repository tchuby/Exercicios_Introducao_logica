using System;
using System.Globalization;

namespace MediaAluno
{
    public class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (nota1+nota2)/ 2;
            Console.WriteLine($"NOTA FINAL = " + media.ToString("F1",CultureInfo.InvariantCulture));
            if (media < 60)
            {
                Console.WriteLine("REPROVADO");
            }
            Console.ReadKey();
        }
    }
}
