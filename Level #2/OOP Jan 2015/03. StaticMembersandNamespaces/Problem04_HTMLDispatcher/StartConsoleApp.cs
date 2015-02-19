using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_HTMLDispatcher
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            
            Console.WriteLine(div * 2);

            Console.WriteLine(new string('=',80));

            
            string image = HTMLDispatcher.CreateImage("softuni.bg/imgs/media/logo", "Software University", "Software University");
            string url = HTMLDispatcher.CreateURL("softuni.bg", "Software University", "Software University");
            string input = HTMLDispatcher.CreateInput("text", "softuni", "softuni");
            ElementBuilder article = new ElementBuilder("div");
            article.AddAttribute("class", "news");
            article.AddContent(string.Format("{0}{1}{2}",image,url,input));

            Console.WriteLine(article);

        }
    }
}
