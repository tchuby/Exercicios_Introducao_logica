using System;
using System.Globalization;

namespace PraticeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa para ler uma número indeterminado de dados,
             contendo cada um, a idade de um indivíduo.O último dado, que 
             que nãoe entrará nos cálculos, contém um valor de idade nefativa.
             Calcular e imprimir a idade média deste gripo de indivíduos. Se 
             for entrado um valor negativo na primeira ves, mostra a mensagem
             "impossivel calcular".
             */

            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (x < 0)
                Console.WriteLine("impossivel calcular");
            else
            {
                while (x > 0)
                { 
                }
            }
            Console.ReadKey();
        }
    }
}
