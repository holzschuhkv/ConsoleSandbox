using TestApplicationConsole.Basics;
//using Ausgabe = System.Console;
using System;

namespace TestApplicationConsole
{
    class Program
    {
        private static string result;
        private static string inputKeys = "test(asdf){asdf}sdfa(as{didu})";
        static void Main(string[] args)
        {
            Circle test = new Circle();

            

            Console.ReadKey();
        }

        private static void InternKeys()
        {
            foreach (char ch in Program.inputKeys)
            {
                if (ch == '(')
                {
                    result += "(";
                    inputKeys = inputKeys.Substring(1);
                    continue;
                }
                else if (ch == ')')
                {
                    result += ")";
                    inputKeys = inputKeys.Substring(1);
                    continue;
                }
                else if (ch == '{')
                {
                    result += "{";
                    inputKeys = inputKeys.Substring(inputKeys.IndexOf('}'));
                    continue;
                }
                else if (ch == '}')
                {
                    result += "}";
                    inputKeys = inputKeys.Substring(1);
                    continue;
                }
                result += ch;
                inputKeys = inputKeys.Substring(1); //add
            }
        }

        private static string Parser(string input)
        {
            if(input.StartsWith("("))
            {
                result += "(";
                input = input.Substring(1);
                return input;
            }
            else if(input.StartsWith("{"))
            {
                result += "{";
                input = input.Substring(input.IndexOf('}'));
                return input;
            }
            return input;
        }
    }
}