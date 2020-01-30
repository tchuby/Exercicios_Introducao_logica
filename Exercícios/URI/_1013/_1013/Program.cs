using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] e = Console.ReadLine().Split(' ');
            double a = double.Parse(e[0]);
            double b = double.Parse(e[1]);
            double c = double.Parse(e[2]);
            double x = (a + b + Math.Abs(a-b))/2;
            double y = (x + c + Math.Abs(x-c))/2;
            if (y == a)
                Console.WriteLine($"{a} eh o maior");
            if (y == b)
                Console.WriteLine($"{b} eh o maior");
            if (y==c)
                Console.WriteLine($"{c} eh o maior");
        }
    }
}
