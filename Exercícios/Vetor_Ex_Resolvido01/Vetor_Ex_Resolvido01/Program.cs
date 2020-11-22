using System;

namespace Vetor_Ex_Resolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            //imprimir na tela apenas os números negativos escritos na linha

            string[] s = Console.ReadLine().Split(' ');
            int n = s.Length;
            int[] vet = new int[n];

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int j = 0; j < vet.Length; j++) 
            {
                if(vet[j] < 0)
                    Console.WriteLine(vet[j]);
            }

            Console.ReadKey();
        }
    }
}
