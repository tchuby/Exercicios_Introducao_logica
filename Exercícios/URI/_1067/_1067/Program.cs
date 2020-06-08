using System;

namespace _1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
