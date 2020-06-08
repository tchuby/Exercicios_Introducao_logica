using System;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= n; i++) 
            {
                long x = long.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                    dentro++;
                else
                    fora++;
            }
            Console.WriteLine("{0} in",dentro);
            Console.WriteLine("{0} out", fora);
        }
    }
}
