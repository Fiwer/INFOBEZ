using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Wis
{
    class Program
    {

        public static void Main(string[] args)
        {
            //Частота букв
            string text = "ЕСТЬ=ТАКАЯ=УДИВИТЕЛЬНАЯ=КАТЕГОРИЯ=ЛЮДЕЙ=КОТОРЫЕ=ДУМАЮТ=ЧТО=МОЖНО=КОГОТО=ПРЕДАТЬ=ЗАТЕМ=ПНДОЖДАТЬ=НЕКОТОРОЕ=ВРЕМЯ=И=СНОВА=ПОПЫТАТЬСЯ=ВОЗОБНОВИТЬ=ОБЩЕНИЕ=КАК=НИ=В=ЧЁМ=НЕАРЫВАЛО=ПОРАЗИТЕЛЬНЫЕ=ЛЮДИ";
            string textWithoutSpaces = Regex.Replace(text, @"[^\w\d]", "");

            var counted = textWithoutSpaces
                .GroupBy(c => c)
                .Select(g => new { g.Key, Count = g.Count() })
                .OrderByDescending(o => o.Count);

            foreach (var res in counted)
            {
                Console.WriteLine("{2}", res.Key, res.Count, (100.0 / textWithoutSpaces.Length * res.Count) / 100);
            }

            ////Расшифровка Виженера
            //char[] alphabet = new char[] { '=', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            //char[] message = "ЙМ=ЖАЧЬШЛ=ДОСФГННТЧЭТЬЛКЛЕНТОПХДЛКМВ=ТХАПЙ=ЪС=АМПФСЬКЮАЬНЬКНУВЫЪАПЙРЪУУЫЭЬЁИЬ=ЖАМЬ=РНДКЫППЛ=НЮЭДИТЦПЧЙЮЪЁДЮЮРНГЫЦКТТЙПЛАФЙЭЁУЕНИЭ=ДЮЬУПЁИЬНЙЧЧМЪВЮАЫФЁДЁНЦАТДМНАЬБЪКОЙЬЮЁГЕЖЬКРУЛНУЙЧАЩЖО=АМЧЯИД".ToCharArray();
            //string result = "";

            //char[] key = "ДЫМКА".ToCharArray();

            //int keyword_index = 0;

            //foreach (char symbol in message)
            //{
            //    int p = (Array.IndexOf(alphabet, symbol) + alphabet.Length - Array.IndexOf(alphabet, key[keyword_index])) % alphabet.Length;

            //    result += alphabet[p];

            //    keyword_index++;

            //    if ((keyword_index) == key.Length)
            //        keyword_index = 0;
            //}

            //Console.WriteLine(result);

        }
    }
}
