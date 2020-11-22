using System;

namespace Vetor_Ex_Resolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 'n' números reais separados por espaço.");

            string[] vet = Console.ReadLine().Split(' ');
            float[] numberColection = new float[vet.Length];
            for(int i = 0; i < vet.Length; i++)
            {
                numberColection[i] = float.Parse(vet[i]);
            }
        }
    }
}
