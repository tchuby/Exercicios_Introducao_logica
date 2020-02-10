using System;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string[] entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            if (a % b == 0 || b % a == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");

            Console.ReadLine();
        }
    }
}
