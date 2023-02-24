using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class EvalException : Exception
    {
        public EvalException(string message) : base (message) { }
    }
    class Evaluator
    {
        public string Evaluate (string input)
        {
           var tokenizer = new Tokenizer(input);
            for( ; ; ) {
                var token = tokenizer.GetNext();
                if ( token is TEnd ) break;
                Process(token);
            }
            return "OK";
        }
        public void Process (Token token)
        {
            Console.WriteLine(token);
        }
    }
}
