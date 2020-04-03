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
             que não entrará nos cálculos, contém um valor de idade negativa.
             Calcular e imprimir a idade média deste grupo de indivíduos. Se 
             for entrado um valor negativo na primeira vez, mostra a mensagem
             "impossivel calcular".
             */
            int repeticoes = 0;
            double somaIdades = 0.0;
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (x < 0)
                Console.WriteLine("impossivel calcular");
            else
            {
                while (x >= 0)
                {
                    somaIdades = somaIdades + x;
                    repeticoes++;
                    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                double media = somaIdades / repeticoes;
                Console.WriteLine(media.ToString("F2"));
            }
            Console.ReadKey();
        }
    }
}