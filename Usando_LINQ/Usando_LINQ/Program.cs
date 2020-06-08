using System;
using System.Collections.Generic;
using System.Linq;

namespace Usando_LINQ
{
    public class Program
    {
        /// <summary>
        /// CriaDados - cria uma coleção de furtas<Fruta>
        /// </summary>
        /// <returns></returns>
        static IList<Fruta> CriaDados()
        {
            return new List<Fruta>()
            {
                new Fruta("Apple","green",7),
                new Fruta("Orange","orange",10),
                new Fruta("Grape","green",4),
                new Fruta("Fig","brown",12),
                new Fruta("Plum","red",2),
                new Fruta("Banana","yellow",10),
                new Fruta("Strowberry","red",7),
                new Fruta("Watermelon", "green",3)
            };
        }
        static void Main(string[] args)
        {
            //Cria os dados
            IList<Fruta> fonteDados = CriaDados();
            //Filtra baseado em uma única característica
            IEnumerable<string> resultado1 = from f in fonteDados where f.Color == "red" select f.Name;

            Console.WriteLine("\nFilter by color - red");
            foreach (string str in resultado1) {
                Console.WriteLine("Fruit {0}", str);
            }

            //Filtra usando um operador lógico
            IEnumerable<Fruta> resultado2 = from f in fonteDados where f.Price > 5 select f;
            Console.WriteLine("\nFilter by price > 5");
            foreach (Fruta f in resultado2){
                Console.WriteLine("Fruta {0}",f.Name);
            }

            //Filtra por duas características
            IEnumerable<string> resultado3 = from f in fonteDados where f.Color == "red" && f.Price < 10 select f.Name;
            Console.WriteLine("\nFilter by color red and price < 10");
            foreach (string str in resultado3) {
                Console.WriteLine("Fruta {0}", str);
            }
            Selecao();
            Console.WriteLine("\nMalfeito feito!");
            Console.ReadKey();
        }

        public static void Selecao()
        {
            string[] fruits = { "apple","banana","mango","orange", "passionfruit", "grape"};
            var query = fruits.Select((fruit, index) => new { index, str = fruit.Substring(0, index)});
            foreach (var obj in query)
            {
                Console.WriteLine("\n{0}", obj);
            }

             /*
             This code produces the following output:
             {index=0, str=}
             {index=1, str=b}
             {index=2, str=ma}
             {index=3, str=ora}
             {index=4, str=pass}
             {index=5, str=grape}
             */
        }
    }
}
