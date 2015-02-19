using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_StringBuilderExtensions
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            return new StringBuilder(str.ToString(index, length));
        }

        public static StringBuilder RemoveText(this StringBuilder str, string text)
        {
            return str.Replace(text, string.Empty);
        }

        public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> items)
        {
            return str.Append(string.Join(string.Empty, items));
        }
    }
}
