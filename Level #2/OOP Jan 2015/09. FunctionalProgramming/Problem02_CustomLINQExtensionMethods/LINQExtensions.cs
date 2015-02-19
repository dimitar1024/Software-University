using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_CustomLINQExtensionMethods
{
    public static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(x => !predicate(x));
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var list = collection.ToList();
            for (int i = 0; i < count - 1; i++)
            {
                list.AddRange(collection);
            }

            return list as IEnumerable<T>;
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection,
            IEnumerable<string> suffixes)
        {
            List<string> output = new List<string>();

            foreach (var word in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (word.EndsWith(suffix))
                    {
                        output.Add(word);
                    }
                }
            }

            return output as IEnumerable<string>;
        }

    }
}
