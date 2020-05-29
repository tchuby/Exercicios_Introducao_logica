using System;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for ( int x = 1; x <= 10; x++) {
                int mult = x * n;
                Console.WriteLine("{0} x {1} = {2}", x, n, mult);
            }
        }
    }
}