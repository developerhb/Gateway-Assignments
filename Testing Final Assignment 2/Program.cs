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
            string output = "";
            int ascii;
            if (operation == "inverse")
            {
                foreach(char ch in input)
                {
                    ascii = (int)ch;
                    if (ascii >= 65 && ascii <= 90)
                        ascii += 32;
                    else if (ascii >= 97 && ascii <= 122)
                        ascii -= 32;
                    output += (char)ascii;
                }
                return output;
            }
            else if(operation == "words")
            {
                return input.Split(' ').Length.ToString();
            }
            else if(operation == "isLowerCase")
            {
                bool isLowerCase = true;
                foreach(char ch in input)
                {
                    ascii = (int)ch;
                    if (ch == ' ')
                        continue;
                    if(ascii <= 97 && ascii >= 122)
                    {
                        isLowerCase = false;
                        break;
                    }
                }
                return isLowerCase ? "yes" : "no";
            }
            else
                return "default";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string output = input.StringExtension("inverse");
            Console.WriteLine("Inverse operation: Hello World => " + output);
            output = input.StringExtension("words");
            Console.WriteLine("Number of Words: Hello World => " + output);
            output = input.StringExtension("isLowerCase");
            Console.WriteLine("IsLowerCase: Hello World => " + output);
            input = "hello world";
            output = input.StringExtension("isLowerCase");
            Console.WriteLine("IsLowerCase: hello world => " + output);
            Console.ReadKey();
        }
    }
}
