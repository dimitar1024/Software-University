using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_HTMLDispatcher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string src, string alt, string title)
        {
            var image = new ElementBuilder("img");
            image.AddAttribute("src", src);
            image.AddAttribute("alt", alt);
            image.AddAttribute("title", title);
            return image.ToString();
        }

        public static string CreateURL(string url, string text, string title) 
        {
            var a = new ElementBuilder("a");
            a.AddAttribute("href", url);
            a.AddAttribute("title", title);
            a.AddContent(text);
            return a.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            var input = new ElementBuilder("input");
            input.AddAttribute("type", type);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);
            return input.ToString();
        } 
    }
}
