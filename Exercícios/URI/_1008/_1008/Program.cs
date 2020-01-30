using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            double N3 = double.Parse(Console.ReadLine());
            double salary =N2*N3; 
            Console.WriteLine($"NUMBER = {N1}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
