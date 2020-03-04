using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, hora, min, instInicial, instFinal, duracao;
            string[] entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            c = int.Parse(entrada[2]);
            d = int.Parse(entrada[3]);

            instInicial = 60 * a + b;
            instFinal = 60 * c + d;

            if (instInicial >= instFinal)
                duracao = 24 * 60 + instFinal - instInicial;
            else
                duracao = instFinal - instInicial;

            hora = duracao / 60;
            min = duracao % 60;

            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hora, min);
            Console.ReadKey();
        }
    }
}
