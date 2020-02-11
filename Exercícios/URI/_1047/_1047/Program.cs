using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, hora, min;
            string[] entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            c = int.Parse(entrada[2]);
            d = int.Parse(entrada[3]);
            
            if(a <= c && b > d)

            Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {min} MINUTO(S)");
            Console.ReadKey();
        }
    }
}
