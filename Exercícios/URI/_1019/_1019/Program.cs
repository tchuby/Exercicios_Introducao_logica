using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundosTotais = int.Parse(Console.ReadLine());
            int horas = segundosTotais / 3600;
            int restoHoras = segundosTotais % 3600;
            int minutos = restoHoras / 60;
            int restoMinutos = restoHoras % 60;
            int segundos = restoMinutos;
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
