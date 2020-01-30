
using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideBase = double.Parse(Console.ReadLine());
            double sideHigh= double.Parse(Console.ReadLine());
            double area = sideBase * sideHigh;
            double perimeter = 2 * sideBase + 2 * sideHigh;
            double diagonal = Math.Sqrt(Math.Pow(sideHigh, 2) + Math.Pow(sideBase, 2));
            Console.WriteLine($"AREA = {area.ToString("F4", CultureInfo.InvariantCulture)}" +
                $"\r\nPERIMETRO = {perimeter.ToString("F4", CultureInfo.InvariantCulture)}" +
                $"\r\nDIAGONAL = {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
