using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Final_Assignment_2
{
    public static class ExtensionMethods
    {
        public static string StringExtension(this string input, string operation)
        {
            if (operation == "inverse")
                return "string inversed";
            else
                return "default";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
