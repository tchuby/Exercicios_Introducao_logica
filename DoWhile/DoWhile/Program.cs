using System;
using System.Globalization;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char resposta;
            do{
                Console.WriteLine("Digite a temperatura em Celsius:");
                double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double f = (9*c/5)+32;

                Console.WriteLine("Equivalente em Fahrenheit: "+ f.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)?");
                resposta = char.Parse(Console.ReadLine());

            } while(resposta =='s');

            Console.ReadKey();
        }
    }
} 
