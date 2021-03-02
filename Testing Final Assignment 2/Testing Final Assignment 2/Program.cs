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
                foreach (char ch in input)
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
            else if (operation == "words")
            {
                return input.Split(' ').Length.ToString();
            }
            else if (operation == "isLowerCase")
            {
                bool isLowerCase = true;
                foreach (char ch in input)
                {
                    ascii = (int)ch;
                    if (ch == ' ')
                        continue;
                    if (ascii <= 97 || ascii >= 122)
                    {
                        isLowerCase = false;
                        break;
                    }
                }
                return isLowerCase ? "yes" : "no";
            }
            else if (operation == "isUpperCase")
            {
                bool isUpperCase = true;
                foreach (char ch in input)
                {
                    ascii = (int)ch;
                    if (ch == ' ')
                        continue;
                    if (ascii <= 65 || ascii >= 90)
                    {
                        isUpperCase = false;
                        break;
                    }
                }
                return isUpperCase ? "yes" : "no";
            }
            else if (operation == "isNumeric")
            {
                bool isNumeric = true;
                foreach (char ch in input)
                {
                    if (ch <= '0' || ch >= '9')
                    {
                        isNumeric = false;
                        break;
                    }
                }
                return isNumeric ? "yes" : "no";
            }
            else
                return "default";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Inverse
            string input = "Hello World";
            string output = input.StringExtension("inverse");
            Console.WriteLine("Inverse operation: Hello World => " + output);

            //Count number of words
            output = input.StringExtension("words");
            Console.WriteLine("Number of Words: Hello World => " + output);

            //isLowerCase
            output = input.StringExtension("isLowerCase");
            Console.WriteLine("IsLowerCase: Hello World => " + output);
            input = "hello world";
            output = input.StringExtension("isLowerCase");
            Console.WriteLine("IsLowerCase: hello world => " + output);

            //isUpperCase
            output = input.StringExtension("isUpperCase");
            Console.WriteLine("IsLowerCase: hello world => " + output);
            input = "HELLO WORLD";
            output = input.StringExtension("isUpperCase");
            Console.WriteLine("IsLowerCase: HELLO WORLD => " + output);

            //isNumeric
            input = "11";
            output = input.StringExtension("isNumeric");
            Console.WriteLine("IsNumeric: 11 => " + output);
            input = "hello world";
            output = input.StringExtension("isNumeric");
            Console.WriteLine("IsNumeric: hello world => " + output);

            //Read Key
            Console.ReadKey();
        }
    }
}
