using System;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int seg1dia = 24 * 60 * 60;
            int seg1hora = 60 * 60;
            int seg1minuto = 60;
            string[] _1linha = Console.ReadLine().Split(' ');
            string[] _2linha = Console.ReadLine().Split(':');
            string[] _3linha = Console.ReadLine().Split(' ');
            string[] _4linha = Console.ReadLine().Split(':');
            int diasEmSeg = (int.Parse    (_3linha[1]) - int.Parse(_1linha[1])) * seg1dia;
            int horasEmSeg = (int.Parse   (_4linha[0]) - int.Parse(_2linha[0])) * seg1hora;
            int minutosEmSeg = (int.Parse (_4linha[1]) - int.Parse(_2linha[1])) * seg1minuto;
            int segundosEmSeg = int.Parse (_4linha[2]) - int.Parse(_2linha[2]);
            int totalSeg = diasEmSeg + horasEmSeg + minutosEmSeg + segundosEmSeg;
            int dias = totalSeg / seg1dia;
            int diasResto = totalSeg % seg1dia;
            int horas = diasResto / seg1hora;
            int horasResto = diasResto % seg1hora;
            int minutos = horasResto / seg1minuto;
            int minutosResto = horasResto % seg1minuto;
            int segundos = minutosResto;
            Console.WriteLine($"{dias} dia(s)");
            Console.WriteLine($"{horas} hora(s)");
            Console.WriteLine($"{minutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");
            Console.ReadKey();
        }
    }
}
