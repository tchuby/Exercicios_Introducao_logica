using System;

namespace _1020
{
    class Program
    {
        public static void Main(string[] args)
        {
            int periodo = int.Parse(Console.ReadLine());
            int anos = periodo / 365;
            int restoAnos = periodo % 365;
            int meses = restoAnos / 30;
            int dias = restoAnos % 30;
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
            Console.ReadKey();
        }
    }
}
