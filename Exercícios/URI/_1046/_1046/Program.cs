using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);
            int saldo;
            if (a >= b){
                saldo = (b - a) + 24;
            }
            else {
                saldo = b - a;
            }
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", saldo);
            Console.ReadKey();
        }
    }
}
