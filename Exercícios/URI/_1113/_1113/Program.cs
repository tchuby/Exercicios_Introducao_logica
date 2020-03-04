using System;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            while(x != y)
            {
                if (x > y)
                    Console.WriteLine("Decrescente");
                else
                    Console.WriteLine("Crescente");
                entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
        }
    }
}
