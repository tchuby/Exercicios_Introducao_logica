using System;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            while (entrada != "2002")
            {
                Console.WriteLine("Senha Invalida");
                entrada = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}