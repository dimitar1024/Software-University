using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    public static class AllClasses
    {
        private static List<Class> classes = new List<Class>();

        public static void AddClass(Class clas)
        {
            classes.Add(clas);
        }

        public static void RemoveClass(Class clas)
        {
            classes.Remove(clas);
        }

        public static string ToString()
        {
            var allClasses = new StringBuilder();

            foreach (var clas in classes)
            {
                allClasses.AppendFormat(clas.ID + "\n");
            }

            return allClasses.ToString();
        }
    }
}
