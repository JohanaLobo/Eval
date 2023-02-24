using System;
using System.Text.RegularExpressions;

namespace ConsoleApp24
{
    class Program
    {
        public static void Main( string[] args)
        {
            var eval = new Evaluator();
            for( ; ; )
                {
                Console.Write("> ");
                string input = Console.ReadLine().Trim().ToLower ();
                if ( input == "exit" ) break;
                try {
                    string result = eval.Evaluate(input);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                } catch (Exception e) { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                }
                Console.ResetColor();
            }
        }
    }
}