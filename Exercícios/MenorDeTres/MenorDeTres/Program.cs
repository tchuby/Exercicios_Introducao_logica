using System;

namespace MenorDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler três números inteiros. 
            //Em seguida, mostrar qual o menor dentre os três números lidos. Em caso de empate, mostrar apenas uma vez.
            // Entrada 7 3 8; SaÍda MENOR = 3
            string[] vetor = Console.ReadLine().Split(' ');
            int a, b, c, y;
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);
            if (a < b && a < c)
            {
                y = a;
            }
            else if (b < c)
            {
                y = b;
            }
            else
                y = c;
            Console.WriteLine($"MENOR = {y}");
            Console.ReadKey();
        }
    }
}
