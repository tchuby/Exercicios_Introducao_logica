using System;

namespace curso 
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            if (h < 12)
            {
                Console.WriteLine("Bom Dia");
            }
            else if (h < 18)
            {
                Console.WriteLine("Boa Tarde");
            }
            else
            {
                Console.WriteLine("Boa Noite");
            }
            Console.ReadKey();
        }
    }
}
