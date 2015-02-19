using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_CustomLINQExtensionMethods
{
    class TestLINQExtensions
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            Console.WriteLine(string.Join(" - ", numbers.WhereNot<int>(x => x % 2 == 0)));
            Console.WriteLine(string.Join(" - ", numbers.Repeat<int>(10)));
            IEnumerable<string> words = new List<string>() { "Lorem","Ipsum","е","елементарен","примерен","текст","използван","в",
                "печатарската","и","типографската","индустрия","Lorem","Ipsum","е","индустриален","стандарт","от","около","1500",
                "година","когато","неизвестен","печатар","взема","няколко","печатарски","букви","и","ги","разбърква","за","да",
                "напечата","с","тях","книга","с","примерни","шрифтове","Този","начин","не","само","е","оцелял","повече","от","5",
                "века","но","е","навлязъл","и","в","публикуването","на","електронни","издания","като","е","запазен","почти","без",
                "промяна","Популяризиран","е","през","60те","години","на","20ти","век","със","издаването","на","Letraset","листи",
                "съдържащи","Lorem","Ipsum","пасажи","популярен","е","и","в","наши","дни","във","софтуер","за","печатни","издания",
                "като","Aldus","PageMaker","който","включва","различни","версии","на","Lorem","Ipsum"};
            IEnumerable<string> suffixes = new List<string>() { "ти", "ен" };
            Console.WriteLine(string.Join(", ", words.WhereEndsWith(suffixes)));

            
        }
    }
}
