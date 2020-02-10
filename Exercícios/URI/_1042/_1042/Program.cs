using System;
using System.Collections.Generic;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string[] entrada = Console.ReadLine().Split(' ');
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            c = int.Parse(entrada[2]);
            Console.Clear();

            List<int> numeros = new List<int>();
            numeros.Add(a);
            numeros.Add(b);
            numeros.Add(c);

            numeros.Sort();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n" + a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
