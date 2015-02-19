using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_HTMLDispatcher
{
    class ElementBuilder
    {
        //props
        private string content;

        // More info https://msdn.microsoft.com/en-us/library/dd387181%28v=vs.110%29.aspx
        private List<Tuple<string, string>> attributes = new List<Tuple<string, string>>();
        private string tagName;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string TagName
        {
            get { return tagName; }
            set { tagName = value; }
        }

        //constructors
        public ElementBuilder(string tagName)
        {
            try
            {
                if (string.IsNullOrEmpty(tagName))
                {
                    throw new ArgumentNullException("The tag is empty");
                }
                else
                {
                    this.TagName = tagName;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        //metods
        public void AddAttribute(string attribute, string value)
        {
            try
            {
                if (string.IsNullOrEmpty(attribute))
                {
                    throw new ArgumentNullException("Attribute name cannot be empty!");
                }
                else
                {
                    this.attributes.Add(new Tuple<string,string>(attribute,value));
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddContent(string content)
        {
            try
            {
                if (string.IsNullOrEmpty(content))
                {
                    throw new ArgumentNullException("Attribute name cannot be empty!");
                }
                else
                {
                    this.Content = content;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string operator *(ElementBuilder element, int n)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(element.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            var allAttr = new StringBuilder();

            foreach (var attr in attributes)
            {
                allAttr.AppendFormat(" {0}=\"{1}\"",attr.Item1, attr.Item2);
            }

            return string.Format("<{0}{1}>{2}</{0}>",this.TagName,allAttr.ToString(),this.Content);
        }
    }
}
