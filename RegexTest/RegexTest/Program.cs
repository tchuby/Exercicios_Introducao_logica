using System;
using System.Text.RegularExpressions;

namespace RegexTest
{
    class Program 
    {
        static void Main(string[] args)
        {
            //string data = Console.ReadLine();
            string nome = Console.ReadLine();
            //string saidaData = ValidateData(data) ? "Data aceita." : "Data não aceita.";
            string saidaNome = ValidaNome(nome) ? "Nome aceito." : "Nome inválido.";
            //Console.WriteLine(saidaData);
            Console.WriteLine(saidaNome);
            Console.ReadKey();
        }

        public static bool ValidateData(string data)
        {
            data.Replace("/", "");
            Regex rgx = new Regex(@"(\d{2}\d{2}\d{4})");
            return rgx.IsMatch(data);
        }
        public static bool ValidaNome(string nome)
                {
            //Essa Regex não está funcionando corretamente.
            //Regex rgx = new Regex(@"^(?:[\p{ Lu } &&[\p{ IsLatin}]])(?: (?: ')?(?:[\p{Ll}&&[\p{IsLatin}]]))+(?:\-(?:[\p{Lu}&&[\p{IsLatin}]])(?:(?:') ? (?:[\p{ Ll}&&[\p{ IsLatin}]]))+)*(?: (?: (?: e | y | de(?:(?: la | las | lo | los)) ?|do| dos | da | das | del | van | von | bin | le) )?(?: (?: (?: d'|D' | O'|Mc|Mac|al\-))?(?:[\p{Lu}&&[\p{IsLatin}]])(?:(?:')?(?:[\p{ Ll}&&[\p{ IsLatin}]]))+| (?:[\p{ Lu}&&[\p{ IsLatin}]])(?: (?: ')?(?:[\p{Ll}&&[\p{IsLatin}]]))+(?:\-(?:[\p{Lu}&&[\p{IsLatin}]])(?:(?:') ? (?:[\p{ Ll}&&[\p{ IsLatin}]]))+)*))+(?: (?: Jr\.| II | III | IV))?$");
            //Regex rgx = new Regex(@"[^A-ZÀ-Úa-zà-ú ]");
            Regex rgx = new Regex(@"(([A - ZÀ - Ÿ][A - zÀ - ÿ']+[A-zÀ-ÿ']) 
            * ([A - ZÀ - Ÿ][A - zÀ - ÿ']+[A-zÀ-ÿ']) *) | (([A - ZÀ - Ÿ][A - zÀ - ÿ']+[A-zÀ-ÿ']) 
            * [a - zA - Z][a - zA - Z] * ([A - ZÀ - Ÿ][A - zÀ - ÿ']+[A-zÀ-ÿ']) *)");
            return rgx.IsMatch(nome);
        }
    }
}
