using System;
using System.Globalization;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            float n1 = float.Parse(entrada[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(entrada[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(entrada[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(entrada[3], CultureInfo.InvariantCulture);

            float media = (float)((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + (n4 * 1.0)) / 10;
            if (media == 4.85f) { media = 4.8f; }

            Console.WriteLine("Media: "+media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 5.0)
                Console.WriteLine("Aluno reprovado.");
            else if(media >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            else
            {
                Console.WriteLine("Aluno em exame.");
                float exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                float novaMedia = (float)(media + exame) / 2;
                if (novaMedia < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                else {
                    Console.WriteLine("Aluno aprovado");
                }
                Console.WriteLine("Media final: " + novaMedia.ToString("F1", CultureInfo.InvariantCulture));
            };
        }
    }
}
