using System;

namespace TrabalhandoEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroEnum.Carros valor;
            valor = CarroEnum.Carros.Fusca;
            Console.WriteLine((int) valor);
            Console.ReadKey();
        }
    }
}
